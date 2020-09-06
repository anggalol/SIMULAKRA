using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

#pragma warning disable IDE0044

namespace SSELib.QnA.Question
{
    public class QuestionCollection : IXmlSerializable
    {
        internal SortedList<int, IQuestion> _questionSL;

        public QuestionCollection()
        {
            _questionSL = new SortedList<int, IQuestion>();
        }

        public ISimulationType SimulationType { get; set; }

        public IList<int> IDs => _questionSL.Keys;

        public IList<IQuestion> Questions => _questionSL.Values;

        public int Count => _questionSL.Count;

        public float TotalScore
        {
            get
            {
                float totalScore = 0f;
                foreach (int qid in IDs)
                    totalScore += _questionSL[qid].Score;

                return totalScore;
            }
        }

        public IQuestion this[int id]
        {
            get => _questionSL[id];
            set => _questionSL[id] = value;
        }

        public bool Remove(int id)
        {
            return _questionSL.Remove(id);
        }

        public void RemoveAt(int index)
        {
            _questionSL.RemoveAt(index);
        }

        public void Clear()
        {
            _questionSL.Clear();
        }

        public bool TryGetQuestion(int id, out IQuestion question)
        {
            return _questionSL.TryGetValue(id, out question);
        }

        public bool ContainsId(int id)
        {
            return _questionSL.ContainsKey(id);
        }

        public bool ContainsQuestion(IQuestion question)
        {
            return _questionSL.ContainsValue(question);
        }

        public int IndexOfId(int id)
        {
            return _questionSL.IndexOfKey(id);
        }

        public int IndexOfQuestion(IQuestion question)
        {
            return _questionSL.IndexOfValue(question);
        }

        public void Add(int id, IQuestion question)
        {
            if (SimulationType == null)
                throw new ArgumentException("Provide the simulation type first before adding new object.");

            if (SimulationType.AllowableQuestionTypes is null)
            {
                if (Array.Exists(question.GetType().GetInterfaces(), p => p != typeof(IQuestion)))
                    throw new InvalidQuestionTypeException();
            }
            else
            {
                if (!Array.Exists(SimulationType.AllowableQuestionTypes, p => p == question.GetType().AssemblyQualifiedName))
                    throw new InvalidQuestionTypeException();
            }

            _questionSL.Add(id, question);
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            reader.ReadStartElement("QuestionCollection");

            // Tipe simulasi
            Type simulationType = Type.GetType(reader.GetAttribute("AssemblyQualifiedName"), true);

            XmlSerializer simulationTypeSerializer = new XmlSerializer(simulationType);
            reader.ReadStartElement("SimulationType");
            SimulationType = (ISimulationType)simulationTypeSerializer.Deserialize(reader);
            reader.ReadEndElement();

            // Daftar data pertanyaan
            reader.ReadStartElement("Questions");
            while (reader.IsStartElement("IQuestion"))
            {
                Type type = Type.GetType(reader.GetAttribute("AssemblyQualifiedName"));
                int id = int.Parse(reader.GetAttribute("id"));

                XmlSerializer serializer = new XmlSerializer(type);
                reader.ReadStartElement("IQuestion");
                _questionSL.Add(id, (IQuestion)serializer.Deserialize(reader));
                reader.ReadEndElement();
            }
            reader.ReadEndElement();
        }

        public void WriteXml(XmlWriter writer)
        {
            // Tipe Simulasi
            writer.WriteStartElement("SimulationType");
            writer.WriteAttributeString("AssemblyQualifiedName", SimulationType.GetType().AssemblyQualifiedName);

            XmlSerializer simulationTypeSerializer = new XmlSerializer(SimulationType.GetType());
            simulationTypeSerializer.Serialize(writer, SimulationType);
            writer.WriteEndElement();

            // Daftar data pertanyaan
            writer.WriteStartElement("Questions");
            foreach (KeyValuePair<int, IQuestion> qkv in _questionSL)
            {
                writer.WriteStartElement("IQuestion");
                writer.WriteAttributeString("AssemblyQualifiedName", qkv.Value.GetType().AssemblyQualifiedName);
                writer.WriteAttributeString("id", qkv.Key.ToString());

                XmlSerializer serializer = new XmlSerializer(qkv.Value.GetType());
                serializer.Serialize(writer, qkv.Value);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }
    }
}

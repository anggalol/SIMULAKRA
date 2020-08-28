using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Schema;

namespace SSELib.Question
{
    public class QuestionCollection : SortedList<int, IQuestion>, IXmlSerializable
    {
        public QuestionCollection()
            : base()
        {
        }

        public ISimulationType SimulationType { get; set; }

        public new void Add(int id, IQuestion question)
        {
            if (SimulationType == null)
                throw new ArgumentException("Provide the simulation type first before adding new object.");

            if (SimulationType.AllowableQuestionTypes.Length == 0)
            {
                if (Array.Exists(question.GetType().GetInterfaces(), p => p != typeof(IQuestion)))
                    throw new InvalidQuestionTypeException();
            }
            else
            {
                if (!Array.Exists(SimulationType.AllowableQuestionTypes, p => p == question.GetType().AssemblyQualifiedName))
                    throw new InvalidQuestionTypeException();
            }

            base.Add(id, question);
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            reader.ReadStartElement("QuestionCollection");
            {
                // Tipe simulasi
                Type simulationType = Type.GetType(reader.GetAttribute("AssemblyQualifiedName"), true);

                XmlSerializer simulationTypeSerializer = new XmlSerializer(simulationType);
                reader.ReadStartElement("SimulationType");
                SimulationType = (ISimulationType)simulationTypeSerializer.Deserialize(reader);
                reader.ReadEndElement();
            }
            {
                // Daftar data pertanyaan
                reader.ReadStartElement("Questions");
                while (reader.IsStartElement("IQuestion"))
                {
                    Type type = Type.GetType(reader.GetAttribute("AssemblyQualifiedName"));
                    int id = int.Parse(reader.GetAttribute("id"));

                    XmlSerializer serializer = new XmlSerializer(type);
                    reader.ReadStartElement("IQuestion");
                    this.Add(id, (IQuestion)serializer.Deserialize(reader));
                    reader.ReadEndElement();
                }
                reader.ReadEndElement();
            }
            reader.ReadEndElement();
        }

        public void WriteXml(XmlWriter writer)
        {
            {
                // Tipe simulasi
                writer.WriteStartElement("SimulationType");
                writer.WriteAttributeString("AssemblyQualifiedName", SimulationType.GetType().AssemblyQualifiedName);

                XmlSerializer simulationTypeSerializer = new XmlSerializer(SimulationType.GetType());
                simulationTypeSerializer.Serialize(writer, SimulationType);
                writer.WriteEndElement();
            }
            {
                // Daftar data pertanyaan
                writer.WriteStartElement("Questions");
                foreach (KeyValuePair<int, IQuestion> qkv in this)
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
}

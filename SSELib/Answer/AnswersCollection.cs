using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Schema;
using SSELib.Question;

namespace SSELib.Answer
{
    public class AnswersCollection : SortedList<int, IAnswers>, IXmlSerializable
    {
        public AnswersCollection()
            : base()
        {
        }

        public void GenerateDefaultAnswersData(QuestionCollection qc)
        {
            foreach (int qid in qc.Keys)
            {
                IAnswers ans = (IAnswers)InstanceFactory.CreateInstance(qc[qid].AnswersType);
                ans.Length = qc[qid].MustAnsweredOptions;
                ans.IsDoubt = false;
                foreach (int aid in qc[qid].AnswerKeys.IDs)
                    ans.Add(aid, ans.DefaultAnswersValue);
                
                base.Add(qid, ans);
            }
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            reader.ReadStartElement("AnswersCollection");
            while (reader.IsStartElement("IAnswers"))
            {
                Type answerType = Type.GetType(reader.GetAttribute("AssemblyQualifiedName"));
                int id = int.Parse(reader.GetAttribute("id"));

                XmlSerializer serializer = new XmlSerializer(answerType);
                reader.ReadStartElement("IAnswers");
                base.Add(id, (IAnswers)serializer.Deserialize(reader));
                reader.ReadEndElement();
            }
            reader.ReadEndElement();
        }

        public void WriteXml(XmlWriter writer)
        {
            foreach (KeyValuePair<int, IAnswers> anskv in this)
            {
                writer.WriteStartElement("IAnswers");
                writer.WriteAttributeString("AssemblyQualifiedName", anskv.Value.GetType().AssemblyQualifiedName);
                writer.WriteAttributeString("id", anskv.Key.ToString());

                XmlSerializer serializer = new XmlSerializer(anskv.Value.GetType());
                serializer.Serialize(writer, anskv.Value);
                writer.WriteEndElement();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace SSELib.Answer
{
    internal static class AnswersSerializerHelper
    {
        internal static void ReadXml(XmlReader reader, IAnswers answers)
        {
            answers.Length = int.Parse(reader.GetAttribute("length"));
            answers.IsDoubt = bool.Parse(reader.GetAttribute("isdoubt"));

            reader.ReadStartElement(answers.GetType().Name);
            while (reader.IsStartElement("answer"))
            {
                int answerid = int.Parse(reader.GetAttribute("answerid"));

                XmlSerializer serializer = new XmlSerializer(typeof(string));
                reader.ReadStartElement("answer");
                answers.Add(answerid, (string)serializer.Deserialize(reader));
                reader.ReadEndElement();
            }
            reader.ReadEndElement();
        }

        internal static void WriteXml(XmlWriter writer, IAnswers answers)
        {
            writer.WriteAttributeString("length", answers.Length.ToString());
            writer.WriteAttributeString("isdoubt", answers.IsDoubt.ToString());

            foreach (int ansid in answers.IDs)
            {
                writer.WriteStartElement("answer");
                writer.WriteAttributeString("answerid", ansid.ToString());

                XmlSerializer serializer = new XmlSerializer(typeof(string));
                serializer.Serialize(writer, answers[ansid]);
                writer.WriteEndElement();
            }
        }
    }
}

using System.Reflection;
using System.Xml;
using System.Xml.Serialization;

namespace SSELib.QnA.Question
{
    internal static class QSH
    {
        internal static void ReadXml(XmlReader reader, IQuestion question)
        {
            reader.ReadStartElement();
            foreach (PropertyInfo prop in question.GetType().GetProperties())
            {
                CustomSerializationAttribute customAttr = prop.GetCustomAttribute<CustomSerializationAttribute>();
                if (prop.CanWrite)
                {
                    if (customAttr is null)
                    {
                        reader.ReadStartElement();
                        XmlSerializer serializer = new XmlSerializer(prop.PropertyType);
                        prop.SetValue(question, serializer.Deserialize(reader));
                        reader.ReadEndElement();
                    }
                    else
                    {
                        _ = typeof(MultipleAnswerQuestion).GetMethod(customAttr.DeserializerMethod,
                            BindingFlags.NonPublic | BindingFlags.Instance).Invoke(question, new object[] { reader });
                    }
                }
            }
        }

        internal static void WriteXml(XmlWriter writer, IQuestion question)
        {
            foreach (PropertyInfo prop in question.GetType().GetProperties())
            {
                if (prop.CanWrite)
                {
                    CustomSerializationAttribute customAttr = prop.GetCustomAttribute<CustomSerializationAttribute>();
                    if (customAttr is null)
                    {
                        // Serializer default
                        writer.WriteStartElement(prop.Name);
                        XmlSerializer serializer = new XmlSerializer(prop.PropertyType);
                        serializer.Serialize(writer, prop.GetValue(question));
                        writer.WriteEndElement();
                    }
                    else
                    {
                        // Jika terdapat atribut CustomSerializationAttribute, eksekusikan metode yang bersangkutan
                        _ = typeof(MultipleAnswerQuestion).GetMethod(customAttr.SerializerMethod,
                            BindingFlags.NonPublic | BindingFlags.Instance).Invoke(question, new object[] { writer });
                    }
                }
            }
        }

        internal static void SerializeOptionsText(XmlWriter writer, string[,] optionsText)
        {
            writer.WriteStartElement("OptionsText");
            writer.WriteAttributeString("row", optionsText.GetLength(0).ToString());
            writer.WriteAttributeString("col", optionsText.GetLength(1).ToString());
            for (int i = 0; i < optionsText.GetLength(0); i++)
            {
                for (int j = 0; j < optionsText.GetLength(1); j++)
                {
                    writer.WriteStartElement("item");
                    writer.WriteAttributeString("coordinate", $"[{i}, {j}]");
                    writer.WriteString(optionsText[i, j]);
                    writer.WriteEndElement();
                }
            }
            writer.WriteEndElement();
        }

        internal static string[,] DeserializeOptionsText(XmlReader reader)
        {
            int row = int.Parse(reader.GetAttribute("row"));
            int col = int.Parse(reader.GetAttribute("col"));
            string[,] result = new string[row, col];
            reader.ReadStartElement();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                    result[i, j] = reader.ReadElementContentAsString();
            }
            reader.ReadEndElement();

            return result;
        }
    }
}

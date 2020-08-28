using System.IO;
using System.Xml.Serialization;

namespace SSELib.Answer
{
    public class AnswersCollectionSerializer : IGenericSerialization
    {
        private readonly string _filename;

        private AnswersCollectionSerializer()
        {
        }

        public AnswersCollectionSerializer(string filename)
        {
            _filename = filename;
        }

        public void Serialize(object acol)
        {
            XmlSerializer serializer = new XmlSerializer((acol as AnswersCollection).GetType());
            TextWriter writer = new StreamWriter(_filename);
            serializer.Serialize(writer, acol);

            writer.Close();
        }

        public object Deserialize()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(AnswersCollection));
            FileStream stream = new FileStream(_filename, FileMode.Open);

            return (AnswersCollection)serializer.Deserialize(stream);
        }
    }
}

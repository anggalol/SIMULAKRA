using System.IO;
using System.Xml.Serialization;

namespace SSELib.Question
{
    public class QuestionCollectionSerializer : IGenericSerialization
    {
        private readonly string _filename;

        private QuestionCollectionSerializer()
        {
        }

        public QuestionCollectionSerializer(string filename)
        {
            _filename = filename;
        }

        public void Serialize(object qcol)
        {
            XmlSerializer serializer = new XmlSerializer((qcol as QuestionCollection).GetType());
            TextWriter writer = new StreamWriter(_filename);
            serializer.Serialize(writer, qcol);

            writer.Close();
        }

        public object Deserialize()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(QuestionCollection));
            FileStream stream = new FileStream(_filename, FileMode.Open);

            return (QuestionCollection)serializer.Deserialize(stream);
        }
    }
}

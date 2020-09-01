using System.IO;
using System.Xml.Serialization;

namespace SSELib.QnA
{
    public class SerializerHelper
    {
        private readonly string _filename;

        public SerializerHelper(string filename)
        {
            _filename = filename;
        }

        public void Serialize(object obj)
        {
            if (!Directory.Exists(Path.GetDirectoryName(_filename)))
                Directory.CreateDirectory(Path.GetDirectoryName(_filename));

            XmlSerializer serializer = new XmlSerializer(obj.GetType());
            TextWriter writer = new StreamWriter(_filename);
            serializer.Serialize(writer, obj);

            writer.Close();
        }

        public T Deserialize<T>() where T : class
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            FileStream stream = new FileStream(_filename, FileMode.Open);

            return (T)serializer.Deserialize(stream);
        }
    }
}

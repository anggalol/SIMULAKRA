using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace SSELib.QnA.Question
{
    public class AnswerKeys : IXmlSerializable
    {
        private SortedList<int, Key> _keysl;

        public AnswerKeys()
        {
            _keysl = new SortedList<int, Key>();
        }

        public int KeyCount => _keysl.Count;

        public IList<int> IDs => _keysl.Keys;

        public void Add(int id, Key key)
        {
            _keysl.Add(id, key);
        }

        public Key this[int id]
        {
            get => _keysl[id];
            set => _keysl[id] = value;
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            reader.ReadStartElement(nameof(AnswerKeys));
            while (reader.IsStartElement(nameof(Key)))
            {
                int keyid = int.Parse(reader.GetAttribute("keyid"));

                XmlSerializer serializer = new XmlSerializer(typeof(Key));
                reader.ReadStartElement(nameof(Key));
                _keysl.Add(keyid, (Key)serializer.Deserialize(reader));
                reader.ReadEndElement();
            }
            reader.ReadEndElement();
        }

        public void WriteXml(XmlWriter writer)
        {
            foreach (KeyValuePair<int, Key> keykv in _keysl)
            {
                writer.WriteStartElement(nameof(Key));
                writer.WriteAttributeString("keyid", keykv.Key.ToString());

                XmlSerializer serializer = new XmlSerializer(typeof(Key));
                serializer.Serialize(writer, keykv.Value);
                writer.WriteEndElement();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

#pragma warning disable IDE0044

namespace SSELib.AnswerKey
{
    public class AnswerKeys : IXmlSerializable
    {
        private SortedList<int, Key> _keysl;

        public AnswerKeys()
        {
            _keysl = new SortedList<int, Key>();
        }

        public int Length { get; set; }

        [XmlIgnore]
        public IList<int> IDs => _keysl.Keys;

        public Key this[int id]
        {
            get => _keysl[id];
            set
            {
                if (_keysl.Count == Length)
                    throw new IndexOutOfRangeException();

                if (!_keysl.Keys.Contains(id))
                    _keysl.Add(id, value);
                else
                    _keysl[id] = value;
            }
        }
        
        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            Length = int.Parse(reader.GetAttribute("length"));

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
            writer.WriteAttributeString("length", Length.ToString());

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

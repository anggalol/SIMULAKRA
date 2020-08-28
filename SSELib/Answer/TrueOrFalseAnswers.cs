using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Schema;
using ASH = SSELib.Answer.AnswersSerializerHelper;

namespace SSELib.Answer
{
    public class TrueOrFalseAnswers: IAnswers, IXmlSerializable
    {
        private SortedList<int, string> _anssl;

        public TrueOrFalseAnswers()
        {
            _anssl = new SortedList<int, string>();
        }

        public bool IsDoubt { get; set; }

        public int Length { get; set; }

        public IList<int> IDs => _anssl.Keys;

        public string DefaultAnswersValue => string.Empty;

        public void Add(int id, string answer)
        {
            if (_anssl.Count == Length)
                throw new ArgumentException("The length of the answers is not sufficient to perform this operation.");

            _anssl.Add(id, answer);
        }

        public string this[int id]
        {
            get => _anssl[id];
            set => _anssl[id] = value;
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            ASH.ReadXml(reader, this);
        }

        public void WriteXml(XmlWriter writer)
        {
            ASH.WriteXml(writer, this);
        }
    }
}

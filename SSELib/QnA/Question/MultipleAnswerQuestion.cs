using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace SSELib.QnA.Question
{
    public class MultipleAnswerQuestion : IQuestion, IXmlSerializable
    {
        private AnswerKeys _keys;
        private Options _options;
        private float _score;
        private string[,] _text;

        public Options AnswerOptions
        {
            get => _options;
            set
            {
                if (value.Col != 1)
                    throw new ArgumentException("The column length must be one.");

                _options = value;
            }
        }

        public int MustAnsweredOptions => AnswerOptions.Row;

        public BaseAxis BaseAxis => BaseAxis.Column;

        public float Score
        {
            get => _score;
            set
            {
                if (value <= 0f)
                    throw new ArgumentException("The score must be positive.");

                _score = value;
            }
        }

        public bool UsingAudio { get; set; }

        [CustomSerialization(SerializerMethod = nameof(SerializeOptionsText), DeserializerMethod = nameof(DeserializeOptionsText))]
        public string[,] OptionsText
        {
            get => _text;
            set
            {
                if (AnswerOptions.Col == 0 && AnswerOptions.Row == 0)
                    throw new ArgumentNullException("Provides the value for AnswerOptions first.");
                if (value.Length != AnswerOptions.Row * AnswerOptions.Col
                    || value.GetLength(0) != AnswerOptions.Row || value.GetLength(1) != AnswerOptions.Col)
                    throw new ArgumentException("The dimension of the following value must be the same as AnswerOptions dimension.");

                _text = value;
            }
        }
        
        public AnswerKeys AnswerKeys
        {
            get => _keys;
            set
            {
                if (value.KeyCount != MustAnsweredOptions)
                    throw new ArgumentException("The length of the answer keys must be the same as the value of MustAnsweredOptions.");

                _keys = value;
            }
        }

        public Type AnswersType => throw new NotImplementedException();

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            QSH.ReadXml(reader, this);
        }

        public void WriteXml(XmlWriter writer)
        {
            QSH.WriteXml(writer, this);
        }

        private void SerializeOptionsText(XmlWriter writer)
        {
            QSH.SerializeOptionsText(writer, OptionsText);
        }

        private void DeserializeOptionsText(XmlReader reader)
        {
            OptionsText = QSH.DeserializeOptionsText(reader);
        }
    }
}

using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace SSELib.QnA.Question
{
    public class MultiTabQuestion : IQuestion, IXmlSerializable
    {
        private AnswerKeys _keys;
        private Options _options;
        private int _mustAnsweredOptions;
        private BaseAxis _baseAxis;
        private float _score;
        private string[,] _text;

        public Options AnswerOptions
        {
            get => _options;
            set
            {
                if (value.Row <= 0 || value.Col <= 0)
                    throw new ArgumentException("The value of X or the value of Y must be positive");

                _options = value;
            }
        }

        public int MustAnsweredOptions
        {
            get => _mustAnsweredOptions;
            set
            {
                switch (BaseAxis)
                {
                    case BaseAxis.Row:
                        if (value > AnswerOptions.Row)
                            throw new ArgumentOutOfRangeException("The value cannot greater than column length");
                        break;
                    case BaseAxis.Column:
                        if (value > AnswerOptions.Col)
                            throw new ArgumentOutOfRangeException("The value cannot greater than column length");
                        break;
                    default:
                        throw new ArgumentException("The BaseAxis value is not valid.");
                }
                if (value <= 0)
                    throw new ArgumentException("The value must be positive.");

                _mustAnsweredOptions = value;
            }
        }

        public BaseAxis BaseAxis
        {
            get => _baseAxis;
            set
            {
                if (value == BaseAxis.RowColumn || value == BaseAxis.None)
                    throw new NotSupportedException("The following base axis is not supported for this question type. Use Column or Row instead.");

                _baseAxis = value;
            }
        }

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

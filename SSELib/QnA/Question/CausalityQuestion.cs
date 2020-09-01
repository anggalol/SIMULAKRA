using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace SSELib.QnA.Question
{
    public class CausalityQuestion : IQuestion, IXmlSerializable
    {
        private AnswerKeys _keys;
        private float _score;

        public Options AnswerOptions => new Options(3, 2);

        public int MustAnsweredOptions => 3;

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

        public string[,] OptionsText => new string[3, 2]
        {
            { "Benar", "Salah" },
            { "Benar", "Salah" },
            { "Benar", "Salah" }
        };

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
    }
}

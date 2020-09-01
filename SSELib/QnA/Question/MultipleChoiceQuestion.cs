using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace SSELib.QnA.Question
{
    public class MultipleChoiceQuestion : IQuestion, IXmlSerializable
    {
        private AnswerKeys _keys;
        private Options _answerOptions;
        private float _score;

        public Options AnswerOptions
        {
            get => _answerOptions;
            set
            {
                if (value.Col != 1)
                    throw new ArgumentException("The columnt length must be one.");
                if (value.Row <= 0 || value.Row > 26)
                    throw new ArgumentException("The row length must be positive and less than 26.");

                _answerOptions = value;
            }
        }

        public int MustAnsweredOptions => 1;

        public BaseAxis BaseAxis => BaseAxis.Row;

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

        public string[,] OptionsText
        {
            get
            {
                string[,] options = new string[1, MustAnsweredOptions];
                for (int i = 0; i < MustAnsweredOptions; i++)
                    options[i, 1] = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"[i].ToString();

                return options;
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

using System;
using System.Xml.Serialization;
using SSELib.AnswerKey;

namespace SSELib.Question
{
    public class EssayQuestion : IQuestion
    {
        [XmlIgnore]
        private float _score;
        private AnswerKeys _keys;

        public Options AnswerOptions => new Options(1, 1);

        public int MustAnsweredOptions => 1;

        public BaseAxis BaseAxis => BaseAxis.Y;

        public float Score
        {
            get => _score;
            set
            {
                if (_score <= 0f)
                    throw new ArgumentException("The score must be positive");

                _score = value;
            }
        }

        public bool UsingAudio { get; set; }

        public AnswerKeys AnswerKeys
        {
            get => _keys;
            set
            {
                if (value.Length != MustAnsweredOptions)
                    throw new ArgumentException("The length of the answer keys must be the same as the value of MustAnsweredOptions.");

                _keys = value;
            }
        }

        [XmlIgnore]
        public Type AnswersType => throw new NotImplementedException();

        public string[,] OptionsText => null;
    }
}

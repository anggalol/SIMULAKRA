using System;
using System.Xml.Serialization;
using SSELib.AnswerKey;
using SSELib.Answer;

namespace SSELib.Question
{
    public class CausalityQuestion : IQuestion
    {
        private AnswerKeys _keys;
        private float _score;

        public Options AnswerOptions => new Options(2, 3);

        public int MustAnsweredOptions => 3;

        public BaseAxis BaseAxis => BaseAxis.X;

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

        public string[,] OptionsText => new string[3, 2] { { "Benar", "Salah" }, { "Benar", "Salah" }, { "Benar", "Salah" } };

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

        public Type AnswersType => throw new NotImplementedException();
    }
}

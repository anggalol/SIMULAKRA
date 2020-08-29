using System;
using System.Windows.Forms;
using SSELib.AnswerKey;
using SSELib.Answer;
using SSELib.AnswerBox;

namespace SSELib.Question
{
    public class TrueOrFalseQuestion : IQuestion
    {
        private AnswerKeys _keys;
        private float _score;

        public Options AnswerOptions => new Options(2, 1);

        public int MustAnsweredOptions => 1;

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

        public string[,] OptionsText => new string[1, 2] { { "Benar", "Salah" } };

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

        public IAnswers GetAnswers() => new TrueOrFalseAnswers();

        public IAnswerBox AnswerBox => throw new NotImplementedException();
    }
}

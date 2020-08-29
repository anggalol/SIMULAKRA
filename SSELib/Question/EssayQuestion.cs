using System;
using System.Windows.Forms;
using SSELib.AnswerKey;
using SSELib.Answer;
using SSELib.AnswerBox;

namespace SSELib.Question
{
    public class EssayQuestion : IQuestion
    {
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
                if (value.KeyCount != MustAnsweredOptions)
                    throw new ArgumentException("The length of the answer keys must be the same as the value of MustAnsweredOptions.");

                _keys = value;
            }
        }

        public string[,] OptionsText => null;

        public IAnswers Answers => new EssayAnswers();

        public IAnswers GetAnswers()
        {
            return new EssayAnswers() { Length = 1 };
        }

        public IAnswerBox AnswerBox => throw new NotImplementedException();
    }
}

using System;
using System.Windows.Forms;
using SSELib.AnswerKey;
using SSELib.Answer;
using SSELib.AnswerBox;

namespace SSELib.Question
{
    public class MultipleChoiceQuestion : IQuestion
    {
        private AnswerKeys _keys;
        private Options _answerOptions;
        private float _score;

        public Options AnswerOptions
        {
            get => _answerOptions;
            set
            {
                if (value.X != 0)
                    throw new ArgumentException("The X value must be zero.");
                if (value.Y <= 0 || value.Y > 26)
                    throw new ArgumentException("The Y value must be positive and less than 26.");

                _answerOptions = value;
            }
        }

        public int MustAnsweredOptions => 1;

        public BaseAxis BaseAxis => BaseAxis.Y;

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

        public IAnswers GetAnswers() => new MultipleAnswerAnswers();

        public IAnswerBox AnswerBox => throw new NotImplementedException();
    }
}

using System;
using System.Xml.Serialization;
using SSELib.AnswerKey;
using SSELib.Answer;

namespace SSELib.Question
{
    public class MultipleAnswerQuestion : IQuestion
    {
        [XmlIgnore]
        private AnswerKeys _keys;
        private Options _answerOptions;
        private float _score;

        public Options AnswerOptions
        {
            get => _answerOptions;
            set
            {
                if (value.X != 1)
                    throw new ArgumentException("The X value must be one.");
                if (value.Y <= 0)
                    throw new ArgumentException("The Y value must be positive.");

                _answerOptions = value;
            }
        }

        public int MustAnsweredOptions => AnswerOptions.Y;

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
                if (value.Length != MustAnsweredOptions)
                    throw new ArgumentException("The length of the answer keys must be the same as the value of MustAnsweredOptions.");

                _keys = value;
            }
        }

        [XmlIgnore]
        public Type AnswersType => typeof(MultipleAnswerAnswers);

        public string[,] OptionsText { get; set; }
    }
}

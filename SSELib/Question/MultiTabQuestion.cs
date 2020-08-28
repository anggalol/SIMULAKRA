using System;
using System.Xml.Serialization;
using SSELib.AnswerKey;
using SSELib.Answer;

namespace SSELib.Question
{
    public class MultiTabQuestion : IQuestion
    {
        [XmlIgnore]
        private Options _answerOptions;
        private int _mustAnsweredOptions;
        private BaseAxis _baseAxis;
        private float _score;
        private AnswerKeys _keys;

        public Options AnswerOptions
        {
            get => _answerOptions;
            set
            {
                if (value.X <= 0 || value.Y <= 0)
                    throw new ArgumentException("The value of X or the value of Y must be positive");

                _answerOptions = value;
            }
        }

        public int MustAnsweredOptions
        {
            get => _mustAnsweredOptions;
            set
            {
                if (value > Math.Max(AnswerOptions.X, AnswerOptions.Y))
                    throw new ArgumentException("The value of this properties is not valid.");
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
                if (value == BaseAxis.XY)
                    throw new NotSupportedException("The following base axis is not supported for this question type. Use X or Y instead.");

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

        public string[,] OptionsText { get; set; }

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
    }
}

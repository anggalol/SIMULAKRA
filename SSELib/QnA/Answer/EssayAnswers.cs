using System.Collections.Generic;
using System.Xml.Serialization;
using MetroFramework.Controls;
using SSELib.QnA.AnswerBox;
using SSELib.QnA.Scoring;

namespace SSELib.QnA.Answer
{
    public class EssayAnswers : IAnswers
    {
        private SortedList<int, string> _answerSL;
        private string[,] _text;

        public EssayAnswers()
        {
            _answerSL = new SortedList<int, string>();
            AnswerBox = new EssayAnswerBox();
            DoubtCheckBox = new MetroCheckBox();
            QuestionScore = new EssayScoring();
        }

        public string this[int id]
        {
            get => _answerSL[id];
            set => _answerSL[id] = value;
        }

        public bool IsDoubt { get; set; }

        public int Count => _answerSL.Count;

        public IList<int> IDs => _answerSL.Keys;

        public string DefaultAnswersValue => string.Empty;

        [XmlIgnore]
        public string[,] OptionsText
        {
            get => _text;
            set
            {
                AnswerBox.UpdateOptions(value);
                _text = value;
            }
        }

        public AnswerBoxUserControl AnswerBox { get; }

        public MetroCheckBox DoubtCheckBox { get; }

        public IQuestionScore QuestionScore { get; }

        public void Add(int id, string answer)
        {
            _answerSL.Add(id, answer);
        }
    }
}

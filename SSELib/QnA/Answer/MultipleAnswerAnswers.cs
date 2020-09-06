using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Serialization;
using MetroFramework.Controls;
using SSELib.QnA.AnswerBox;
using SSELib.QnA.Scoring;

namespace SSELib.QnA.Answer
{
    public class MultipleAnswerAnswers : IAnswers
    {
        private SortedList<int, string> _answerSL;
        private string[,] _text;

        public MultipleAnswerAnswers()
        {
            _answerSL = new SortedList<int, string>();
            AnswerBox = new MultipleAnswerAnswerBox();
            DoubtCheckBox = new MetroCheckBox();
            QuestionScore = new MultipleAnswerScoring();
        }

        public bool IsDoubt { get; set; }

        public int Count => _answerSL.Count;

        public IList<int> IDs => _answerSL.Keys;

        public string DefaultAnswersValue => CheckState.Unchecked.ToString();

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

        public string this[int id]
        {
            get => _answerSL[id];
            set => _answerSL[id] = value;
        }

        public void Add(int id, string answer)
        {
            _answerSL.Add(id, answer);
        }
    }
}

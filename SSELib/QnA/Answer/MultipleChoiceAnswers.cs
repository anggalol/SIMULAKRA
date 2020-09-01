using System.Collections.Generic;
using System.Xml.Serialization;
using MetroFramework.Controls;
using SSELib.QnA.AnswerBox;

namespace SSELib.QnA.Answer
{
    public class MultipleChoiceAnswers : IAnswers
    {
        private SortedList<int, string> _answerSL;
        private string[,] _text;

        public MultipleChoiceAnswers()
        {
            _answerSL = new SortedList<int, string>();
            AnswerBox = new MultipleChoiceAnswerBox();
            DoubtCheckBox = new MetroCheckBox();
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

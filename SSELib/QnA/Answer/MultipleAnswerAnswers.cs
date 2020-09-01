using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Serialization;
using MetroFramework.Controls;
using SSELib.QnA.AnswerBox;

namespace SSELib.QnA.Answer
{
    public class MultipleAnswerAnswers : IAnswers
    {
        private SortedList<int, string> _answersl;
        private string[,] _optionsText;

        public MultipleAnswerAnswers()
        {
            _answersl = new SortedList<int, string>();
            AnswerBox = new MultipleAnswerAnswerBox();
            DoubtCheckBox = new MetroCheckBox();
        }

        public bool IsDoubt { get; set; }

        public int Count => _answersl.Count;

        public IList<int> IDs => _answersl.Keys;

        public string DefaultAnswersValue => CheckState.Unchecked.ToString();

        [XmlIgnore]
        public string[,] OptionsText
        {
            get => _optionsText;
            set
            {
                AnswerBox.UpdateOptions(value);
                _optionsText = value;
            }
        }

        public AnswerBoxUserControl AnswerBox { get; }

        public MetroCheckBox DoubtCheckBox { get; }

        public string this[int id]
        {
            get => _answersl[id];
            set => _answersl[id] = value;
        }

        public void Add(int id, string answer)
        {
            _answersl.Add(id, answer);
        }
    }
}

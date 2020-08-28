using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using SSELib.Answer;
using SSELib.Question;

namespace SSELib.AnswerBox
{
    public partial class MultipleChoiceAnswerBox : MetroUserControl, IAnswerBox
    {
        public MultipleChoiceAnswerBox(IAnswers answers, IQuestion question)
        {
            Answers = answers;
            for (int i = 0; i < question.MustAnsweredOptions; i++)
                optionsRBL.Items.Add(question.OptionsText[i, 1]);

            InitializeComponent();
            optionsRBL.SelectedIndexChanged += OptionsRBL_SelectedIndexChanged;
        }

        public IAnswers Answers { get; }

        private void OptionsRBL_SelectedIndexChanged(object sender, EventArgs e)
        {
            Answers[0] = (string)optionsRBL.SelectedItem;
        }
    }
}

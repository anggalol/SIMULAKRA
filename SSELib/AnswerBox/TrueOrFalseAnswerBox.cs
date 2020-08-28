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
    public partial class TrueOrFalseAnswerBox : MetroUserControl, IAnswerBox
    {
        public TrueOrFalseAnswerBox(IAnswers answers, IQuestion question)
        {
            Answers = answers;
            for (int i = 0; i < question.MustAnsweredOptions; i++)
                optionsRBL.Items.Add(question.OptionsText[1, i]);

            InitializeComponent();
            optionsRBL.SelectedIndexChanged += OptionsRBL_SelectedIndexChanged;
        }

        public IAnswers Answers { get; }

        private void OptionsRBL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (optionsRBL.SelectedIndex == 0)
                Answers[0] = bool.TrueString;
            else
                Answers[0] = bool.FalseString;
        }
    }
}

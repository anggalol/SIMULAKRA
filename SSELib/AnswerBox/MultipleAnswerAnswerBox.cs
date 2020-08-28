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
    public partial class MultipleAnswerAnswerBox : MetroUserControl, IAnswerBox
    {
        public MultipleAnswerAnswerBox(IAnswers answers, IQuestion question)
        {
            Answers = answers;
            for (int i = 0; i < question.MustAnsweredOptions; i++)
                optionsCLB.Items.Add(question.OptionsText[i, 1]);
            
            InitializeComponent();
            optionsCLB.SelectedIndexChanged += OptionsCLB_SelectedIndexChanged;
        }

        public IAnswers Answers { get; }

        private void OptionsCLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < optionsCLB.Items.Count; i++)
            {
                if (optionsCLB.GetSelected(i))
                    Answers[i] = bool.TrueString;
                else
                    Answers[i] = bool.FalseString;
            }
        }
    }
}

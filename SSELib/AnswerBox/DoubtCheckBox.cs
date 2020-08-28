using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Controls;
using SSELib.Answer;

namespace SSELib.AnswerBox
{
    public partial class DoubtCheckBox : MetroCheckBox
    {
        public DoubtCheckBox(IAnswers answers)
        {
            Answers = answers;
            InitializeComponent();

            CheckedChanged += DoubtCheckBox_CheckedChanged;
        }

        public IAnswers Answers { get; }

        private void DoubtCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Checked)
                Answers.IsDoubt = true;
            else
                Answers.IsDoubt = false;
        }
    }
}

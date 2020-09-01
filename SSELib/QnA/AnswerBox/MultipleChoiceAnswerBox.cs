using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSELib.QnA.AnswerBox
{
    public partial class MultipleChoiceAnswerBox : AnswerBoxUserControl
    {
        private AnswerBoxElementSize _size;

        public MultipleChoiceAnswerBox()
        {
            InitializeComponent();
            optionsRBLB.SelectedIndexChanged += OptionsRBLB_SelectedIndexChanged;
        }

        private void OptionsRBLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            optionsRBLB.Enabled = false;
            OnAnswersChanged(new AnswersChangedEventArgs(optionsRBLB.SelectedIndex, (string)optionsRBLB.SelectedItem));
            optionsRBLB.Enabled = true;
        }

        public override AnswerBoxElementSize AnswerBoxElementSize
        {
            get => _size;
            set
            {
                switch (value)
                {
                    case AnswerBoxElementSize.Small:
                        optionsRBLB.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
                        break;
                    case AnswerBoxElementSize.Standard:
                        optionsRBLB.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
                        break;
                    case AnswerBoxElementSize.Big:
                        optionsRBLB.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
                        break;
                }

                _size = value;
            }
        }

        public override void UpdateOptions(string[,] optionsText)
        {
            optionsRBLB.Items.Clear();
            for (int i = 0; i < optionsText.GetLength(0); i++)
                optionsRBLB.Items.Add(optionsText[i, 0]);
        }
    }
}

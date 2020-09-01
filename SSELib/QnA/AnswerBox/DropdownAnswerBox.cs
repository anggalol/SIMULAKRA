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
    public partial class DropdownAnswerBox : AnswerBoxUserControl
    {
        private AnswerBoxElementSize _size;

        public DropdownAnswerBox()
        {
            InitializeComponent();
            optionsMCB.SelectedIndexChanged += OptionsMCB_SelectedIndexChanged;
        }

        private void OptionsMCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            optionsMCB.Enabled = false;
            OnAnswersChanged(new AnswersChangedEventArgs(optionsMCB.SelectedIndex, (string)optionsMCB.SelectedItem));
            optionsMCB.Enabled = true;
        }

        public override AnswerBoxElementSize AnswerBoxElementSize
        {
            get => _size;
            set
            {
                switch (value)
                {
                    case AnswerBoxElementSize.Small:
                        optionsMCB.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
                        break;
                    case AnswerBoxElementSize.Standard:
                        optionsMCB.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
                        break;
                    case AnswerBoxElementSize.Big:
                        optionsMCB.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
                        break;
                }

                _size = value;
            }
        }

        public override void UpdateOptions(string[,] optionsText)
        {
            optionsMCB.Items.Clear();
            for (int i = 0; i < optionsText.GetLength(0); i++)
                optionsMCB.Items.Add(optionsText[i, 0]);
        }
    }
}

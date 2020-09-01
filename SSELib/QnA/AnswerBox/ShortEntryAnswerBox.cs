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
    public partial class ShortEntryAnswerBox : AnswerBoxUserControl
    {
        private AnswerBoxElementSize _size;

        public ShortEntryAnswerBox()
        {
            InitializeComponent();
            optionsMTB.TextChanged += OptionsMTB_TextChanged;
        }

        private void OptionsMTB_TextChanged(object sender, EventArgs e)
        {
            OnAnswersChanged(new AnswersChangedEventArgs(0, optionsMTB.Text));
        }

        public override void UpdateOptions(string[,] optionsText)
        {
            optionsMTB.WaterMark = optionsText[0, 0];
        }

        public override AnswerBoxElementSize AnswerBoxElementSize
        {
            get => _size;
            set
            {
                switch (value)
                {
                    case AnswerBoxElementSize.Small:
                        optionsMTB.Height = 23;
                        break;
                    case AnswerBoxElementSize.Standard:
                        optionsMTB.Height = 29;
                        break;
                    case AnswerBoxElementSize.Big:
                        optionsMTB.Height = 34;
                        break;
                }

                _size = value;
            }
        }
    }
}

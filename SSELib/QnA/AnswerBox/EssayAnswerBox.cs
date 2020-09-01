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
    public partial class EssayAnswerBox : AnswerBoxUserControl
    {
        private AnswerBoxElementSize _size;

        public EssayAnswerBox()
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
                        optionsMTB.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
                        break;
                    case AnswerBoxElementSize.Standard:
                        optionsMTB.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
                        break;
                    case AnswerBoxElementSize.Big:
                        optionsMTB.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
                        break;
                }

                _size = value;
            }
        }
    }
}

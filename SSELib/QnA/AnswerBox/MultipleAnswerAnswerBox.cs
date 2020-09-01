using System.Drawing;
using System.Windows.Forms;

namespace SSELib.QnA.AnswerBox
{
    public partial class MultipleAnswerAnswerBox : AnswerBoxUserControl
    {
        private AnswerBoxElementSize _size;

        public MultipleAnswerAnswerBox()
        {
            InitializeComponent();
            optionsCLB.ItemCheck += OptionsCLB_ItemCheck;
        }

        private void OptionsCLB_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            optionsCLB.Enabled = false;
            OnAnswersChanged(new AnswersChangedEventArgs(e.Index, e.NewValue.ToString()));
            optionsCLB.Enabled = true;
        }

        public override void UpdateOptions(string[,] optionsText)
        {
            optionsCLB.Items.Clear();
            for (int i = 0; i < optionsText.GetLength(0); i++)
                optionsCLB.Items.Add(optionsText[i, 0]);
        }

        public override AnswerBoxElementSize AnswerBoxElementSize
        {
            get => _size;
            set
            {
                switch (value)
                {
                    case AnswerBoxElementSize.Small:
                        optionsCLB.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
                        break;
                    case AnswerBoxElementSize.Standard:
                        optionsCLB.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
                        break;
                    case AnswerBoxElementSize.Big:
                        optionsCLB.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
                        break;
                }

                _size = value;
            }
        }
    }
}

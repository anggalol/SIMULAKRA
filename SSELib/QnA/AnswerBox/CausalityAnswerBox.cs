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
    public partial class CausalityAnswerBox : AnswerBoxUserControl
    {
        public AnswerBoxElementSize _size;

        public CausalityAnswerBox()
        {
            InitializeComponent();

            statementOptionsRBLB.SelectedIndexChanged += StatementOptionsRBLB_SelectedIndexChanged;
            causeOptionsRBLB.SelectedIndexChanged += CauseOptionsRBLB_SelectedIndexChanged;
            reasonOptionsRBLB.SelectedIndexChanged += ReasonOptionsRBLB_SelectedIndexChanged;
        }

        private void StatementOptionsRBLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            statementOptionsRBLB.Enabled = false;
            OnAnswersChanged(new AnswersChangedEventArgs(0, (string)statementOptionsRBLB.SelectedItem));
            statementOptionsRBLB.Enabled = true;
        }

        private void CauseOptionsRBLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            causeOptionsRBLB.Enabled = false;
            OnAnswersChanged(new AnswersChangedEventArgs(1, (string)causeOptionsRBLB.SelectedItem));
            causeOptionsRBLB.Enabled = true;
        }

        private void ReasonOptionsRBLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            reasonOptionsRBLB.Enabled = false;
            OnAnswersChanged(new AnswersChangedEventArgs(2, (string)reasonOptionsRBLB.SelectedItem));
            reasonOptionsRBLB.Enabled = true;
        }

        public override AnswerBoxElementSize AnswerBoxElementSize
        {
            get => _size;
            set
            {
                switch (value)
                {
                    case AnswerBoxElementSize.Small:
                        statementMetroLabel.FontSize = MetroFramework.MetroLabelSize.Small;
                        statementMetroLabel.Location = new Point(9, 6);
                        statementMetroLabel.Size = new Size(84, 15);
                        causeMetroLabel.FontSize = MetroFramework.MetroLabelSize.Small;
                        causeMetroLabel.Location = new Point(31, 49);
                        causeMetroLabel.Size = new Size(41, 15);
                        reasonMetroLabel.FontSize = MetroFramework.MetroLabelSize.Small;
                        reasonMetroLabel.Location = new Point(22, 92);
                        reasonMetroLabel.Size = new Size(58, 15);
                        statementOptionsRBLB.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
                        statementOptionsRBLB.Location = new Point(162, 3);
                        statementOptionsRBLB.Size = new Size(292, 21);
                        causeOptionsRBLB.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
                        causeOptionsRBLB.Location = new Point(162, 46);
                        causeOptionsRBLB.Size = new Size(292, 21);
                        reasonOptionsRBLB.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
                        reasonOptionsRBLB.Location = new Point(162, 89);
                        reasonOptionsRBLB.Size = new Size(292, 21);
                        break;
                    case AnswerBoxElementSize.Standard:
                        statementMetroLabel.FontSize = MetroFramework.MetroLabelSize.Medium;
                        statementMetroLabel.Location = new Point(9, 6);
                        statementMetroLabel.Size = new Size(96, 19);
                        causeMetroLabel.FontSize = MetroFramework.MetroLabelSize.Medium;
                        causeMetroLabel.Location = new Point(33, 52);
                        causeMetroLabel.Size = new Size(48, 19);
                        reasonMetroLabel.FontSize = MetroFramework.MetroLabelSize.Medium;
                        reasonMetroLabel.Location = new Point(23, 98);
                        reasonMetroLabel.Size = new Size(68, 19);
                        statementOptionsRBLB.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
                        statementOptionsRBLB.Location = new Point(162, 3);
                        statementOptionsRBLB.Size = new Size(278, 25);
                        causeOptionsRBLB.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
                        causeOptionsRBLB.Location = new Point(162, 49);
                        causeOptionsRBLB.Size = new Size(278, 25);
                        reasonOptionsRBLB.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
                        reasonOptionsRBLB.Location = new Point(162, 95);
                        reasonOptionsRBLB.Size = new Size(278, 25);
                        break;
                    case AnswerBoxElementSize.Big:
                        statementMetroLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
                        statementMetroLabel.Location = new Point(9, 3);
                        statementMetroLabel.Size = new Size(123, 25);
                        causeMetroLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
                        causeMetroLabel.Location = new Point(40, 52);
                        causeMetroLabel.Size = new Size(61, 25);
                        reasonMetroLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
                        reasonMetroLabel.Location = new Point(27, 101);
                        reasonMetroLabel.Size = new Size(86, 25);
                        statementOptionsRBLB.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
                        statementOptionsRBLB.Location = new Point(162, 3);
                        statementOptionsRBLB.Size = new Size(278, 28);
                        causeOptionsRBLB.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
                        causeOptionsRBLB.Location = new Point(162, 52);
                        causeOptionsRBLB.Size = new Size(278, 28);
                        reasonOptionsRBLB.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
                        reasonOptionsRBLB.Location = new Point(162, 101);
                        reasonOptionsRBLB.Size = new Size(278, 28);
                        break;
                }

                _size = value;
            }
        }

        public override void UpdateOptions(string[,] optionsText)
        {
            statementOptionsRBLB.Items.Clear();
            causeOptionsRBLB.Items.Clear();
            reasonOptionsRBLB.Items.Clear();

            statementOptionsRBLB.Items.Add(optionsText[0, 0]);
            statementOptionsRBLB.Items.Add(optionsText[0, 1]);
            causeOptionsRBLB.Items.Add(optionsText[1, 0]);
            causeOptionsRBLB.Items.Add(optionsText[1, 1]);
            reasonOptionsRBLB.Items.Add(optionsText[2, 0]);
            reasonOptionsRBLB.Items.Add(optionsText[2, 1]);
        }
    }
}

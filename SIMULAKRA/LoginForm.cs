using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Animation;

namespace SIMULAKRA
{
    public partial class LoginForm : MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();

            Size = new Size(327, 385);
        }

        private void browseSFMetroLink_Click(object sender, EventArgs e)
        {
            if (browseSFOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExpandAnimation formExpand = new ExpandAnimation();
                formExpand.Start(this, new Size(327, 461), TransitionType.EaseOutExpo, 3);
                formExpand.AnimationCompleted += FormExpand_AnimationCompleted;
            }
        }

        private void FormExpand_AnimationCompleted(object sender, EventArgs e)
        {
            titleMetroLabel.Visible = true;
            timeMetroLabel.Visible = true;
            startTimeMetroLabel.Visible = true;
        }

        private void aboutMetroLink_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace SIMULAKRA
{
    public partial class AboutForm : MetroForm
    {
        public AboutForm()
        {
            InitializeComponent();
            infoMetroTabControl.SelectedTab = aboutMetroTabPage;
        }

        private void pluginsMetroListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (int selectedIndex in pluginsMetroListView.SelectedIndices)
            {
                pluginInfoMetroTextBox.Text =
                    File.ReadAllText($"License\\{pluginsMetroListView.Items[selectedIndex].Text}.txt");
            }
        }

        private void becomePatreonMetroLink_Click(object sender, EventArgs e)
        {
            Process.Start("https://patreon.com/PakAngga");
        }

        private void okMetroButton_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
            GC.Collect();
        }
    }
}

namespace SSELib.QnA.AnswerBox
{
    partial class EssayAnswerBox
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.optionsMTB = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // optionsMTB
            // 
            // 
            // 
            // 
            this.optionsMTB.CustomButton.Image = null;
            this.optionsMTB.CustomButton.Location = new System.Drawing.Point(56, 1);
            this.optionsMTB.CustomButton.Name = "";
            this.optionsMTB.CustomButton.Size = new System.Drawing.Size(139, 139);
            this.optionsMTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.optionsMTB.CustomButton.TabIndex = 1;
            this.optionsMTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.optionsMTB.CustomButton.UseSelectable = true;
            this.optionsMTB.CustomButton.Visible = false;
            this.optionsMTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsMTB.Lines = new string[0];
            this.optionsMTB.Location = new System.Drawing.Point(0, 0);
            this.optionsMTB.MaxLength = 32767;
            this.optionsMTB.Multiline = true;
            this.optionsMTB.Name = "optionsMTB";
            this.optionsMTB.PasswordChar = '\0';
            this.optionsMTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.optionsMTB.SelectedText = "";
            this.optionsMTB.SelectionLength = 0;
            this.optionsMTB.SelectionStart = 0;
            this.optionsMTB.ShortcutsEnabled = true;
            this.optionsMTB.Size = new System.Drawing.Size(196, 141);
            this.optionsMTB.TabIndex = 0;
            this.optionsMTB.UseSelectable = true;
            this.optionsMTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.optionsMTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // EssayAnswerBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.optionsMTB);
            this.Name = "EssayAnswerBox";
            this.Size = new System.Drawing.Size(196, 141);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox optionsMTB;
    }
}

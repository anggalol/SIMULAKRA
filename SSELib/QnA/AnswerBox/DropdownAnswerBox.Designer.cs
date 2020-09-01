namespace SSELib.QnA.AnswerBox
{
    partial class DropdownAnswerBox
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
            this.optionsMCB = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // optionsMCB
            // 
            this.optionsMCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsMCB.FormattingEnabled = true;
            this.optionsMCB.ItemHeight = 23;
            this.optionsMCB.Location = new System.Drawing.Point(0, 0);
            this.optionsMCB.Name = "optionsMCB";
            this.optionsMCB.Size = new System.Drawing.Size(305, 29);
            this.optionsMCB.TabIndex = 0;
            this.optionsMCB.UseSelectable = true;
            // 
            // DropdownAnswerBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.optionsMCB);
            this.Name = "DropdownAnswerBox";
            this.Size = new System.Drawing.Size(305, 40);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox optionsMCB;
    }
}

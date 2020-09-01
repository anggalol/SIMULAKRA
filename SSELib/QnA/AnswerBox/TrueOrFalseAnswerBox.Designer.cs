namespace SSELib.QnA.AnswerBox
{
    partial class TrueOrFalseAnswerBox
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
            this.optionsRBLB = new SSELib.QnA.AnswerBox.RadioButtonListBox();
            this.SuspendLayout();
            // 
            // optionsRBLB
            // 
            this.optionsRBLB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.optionsRBLB.Dock = System.Windows.Forms.DockStyle.Top;
            this.optionsRBLB.FormattingEnabled = true;
            this.optionsRBLB.Items.AddRange(new object[] {
            "Benar",
            "Salah"});
            this.optionsRBLB.Location = new System.Drawing.Point(0, 0);
            this.optionsRBLB.MultiColumn = true;
            this.optionsRBLB.Name = "optionsRBLB";
            this.optionsRBLB.Size = new System.Drawing.Size(279, 15);
            this.optionsRBLB.TabIndex = 0;
            // 
            // TrueOrFalseAnswerBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.optionsRBLB);
            this.Name = "TrueOrFalseAnswerBox";
            this.Size = new System.Drawing.Size(279, 28);
            this.ResumeLayout(false);

        }

        #endregion

        private RadioButtonListBox optionsRBLB;
    }
}

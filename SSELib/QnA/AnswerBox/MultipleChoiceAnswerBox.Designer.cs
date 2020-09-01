namespace SSELib.QnA.AnswerBox
{
    partial class MultipleChoiceAnswerBox
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
            this.optionsRBLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsRBLB.FormattingEnabled = true;
            this.optionsRBLB.Location = new System.Drawing.Point(0, 0);
            this.optionsRBLB.Name = "optionsRBLB";
            this.optionsRBLB.Size = new System.Drawing.Size(284, 216);
            this.optionsRBLB.TabIndex = 0;
            // 
            // MultipleChoiceAnswerBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.optionsRBLB);
            this.Name = "MultipleChoiceAnswerBox";
            this.Size = new System.Drawing.Size(284, 216);
            this.ResumeLayout(false);

        }

        #endregion

        private RadioButtonListBox optionsRBLB;
    }
}

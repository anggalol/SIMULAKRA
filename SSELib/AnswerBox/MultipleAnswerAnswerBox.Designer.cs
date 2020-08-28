namespace SSELib.AnswerBox
{
    partial class MultipleAnswerAnswerBox
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
            this.optionsCLB = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // optionsCLB
            // 
            this.optionsCLB.CheckOnClick = true;
            this.optionsCLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsCLB.FormattingEnabled = true;
            this.optionsCLB.Location = new System.Drawing.Point(0, 0);
            this.optionsCLB.Name = "optionsCLB";
            this.optionsCLB.Size = new System.Drawing.Size(343, 250);
            this.optionsCLB.TabIndex = 0;
            // 
            // MultipleAnswerAnswerBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.optionsCLB);
            this.Name = "MultipleAnswerAnswerBox";
            this.Size = new System.Drawing.Size(343, 250);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox optionsCLB;
    }
}

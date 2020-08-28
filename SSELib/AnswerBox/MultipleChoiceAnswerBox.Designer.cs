namespace SSELib.AnswerBox
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
            this.optionsRBL = new SSELib.AnswerBox.RadioButtonList();
            this.SuspendLayout();
            // 
            // optionsRBL
            // 
            this.optionsRBL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsRBL.FormattingEnabled = true;
            this.optionsRBL.Location = new System.Drawing.Point(0, 0);
            this.optionsRBL.Name = "optionsRBL";
            this.optionsRBL.Size = new System.Drawing.Size(355, 250);
            this.optionsRBL.TabIndex = 0;
            // 
            // MultipleChoiceAnswerBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.optionsRBL);
            this.Name = "MultipleChoiceAnswerBox";
            this.Size = new System.Drawing.Size(355, 250);
            this.ResumeLayout(false);

        }

        #endregion

        private RadioButtonList optionsRBL;
    }
}

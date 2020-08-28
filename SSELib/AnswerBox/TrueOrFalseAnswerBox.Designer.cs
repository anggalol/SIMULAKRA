namespace SSELib.AnswerBox
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
            this.optionsRBL = new SSELib.AnswerBox.RadioButtonList();
            this.SuspendLayout();
            // 
            // optionsRBL
            // 
            this.optionsRBL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.optionsRBL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsRBL.FormattingEnabled = true;
            this.optionsRBL.Location = new System.Drawing.Point(0, 0);
            this.optionsRBL.MultiColumn = true;
            this.optionsRBL.Name = "optionsRBL";
            this.optionsRBL.Size = new System.Drawing.Size(394, 166);
            this.optionsRBL.TabIndex = 0;
            // 
            // TrueOrFalseAnswerBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.optionsRBL);
            this.Name = "TrueOrFalseAnswerBox";
            this.Size = new System.Drawing.Size(394, 166);
            this.ResumeLayout(false);

        }

        #endregion

        private RadioButtonList optionsRBL;
    }
}

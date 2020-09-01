namespace SSELib.QnA.AnswerBox
{
    partial class CausalityAnswerBox
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
            this.statementMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.causeMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.reasonMetroLabel = new MetroFramework.Controls.MetroLabel();
            this.statementOptionsRBLB = new SSELib.QnA.AnswerBox.RadioButtonListBox();
            this.causeOptionsRBLB = new SSELib.QnA.AnswerBox.RadioButtonListBox();
            this.reasonOptionsRBLB = new SSELib.QnA.AnswerBox.RadioButtonListBox();
            this.SuspendLayout();
            // 
            // statementMetroLabel
            // 
            this.statementMetroLabel.AutoSize = true;
            this.statementMetroLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.statementMetroLabel.Location = new System.Drawing.Point(9, 3);
            this.statementMetroLabel.Name = "statementMetroLabel";
            this.statementMetroLabel.Size = new System.Drawing.Size(123, 25);
            this.statementMetroLabel.TabIndex = 0;
            this.statementMetroLabel.Text = "[PERNYATAAN]";
            // 
            // causeMetroLabel
            // 
            this.causeMetroLabel.AutoSize = true;
            this.causeMetroLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.causeMetroLabel.Location = new System.Drawing.Point(40, 52);
            this.causeMetroLabel.Name = "causeMetroLabel";
            this.causeMetroLabel.Size = new System.Drawing.Size(61, 25);
            this.causeMetroLabel.TabIndex = 1;
            this.causeMetroLabel.Text = "SEBAB";
            // 
            // reasonMetroLabel
            // 
            this.reasonMetroLabel.AutoSize = true;
            this.reasonMetroLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.reasonMetroLabel.Location = new System.Drawing.Point(27, 101);
            this.reasonMetroLabel.Name = "reasonMetroLabel";
            this.reasonMetroLabel.Size = new System.Drawing.Size(86, 25);
            this.reasonMetroLabel.TabIndex = 2;
            this.reasonMetroLabel.Text = "[ALASAN]";
            // 
            // statementOptionsRBLB
            // 
            this.statementOptionsRBLB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statementOptionsRBLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statementOptionsRBLB.FormattingEnabled = true;
            this.statementOptionsRBLB.Location = new System.Drawing.Point(162, 3);
            this.statementOptionsRBLB.MultiColumn = true;
            this.statementOptionsRBLB.Name = "statementOptionsRBLB";
            this.statementOptionsRBLB.Size = new System.Drawing.Size(278, 28);
            this.statementOptionsRBLB.TabIndex = 3;
            // 
            // causeOptionsRBLB
            // 
            this.causeOptionsRBLB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.causeOptionsRBLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.causeOptionsRBLB.FormattingEnabled = true;
            this.causeOptionsRBLB.Location = new System.Drawing.Point(162, 52);
            this.causeOptionsRBLB.MultiColumn = true;
            this.causeOptionsRBLB.Name = "causeOptionsRBLB";
            this.causeOptionsRBLB.Size = new System.Drawing.Size(278, 28);
            this.causeOptionsRBLB.TabIndex = 4;
            // 
            // reasonOptionsRBLB
            // 
            this.reasonOptionsRBLB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reasonOptionsRBLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reasonOptionsRBLB.FormattingEnabled = true;
            this.reasonOptionsRBLB.Location = new System.Drawing.Point(162, 101);
            this.reasonOptionsRBLB.MultiColumn = true;
            this.reasonOptionsRBLB.Name = "reasonOptionsRBLB";
            this.reasonOptionsRBLB.Size = new System.Drawing.Size(278, 28);
            this.reasonOptionsRBLB.TabIndex = 5;
            // 
            // CausalityAnswerBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.reasonOptionsRBLB);
            this.Controls.Add(this.causeOptionsRBLB);
            this.Controls.Add(this.statementOptionsRBLB);
            this.Controls.Add(this.reasonMetroLabel);
            this.Controls.Add(this.causeMetroLabel);
            this.Controls.Add(this.statementMetroLabel);
            this.Name = "CausalityAnswerBox";
            this.Size = new System.Drawing.Size(449, 160);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel statementMetroLabel;
        private MetroFramework.Controls.MetroLabel causeMetroLabel;
        private MetroFramework.Controls.MetroLabel reasonMetroLabel;
        private RadioButtonListBox statementOptionsRBLB;
        private RadioButtonListBox causeOptionsRBLB;
        private RadioButtonListBox reasonOptionsRBLB;
    }
}

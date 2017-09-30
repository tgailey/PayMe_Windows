namespace SigningIn_DatabaseV2
{
    partial class Researcher_SurveySmallButton
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
            this.CurrentResultsLabel = new System.Windows.Forms.Label();
            this.SampleSizeLabel = new System.Windows.Forms.Label();
            this.SurveyNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CurrentResultsLabel
            // 
            this.CurrentResultsLabel.AutoSize = true;
            this.CurrentResultsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CurrentResultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentResultsLabel.Location = new System.Drawing.Point(150, 34);
            this.CurrentResultsLabel.Name = "CurrentResultsLabel";
            this.CurrentResultsLabel.Size = new System.Drawing.Size(87, 16);
            this.CurrentResultsLabel.TabIndex = 5;
            this.CurrentResultsLabel.Text = "AmountLabel";
            this.CurrentResultsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SampleSizeLabel
            // 
            this.SampleSizeLabel.AutoSize = true;
            this.SampleSizeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SampleSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SampleSizeLabel.Location = new System.Drawing.Point(149, 11);
            this.SampleSizeLabel.Name = "SampleSizeLabel";
            this.SampleSizeLabel.Size = new System.Drawing.Size(90, 16);
            this.SampleSizeLabel.TabIndex = 4;
            this.SampleSizeLabel.Text = "NumberLabel";
            this.SampleSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SurveyNameLabel
            // 
            this.SurveyNameLabel.AutoSize = true;
            this.SurveyNameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SurveyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurveyNameLabel.Location = new System.Drawing.Point(16, 17);
            this.SurveyNameLabel.Name = "SurveyNameLabel";
            this.SurveyNameLabel.Size = new System.Drawing.Size(99, 20);
            this.SurveyNameLabel.TabIndex = 3;
            this.SurveyNameLabel.Text = "SurveyName";
            this.SurveyNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Researcher_SurveySmallButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.CurrentResultsLabel);
            this.Controls.Add(this.SampleSizeLabel);
            this.Controls.Add(this.SurveyNameLabel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.Name = "Researcher_SurveySmallButton";
            this.Size = new System.Drawing.Size(255, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CurrentResultsLabel;
        private System.Windows.Forms.Label SampleSizeLabel;
        private System.Windows.Forms.Label SurveyNameLabel;
    }
}

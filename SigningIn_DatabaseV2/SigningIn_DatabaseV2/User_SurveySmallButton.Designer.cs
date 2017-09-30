namespace SigningIn_DatabaseV2
{
    partial class User_SurveySmallButton
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
            this.SurveyNameLabel = new System.Windows.Forms.Label();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SurveyNameLabel
            // 
            this.SurveyNameLabel.AutoSize = true;
            this.SurveyNameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SurveyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurveyNameLabel.Location = new System.Drawing.Point(3, 16);
            this.SurveyNameLabel.Name = "SurveyNameLabel";
            this.SurveyNameLabel.Size = new System.Drawing.Size(99, 20);
            this.SurveyNameLabel.TabIndex = 0;
            this.SurveyNameLabel.Text = "SurveyName";
            this.SurveyNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberLabel.Location = new System.Drawing.Point(136, 10);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(90, 16);
            this.NumberLabel.TabIndex = 1;
            this.NumberLabel.Text = "NumberLabel";
            this.NumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLabel.Location = new System.Drawing.Point(137, 33);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(87, 16);
            this.AmountLabel.TabIndex = 2;
            this.AmountLabel.Text = "AmountLabel";
            this.AmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // User_SurveySmallButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.SurveyNameLabel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.Name = "User_SurveySmallButton";
            this.Size = new System.Drawing.Size(255, 60);
            this.Click += new System.EventHandler(this.User_SurveySmallButton_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SurveyNameLabel;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.Label AmountLabel;
    }
}

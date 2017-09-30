namespace SigningIn_DatabaseV2
{
    partial class Researcher_SurveyDetails
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
            this.tabPanel = new System.Windows.Forms.Panel();
            this.RefreshPageButton = new System.Windows.Forms.Button();
            this.ViewSurveysButton = new System.Windows.Forms.Button();
            this.DeleteSurveyButton = new System.Windows.Forms.Button();
            this.AmountPaidLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SampleSizeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LinkButton = new System.Windows.Forms.Button();
            this.SurveyDescriptionLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SurveyNameLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CurrentResultsLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DisplayLabel = new System.Windows.Forms.Label();
            this.tabPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPanel
            // 
            this.tabPanel.Controls.Add(this.RefreshPageButton);
            this.tabPanel.Controls.Add(this.ViewSurveysButton);
            this.tabPanel.Location = new System.Drawing.Point(6, 1);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.Size = new System.Drawing.Size(261, 57);
            this.tabPanel.TabIndex = 44;
            // 
            // RefreshPageButton
            // 
            this.RefreshPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshPageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshPageButton.Location = new System.Drawing.Point(211, 4);
            this.RefreshPageButton.Name = "RefreshPageButton";
            this.RefreshPageButton.Size = new System.Drawing.Size(50, 50);
            this.RefreshPageButton.TabIndex = 1;
            this.RefreshPageButton.Text = "Refresh\r\nPage";
            this.RefreshPageButton.UseVisualStyleBackColor = true;
            this.RefreshPageButton.Visible = false;
            // 
            // ViewSurveysButton
            // 
            this.ViewSurveysButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewSurveysButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewSurveysButton.Location = new System.Drawing.Point(21, 4);
            this.ViewSurveysButton.Name = "ViewSurveysButton";
            this.ViewSurveysButton.Size = new System.Drawing.Size(50, 50);
            this.ViewSurveysButton.TabIndex = 0;
            this.ViewSurveysButton.Text = "View\r\nSurveys";
            this.ViewSurveysButton.UseVisualStyleBackColor = true;
            this.ViewSurveysButton.Click += new System.EventHandler(this.ViewSurveysButton_Click);
            // 
            // DeleteSurveyButton
            // 
            this.DeleteSurveyButton.BackColor = System.Drawing.Color.PaleVioletRed;
            this.DeleteSurveyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteSurveyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSurveyButton.ForeColor = System.Drawing.Color.DimGray;
            this.DeleteSurveyButton.Location = new System.Drawing.Point(36, 371);
            this.DeleteSurveyButton.Name = "DeleteSurveyButton";
            this.DeleteSurveyButton.Size = new System.Drawing.Size(200, 37);
            this.DeleteSurveyButton.TabIndex = 42;
            this.DeleteSurveyButton.Text = "Delete Survey";
            this.DeleteSurveyButton.UseVisualStyleBackColor = false;
            this.DeleteSurveyButton.Click += new System.EventHandler(this.DeleteSurveyButton_Click);
            // 
            // AmountPaidLabel
            // 
            this.AmountPaidLabel.Font = new System.Drawing.Font("Bell MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountPaidLabel.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.AmountPaidLabel.Location = new System.Drawing.Point(141, 276);
            this.AmountPaidLabel.Name = "AmountPaidLabel";
            this.AmountPaidLabel.Size = new System.Drawing.Size(43, 31);
            this.AmountPaidLabel.TabIndex = 38;
            this.AmountPaidLabel.Text = "DEFAULT SURVEY NAME";
            this.AmountPaidLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DimGray;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label6.Location = new System.Drawing.Point(19, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "AMOUNT PAID ---";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SampleSizeLabel
            // 
            this.SampleSizeLabel.Font = new System.Drawing.Font("Bell MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SampleSizeLabel.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.SampleSizeLabel.Location = new System.Drawing.Point(141, 202);
            this.SampleSizeLabel.Name = "SampleSizeLabel";
            this.SampleSizeLabel.Size = new System.Drawing.Size(43, 31);
            this.SampleSizeLabel.TabIndex = 36;
            this.SampleSizeLabel.Text = "DEFAULT SURVEY NAME";
            this.SampleSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DimGray;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label4.Location = new System.Drawing.Point(19, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "SAMPLE SIZE  ---";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LinkButton
            // 
            this.LinkButton.AutoSize = true;
            this.LinkButton.BackColor = System.Drawing.Color.Transparent;
            this.LinkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LinkButton.FlatAppearance.BorderSize = 0;
            this.LinkButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.LinkButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.LinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LinkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkButton.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.LinkButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LinkButton.Location = new System.Drawing.Point(24, 305);
            this.LinkButton.Name = "LinkButton";
            this.LinkButton.Size = new System.Drawing.Size(220, 30);
            this.LinkButton.TabIndex = 34;
            this.LinkButton.Text = "Click Here To Visit To The Survey";
            this.LinkButton.UseVisualStyleBackColor = false;
            this.LinkButton.Click += new System.EventHandler(this.LinkButton_Click);
            // 
            // SurveyDescriptionLabel
            // 
            this.SurveyDescriptionLabel.Font = new System.Drawing.Font("Bell MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurveyDescriptionLabel.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.SurveyDescriptionLabel.Location = new System.Drawing.Point(3, 123);
            this.SurveyDescriptionLabel.Name = "SurveyDescriptionLabel";
            this.SurveyDescriptionLabel.Size = new System.Drawing.Size(279, 76);
            this.SurveyDescriptionLabel.TabIndex = 33;
            this.SurveyDescriptionLabel.Text = "DEFAULT SURVEY DESCRIPTION";
            this.SurveyDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label2.Location = new System.Drawing.Point(33, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 18);
            this.label2.TabIndex = 32;
            this.label2.Text = "--- SURVEY DESCRIPTION ---";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SurveyNameLabel
            // 
            this.SurveyNameLabel.Font = new System.Drawing.Font("Bell MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurveyNameLabel.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.SurveyNameLabel.Location = new System.Drawing.Point(6, 77);
            this.SurveyNameLabel.Name = "SurveyNameLabel";
            this.SurveyNameLabel.Size = new System.Drawing.Size(276, 31);
            this.SurveyNameLabel.TabIndex = 31;
            this.SurveyNameLabel.Text = "DEFAULT SURVEY NAME";
            this.SurveyNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DimGray;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label9.Location = new System.Drawing.Point(61, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 18);
            this.label9.TabIndex = 30;
            this.label9.Text = "--- SURVEY NAME ---";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentResultsLabel
            // 
            this.CurrentResultsLabel.Font = new System.Drawing.Font("Bell MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentResultsLabel.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.CurrentResultsLabel.Location = new System.Drawing.Point(184, 239);
            this.CurrentResultsLabel.Name = "CurrentResultsLabel";
            this.CurrentResultsLabel.Size = new System.Drawing.Size(43, 31);
            this.CurrentResultsLabel.TabIndex = 46;
            this.CurrentResultsLabel.Text = "DEFAULT SURVEY NAME";
            this.CurrentResultsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label3.Location = new System.Drawing.Point(19, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "CURRENT RESULTS  ---";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DisplayLabel
            // 
            this.DisplayLabel.BackColor = System.Drawing.Color.DimGray;
            this.DisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayLabel.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.DisplayLabel.Location = new System.Drawing.Point(6, 333);
            this.DisplayLabel.Name = "DisplayLabel";
            this.DisplayLabel.Size = new System.Drawing.Size(261, 35);
            this.DisplayLabel.TabIndex = 47;
            this.DisplayLabel.Text = "More info, like what population you tested and what you controlled for will be in" +
    "cluded in later versions.";
            this.DisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Researcher_SurveyDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.DisplayLabel);
            this.Controls.Add(this.CurrentResultsLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabPanel);
            this.Controls.Add(this.DeleteSurveyButton);
            this.Controls.Add(this.AmountPaidLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SampleSizeLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LinkButton);
            this.Controls.Add(this.SurveyDescriptionLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SurveyNameLabel);
            this.Controls.Add(this.label9);
            this.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.Name = "Researcher_SurveyDetails";
            this.Size = new System.Drawing.Size(285, 410);
            this.tabPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel tabPanel;
        private System.Windows.Forms.Button RefreshPageButton;
        private System.Windows.Forms.Button ViewSurveysButton;
        private System.Windows.Forms.Button DeleteSurveyButton;
        private System.Windows.Forms.Label AmountPaidLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label SampleSizeLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button LinkButton;
        private System.Windows.Forms.Label SurveyDescriptionLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SurveyNameLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label CurrentResultsLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DisplayLabel;
    }
}

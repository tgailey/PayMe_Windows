namespace SigningIn_DatabaseV2
{
    partial class Researcher_ViewSurveysControl
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
            this.CentralLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.SurveyListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CreateSurveyButton = new System.Windows.Forms.Button();
            this.CentralLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CentralLayoutPanel
            // 
            this.CentralLayoutPanel.AutoScroll = true;
            this.CentralLayoutPanel.Controls.Add(this.WelcomeLabel);
            this.CentralLayoutPanel.Controls.Add(this.SurveyListPanel);
            this.CentralLayoutPanel.Controls.Add(this.CreateSurveyButton);
            this.CentralLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.CentralLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.CentralLayoutPanel.Name = "CentralLayoutPanel";
            this.CentralLayoutPanel.Size = new System.Drawing.Size(285, 410);
            this.CentralLayoutPanel.TabIndex = 13;
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.Font = new System.Drawing.Font("Bell MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.WelcomeLabel.Location = new System.Drawing.Point(3, 0);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(279, 48);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Your Surveys";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SurveyListPanel
            // 
            this.SurveyListPanel.AutoScroll = true;
            this.SurveyListPanel.Location = new System.Drawing.Point(3, 51);
            this.SurveyListPanel.Name = "SurveyListPanel";
            this.SurveyListPanel.Size = new System.Drawing.Size(279, 293);
            this.SurveyListPanel.TabIndex = 1;
            // 
            // CreateSurveyButton
            // 
            this.CreateSurveyButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.CreateSurveyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateSurveyButton.Font = new System.Drawing.Font("Bell MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateSurveyButton.ForeColor = System.Drawing.Color.DimGray;
            this.CreateSurveyButton.Location = new System.Drawing.Point(3, 350);
            this.CreateSurveyButton.Name = "CreateSurveyButton";
            this.CreateSurveyButton.Size = new System.Drawing.Size(279, 54);
            this.CreateSurveyButton.TabIndex = 10;
            this.CreateSurveyButton.Text = "Create Survey";
            this.CreateSurveyButton.UseVisualStyleBackColor = false;
            this.CreateSurveyButton.Click += new System.EventHandler(this.CreateSurveyButton_Click);
            // 
            // Researcher_ViewSurveysControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.CentralLayoutPanel);
            this.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.Name = "Researcher_ViewSurveysControl";
            this.Size = new System.Drawing.Size(285, 410);
            this.CentralLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel CentralLayoutPanel;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.FlowLayoutPanel SurveyListPanel;
        private System.Windows.Forms.Button CreateSurveyButton;
    }
}

namespace SigningIn_DatabaseV2
{
    partial class User_ViewSurveysControl
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
            this.FullPanel = new System.Windows.Forms.Panel();
            this.tabPanel = new System.Windows.Forms.Panel();
            this.RefreshPageButton = new System.Windows.Forms.Button();
            this.AccountInfoButton = new System.Windows.Forms.Button();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.SurveyListPanel = new System.Windows.Forms.TableLayoutPanel();
            this.FullPanel.SuspendLayout();
            this.tabPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FullPanel
            // 
            this.FullPanel.AutoScroll = true;
            this.FullPanel.Controls.Add(this.SurveyListPanel);
            this.FullPanel.Controls.Add(this.tabPanel);
            this.FullPanel.Controls.Add(this.WelcomeLabel);
            this.FullPanel.Location = new System.Drawing.Point(0, 0);
            this.FullPanel.Name = "FullPanel";
            this.FullPanel.Size = new System.Drawing.Size(285, 410);
            this.FullPanel.TabIndex = 0;
            // 
            // tabPanel
            // 
            this.tabPanel.Controls.Add(this.RefreshPageButton);
            this.tabPanel.Controls.Add(this.AccountInfoButton);
            this.tabPanel.Location = new System.Drawing.Point(0, 0);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.Size = new System.Drawing.Size(261, 57);
            this.tabPanel.TabIndex = 2;
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
            // 
            // AccountInfoButton
            // 
            this.AccountInfoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AccountInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountInfoButton.Location = new System.Drawing.Point(21, 4);
            this.AccountInfoButton.Name = "AccountInfoButton";
            this.AccountInfoButton.Size = new System.Drawing.Size(50, 50);
            this.AccountInfoButton.TabIndex = 0;
            this.AccountInfoButton.Text = "Account\r\nInfo";
            this.AccountInfoButton.UseVisualStyleBackColor = true;
            this.AccountInfoButton.Click += new System.EventHandler(this.AccountInfoButton_Click);
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.Font = new System.Drawing.Font("Bell MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.WelcomeLabel.Location = new System.Drawing.Point(16, 57);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(229, 39);
            this.WelcomeLabel.TabIndex = 1;
            this.WelcomeLabel.Text = "Available Surveys";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SurveyListPanel
            // 
            this.SurveyListPanel.ColumnCount = 1;
            this.SurveyListPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SurveyListPanel.Location = new System.Drawing.Point(0, 99);
            this.SurveyListPanel.Name = "SurveyListPanel";
            this.SurveyListPanel.RowCount = 1;
            this.SurveyListPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SurveyListPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SurveyListPanel.Size = new System.Drawing.Size(258, 70);
            this.SurveyListPanel.TabIndex = 4;
            // 
            // User_ViewSurveysControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.FullPanel);
            this.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.Name = "User_ViewSurveysControl";
            this.Size = new System.Drawing.Size(285, 410);
            this.FullPanel.ResumeLayout(false);
            this.tabPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FullPanel;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Panel tabPanel;
        private System.Windows.Forms.Button RefreshPageButton;
        private System.Windows.Forms.Button AccountInfoButton;
        private System.Windows.Forms.TableLayoutPanel SurveyListPanel;
    }
}

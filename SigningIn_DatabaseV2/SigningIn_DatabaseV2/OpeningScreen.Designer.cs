namespace SigningIn_DatabaseV2
{
    partial class OpeningScreen
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.CreateAccountButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AboutMeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Bell MT", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.WelcomeLabel.Location = new System.Drawing.Point(60, 37);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(163, 53);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "PayMe";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateAccountButton
            // 
            this.CreateAccountButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.CreateAccountButton.Font = new System.Drawing.Font("Bell MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAccountButton.ForeColor = System.Drawing.Color.DimGray;
            this.CreateAccountButton.Location = new System.Drawing.Point(16, 136);
            this.CreateAccountButton.Name = "CreateAccountButton";
            this.CreateAccountButton.Size = new System.Drawing.Size(245, 54);
            this.CreateAccountButton.TabIndex = 1;
            this.CreateAccountButton.Text = "Create Account";
            this.CreateAccountButton.UseVisualStyleBackColor = false;
            this.CreateAccountButton.Click += new System.EventHandler(this.CreateAccountButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.LoginButton.Font = new System.Drawing.Font("Bell MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.DimGray;
            this.LoginButton.Location = new System.Drawing.Point(16, 284);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(245, 54);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label1.Location = new System.Drawing.Point(25, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "----- ALREADY HAVE AN ACCOUNT? ------";
            // 
            // AboutMeButton
            // 
            this.AboutMeButton.AutoSize = true;
            this.AboutMeButton.BackColor = System.Drawing.Color.Transparent;
            this.AboutMeButton.FlatAppearance.BorderSize = 0;
            this.AboutMeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.AboutMeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.AboutMeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutMeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutMeButton.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.AboutMeButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AboutMeButton.Location = new System.Drawing.Point(44, 91);
            this.AboutMeButton.Name = "AboutMeButton";
            this.AboutMeButton.Size = new System.Drawing.Size(193, 30);
            this.AboutMeButton.TabIndex = 13;
            this.AboutMeButton.Text = "WHAT IS PAYME?";
            this.AboutMeButton.UseVisualStyleBackColor = false;
            this.AboutMeButton.Click += new System.EventHandler(this.AboutMeButton_Click);
            // 
            // OpeningScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.AboutMeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.CreateAccountButton);
            this.Controls.Add(this.WelcomeLabel);
            this.Name = "OpeningScreen";
            this.Size = new System.Drawing.Size(285, 410);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button CreateAccountButton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AboutMeButton;
    }
}

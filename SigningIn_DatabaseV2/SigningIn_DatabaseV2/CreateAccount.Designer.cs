namespace SigningIn_DatabaseV2
{
    partial class CreateAccount
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
            this.InstructionLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.CreateAccountButton = new System.Windows.Forms.Button();
            this.DisplayLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ResearcherRadioButton = new System.Windows.Forms.RadioButton();
            this.UserRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // InstructionLabel
            // 
            this.InstructionLabel.AutoSize = true;
            this.InstructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionLabel.Location = new System.Drawing.Point(3, 28);
            this.InstructionLabel.Name = "InstructionLabel";
            this.InstructionLabel.Size = new System.Drawing.Size(277, 24);
            this.InstructionLabel.TabIndex = 0;
            this.InstructionLabel.Text = "Sign up with your email address";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.UsernameTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.UsernameTextBox.Location = new System.Drawing.Point(46, 85);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(190, 20);
            this.UsernameTextBox.TabIndex = 1;
            this.UsernameTextBox.Text = "Username";
            this.UsernameTextBox.TextChanged += new System.EventHandler(this.UsernameTextBox_TextChanged);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.EmailTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.EmailTextBox.Location = new System.Drawing.Point(46, 133);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(190, 20);
            this.EmailTextBox.TabIndex = 2;
            this.EmailTextBox.Text = "Email";
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ConfirmPasswordTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(47, 219);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(190, 20);
            this.ConfirmPasswordTextBox.TabIndex = 4;
            this.ConfirmPasswordTextBox.Text = "Confirm Password";
            this.ConfirmPasswordTextBox.TextChanged += new System.EventHandler(this.ConfirmPasswordTextBox_TextChanged);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.PasswordTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.PasswordTextBox.Location = new System.Drawing.Point(46, 178);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(190, 20);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.Text = "Password";
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // CreateAccountButton
            // 
            this.CreateAccountButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.CreateAccountButton.Font = new System.Drawing.Font("Bell MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAccountButton.ForeColor = System.Drawing.Color.DimGray;
            this.CreateAccountButton.Location = new System.Drawing.Point(18, 305);
            this.CreateAccountButton.Name = "CreateAccountButton";
            this.CreateAccountButton.Size = new System.Drawing.Size(245, 54);
            this.CreateAccountButton.TabIndex = 9;
            this.CreateAccountButton.Text = "Create Account";
            this.CreateAccountButton.UseVisualStyleBackColor = false;
            this.CreateAccountButton.Click += new System.EventHandler(this.CreateAccountButton_Click);
            // 
            // DisplayLabel
            // 
            this.DisplayLabel.AutoSize = true;
            this.DisplayLabel.Font = new System.Drawing.Font("Bell MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayLabel.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.DisplayLabel.Location = new System.Drawing.Point(23, 284);
            this.DisplayLabel.Name = "DisplayLabel";
            this.DisplayLabel.Size = new System.Drawing.Size(239, 15);
            this.DisplayLabel.TabIndex = 8;
            this.DisplayLabel.Text = "----- PLEASE CONFIRM YOUR EMAIL ------";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Bell MT", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.LoginLabel.Location = new System.Drawing.Point(27, 372);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(167, 19);
            this.LoginLabel.TabIndex = 10;
            this.LoginLabel.Text = "Already have an account?";
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.DimGray;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.LoginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LoginButton.Location = new System.Drawing.Point(181, 369);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(64, 23);
            this.LoginButton.TabIndex = 11;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label1.Location = new System.Drawing.Point(44, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "I AM A :";
            // 
            // ResearcherRadioButton
            // 
            this.ResearcherRadioButton.AutoSize = true;
            this.ResearcherRadioButton.Location = new System.Drawing.Point(166, 254);
            this.ResearcherRadioButton.Name = "ResearcherRadioButton";
            this.ResearcherRadioButton.Size = new System.Drawing.Size(80, 17);
            this.ResearcherRadioButton.TabIndex = 7;
            this.ResearcherRadioButton.Text = "Researcher";
            this.ResearcherRadioButton.UseVisualStyleBackColor = true;
            // 
            // UserRadioButton
            // 
            this.UserRadioButton.AutoSize = true;
            this.UserRadioButton.Checked = true;
            this.UserRadioButton.Location = new System.Drawing.Point(113, 254);
            this.UserRadioButton.Name = "UserRadioButton";
            this.UserRadioButton.Size = new System.Drawing.Size(47, 17);
            this.UserRadioButton.TabIndex = 6;
            this.UserRadioButton.TabStop = true;
            this.UserRadioButton.Text = "User";
            this.UserRadioButton.UseVisualStyleBackColor = true;
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.UserRadioButton);
            this.Controls.Add(this.ResearcherRadioButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.DisplayLabel);
            this.Controls.Add(this.CreateAccountButton);
            this.Controls.Add(this.ConfirmPasswordTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.InstructionLabel);
            this.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.Name = "CreateAccount";
            this.Size = new System.Drawing.Size(285, 410);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InstructionLabel;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox ConfirmPasswordTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button CreateAccountButton;
        private System.Windows.Forms.Label DisplayLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton ResearcherRadioButton;
        private System.Windows.Forms.RadioButton UserRadioButton;
    }
}

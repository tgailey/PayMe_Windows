namespace SigningIn_DatabaseV2
{
    partial class BasicInfoControl
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
            this.EditInfoPanel = new System.Windows.Forms.Panel();
            this.SexBox = new System.Windows.Forms.ComboBox();
            this.GenderBox = new System.Windows.Forms.ComboBox();
            this.YearBox = new System.Windows.Forms.ComboBox();
            this.DayBox = new System.Windows.Forms.ComboBox();
            this.MonthBox = new System.Windows.Forms.ComboBox();
            this.DisplayLabel = new System.Windows.Forms.Label();
            this.ConfirmEditsButton = new System.Windows.Forms.Button();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordLabelEdit = new System.Windows.Forms.Label();
            this.GenderLabelEdit = new System.Windows.Forms.Label();
            this.EmailLabelEdit = new System.Windows.Forms.Label();
            this.FirstNameLabelEdit = new System.Windows.Forms.Label();
            this.DisplayInfoPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.UserSexLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DisplayLabel2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EditInfoButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.UserGenderLabel = new System.Windows.Forms.Label();
            this.UserDOBLabel = new System.Windows.Forms.Label();
            this.UserFirstNameLabel = new System.Windows.Forms.Label();
            this.EditInfoPanel.SuspendLayout();
            this.DisplayInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditInfoPanel
            // 
            this.EditInfoPanel.BackColor = System.Drawing.Color.Transparent;
            this.EditInfoPanel.Controls.Add(this.SexBox);
            this.EditInfoPanel.Controls.Add(this.GenderBox);
            this.EditInfoPanel.Controls.Add(this.YearBox);
            this.EditInfoPanel.Controls.Add(this.DayBox);
            this.EditInfoPanel.Controls.Add(this.MonthBox);
            this.EditInfoPanel.Controls.Add(this.DisplayLabel);
            this.EditInfoPanel.Controls.Add(this.ConfirmEditsButton);
            this.EditInfoPanel.Controls.Add(this.FirstNameTextBox);
            this.EditInfoPanel.Controls.Add(this.ConfirmPasswordLabelEdit);
            this.EditInfoPanel.Controls.Add(this.GenderLabelEdit);
            this.EditInfoPanel.Controls.Add(this.EmailLabelEdit);
            this.EditInfoPanel.Controls.Add(this.FirstNameLabelEdit);
            this.EditInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.EditInfoPanel.Name = "EditInfoPanel";
            this.EditInfoPanel.Size = new System.Drawing.Size(250, 220);
            this.EditInfoPanel.TabIndex = 0;
            // 
            // SexBox
            // 
            this.SexBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SexBox.FormattingEnabled = true;
            this.SexBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other",
            "No Comment"});
            this.SexBox.Location = new System.Drawing.Point(59, 151);
            this.SexBox.Name = "SexBox";
            this.SexBox.Size = new System.Drawing.Size(121, 21);
            this.SexBox.TabIndex = 9;
            // 
            // GenderBox
            // 
            this.GenderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderBox.FormattingEnabled = true;
            this.GenderBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Non-Binary",
            "No Comment"});
            this.GenderBox.Location = new System.Drawing.Point(59, 110);
            this.GenderBox.Name = "GenderBox";
            this.GenderBox.Size = new System.Drawing.Size(121, 21);
            this.GenderBox.TabIndex = 7;
            // 
            // YearBox
            // 
            this.YearBox.DropDownHeight = 150;
            this.YearBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YearBox.FormattingEnabled = true;
            this.YearBox.IntegralHeight = false;
            this.YearBox.Items.AddRange(new object[] {
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980",
            "1979",
            "1978",
            "1977",
            "1976",
            "1975",
            "1974",
            "1973",
            "1972",
            "1971",
            "1970",
            "1969",
            "1968",
            "1967",
            "1966",
            "1965",
            "1964",
            "1963",
            "1962",
            "1961",
            "1960",
            "1959",
            "1958",
            "1957",
            "1956",
            "1955",
            "1954",
            "1953",
            "1952",
            "1951",
            "1950",
            "1949",
            "1948",
            "1947",
            "1946",
            "1945",
            "1944",
            "1943",
            "1942",
            "1941",
            "1940"});
            this.YearBox.Location = new System.Drawing.Point(173, 69);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(74, 21);
            this.YearBox.TabIndex = 5;
            // 
            // DayBox
            // 
            this.DayBox.DropDownHeight = 150;
            this.DayBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DayBox.FormattingEnabled = true;
            this.DayBox.IntegralHeight = false;
            this.DayBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.DayBox.Location = new System.Drawing.Point(111, 69);
            this.DayBox.Name = "DayBox";
            this.DayBox.Size = new System.Drawing.Size(56, 21);
            this.DayBox.TabIndex = 4;
            // 
            // MonthBox
            // 
            this.MonthBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.MonthBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.MonthBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonthBox.FormattingEnabled = true;
            this.MonthBox.IntegralHeight = false;
            this.MonthBox.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.MonthBox.Location = new System.Drawing.Point(8, 69);
            this.MonthBox.Name = "MonthBox";
            this.MonthBox.Size = new System.Drawing.Size(97, 21);
            this.MonthBox.TabIndex = 3;
            // 
            // DisplayLabel
            // 
            this.DisplayLabel.AutoSize = true;
            this.DisplayLabel.Font = new System.Drawing.Font("Bell MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayLabel.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.DisplayLabel.Location = new System.Drawing.Point(20, 175);
            this.DisplayLabel.Name = "DisplayLabel";
            this.DisplayLabel.Size = new System.Drawing.Size(213, 15);
            this.DisplayLabel.TabIndex = 10;
            this.DisplayLabel.Text = "----- Press Confirm Edits When Done -----";
            // 
            // ConfirmEditsButton
            // 
            this.ConfirmEditsButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ConfirmEditsButton.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmEditsButton.ForeColor = System.Drawing.Color.DimGray;
            this.ConfirmEditsButton.Location = new System.Drawing.Point(26, 189);
            this.ConfirmEditsButton.Name = "ConfirmEditsButton";
            this.ConfirmEditsButton.Size = new System.Drawing.Size(200, 25);
            this.ConfirmEditsButton.TabIndex = 11;
            this.ConfirmEditsButton.Text = "Confirm Edits";
            this.ConfirmEditsButton.UseVisualStyleBackColor = false;
            this.ConfirmEditsButton.Click += new System.EventHandler(this.ConfirmEditsButton_Click);
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(49, 22);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(148, 20);
            this.FirstNameTextBox.TabIndex = 1;
            // 
            // ConfirmPasswordLabelEdit
            // 
            this.ConfirmPasswordLabelEdit.AutoSize = true;
            this.ConfirmPasswordLabelEdit.Font = new System.Drawing.Font("Bell MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPasswordLabelEdit.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.ConfirmPasswordLabelEdit.Location = new System.Drawing.Point(89, 133);
            this.ConfirmPasswordLabelEdit.Name = "ConfirmPasswordLabelEdit";
            this.ConfirmPasswordLabelEdit.Size = new System.Drawing.Size(63, 15);
            this.ConfirmPasswordLabelEdit.TabIndex = 8;
            this.ConfirmPasswordLabelEdit.Text = "--- SEX ---";
            // 
            // GenderLabelEdit
            // 
            this.GenderLabelEdit.AutoSize = true;
            this.GenderLabelEdit.Font = new System.Drawing.Font("Bell MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLabelEdit.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.GenderLabelEdit.Location = new System.Drawing.Point(74, 93);
            this.GenderLabelEdit.Name = "GenderLabelEdit";
            this.GenderLabelEdit.Size = new System.Drawing.Size(94, 15);
            this.GenderLabelEdit.TabIndex = 6;
            this.GenderLabelEdit.Text = "--- GENDER ---";
            // 
            // EmailLabelEdit
            // 
            this.EmailLabelEdit.AutoSize = true;
            this.EmailLabelEdit.Font = new System.Drawing.Font("Bell MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabelEdit.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.EmailLabelEdit.Location = new System.Drawing.Point(52, 47);
            this.EmailLabelEdit.Name = "EmailLabelEdit";
            this.EmailLabelEdit.Size = new System.Drawing.Size(138, 15);
            this.EmailLabelEdit.TabIndex = 2;
            this.EmailLabelEdit.Text = "--- DATE OF BIRTH ---";
            // 
            // FirstNameLabelEdit
            // 
            this.FirstNameLabelEdit.AutoSize = true;
            this.FirstNameLabelEdit.Font = new System.Drawing.Font("Bell MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabelEdit.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.FirstNameLabelEdit.Location = new System.Drawing.Point(66, 4);
            this.FirstNameLabelEdit.Name = "FirstNameLabelEdit";
            this.FirstNameLabelEdit.Size = new System.Drawing.Size(118, 15);
            this.FirstNameLabelEdit.TabIndex = 0;
            this.FirstNameLabelEdit.Text = "--- FIRST NAME ---";
            // 
            // DisplayInfoPanel
            // 
            this.DisplayInfoPanel.BackColor = System.Drawing.Color.Transparent;
            this.DisplayInfoPanel.Controls.Add(this.label1);
            this.DisplayInfoPanel.Controls.Add(this.UserSexLabel);
            this.DisplayInfoPanel.Controls.Add(this.label2);
            this.DisplayInfoPanel.Controls.Add(this.DisplayLabel2);
            this.DisplayInfoPanel.Controls.Add(this.label3);
            this.DisplayInfoPanel.Controls.Add(this.EditInfoButton);
            this.DisplayInfoPanel.Controls.Add(this.label4);
            this.DisplayInfoPanel.Controls.Add(this.UserGenderLabel);
            this.DisplayInfoPanel.Controls.Add(this.UserDOBLabel);
            this.DisplayInfoPanel.Controls.Add(this.UserFirstNameLabel);
            this.DisplayInfoPanel.Location = new System.Drawing.Point(256, 3);
            this.DisplayInfoPanel.Name = "DisplayInfoPanel";
            this.DisplayInfoPanel.Size = new System.Drawing.Size(250, 220);
            this.DisplayInfoPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label1.Location = new System.Drawing.Point(85, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "--- SEX ---";
            // 
            // UserSexLabel
            // 
            this.UserSexLabel.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserSexLabel.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.UserSexLabel.Location = new System.Drawing.Point(84, 148);
            this.UserSexLabel.Name = "UserSexLabel";
            this.UserSexLabel.Size = new System.Drawing.Size(73, 19);
            this.UserSexLabel.TabIndex = 7;
            this.UserSexLabel.Text = "defaultSex";
            this.UserSexLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bell MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label2.Location = new System.Drawing.Point(72, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "--- GENDER ---";
            // 
            // DisplayLabel2
            // 
            this.DisplayLabel2.AutoSize = true;
            this.DisplayLabel2.Font = new System.Drawing.Font("Bell MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayLabel2.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.DisplayLabel2.Location = new System.Drawing.Point(18, 173);
            this.DisplayLabel2.Name = "DisplayLabel2";
            this.DisplayLabel2.Size = new System.Drawing.Size(212, 15);
            this.DisplayLabel2.TabIndex = 8;
            this.DisplayLabel2.Text = "----- Click Edit Info to Make Changes -----";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bell MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label3.Location = new System.Drawing.Point(50, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "--- DATE OF BIRTH ---";
            // 
            // EditInfoButton
            // 
            this.EditInfoButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.EditInfoButton.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditInfoButton.ForeColor = System.Drawing.Color.DimGray;
            this.EditInfoButton.Location = new System.Drawing.Point(25, 189);
            this.EditInfoButton.Name = "EditInfoButton";
            this.EditInfoButton.Size = new System.Drawing.Size(200, 25);
            this.EditInfoButton.TabIndex = 9;
            this.EditInfoButton.Text = "Edit Info";
            this.EditInfoButton.UseVisualStyleBackColor = false;
            this.EditInfoButton.Click += new System.EventHandler(this.EditInfoButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bell MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label4.Location = new System.Drawing.Point(64, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "--- FIRST NAME ---";
            // 
            // UserGenderLabel
            // 
            this.UserGenderLabel.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserGenderLabel.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.UserGenderLabel.Location = new System.Drawing.Point(71, 109);
            this.UserGenderLabel.Name = "UserGenderLabel";
            this.UserGenderLabel.Size = new System.Drawing.Size(97, 19);
            this.UserGenderLabel.TabIndex = 5;
            this.UserGenderLabel.Text = "defaultGender";
            this.UserGenderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserDOBLabel
            // 
            this.UserDOBLabel.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserDOBLabel.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.UserDOBLabel.Location = new System.Drawing.Point(61, 68);
            this.UserDOBLabel.Name = "UserDOBLabel";
            this.UserDOBLabel.Size = new System.Drawing.Size(127, 19);
            this.UserDOBLabel.TabIndex = 3;
            this.UserDOBLabel.Text = "defaultDateOfBirth";
            this.UserDOBLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserFirstNameLabel
            // 
            this.UserFirstNameLabel.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserFirstNameLabel.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.UserFirstNameLabel.Location = new System.Drawing.Point(64, 21);
            this.UserFirstNameLabel.Name = "UserFirstNameLabel";
            this.UserFirstNameLabel.Size = new System.Drawing.Size(118, 19);
            this.UserFirstNameLabel.TabIndex = 1;
            this.UserFirstNameLabel.Text = "defaultFirstName";
            this.UserFirstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BasicInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.DisplayInfoPanel);
            this.Controls.Add(this.EditInfoPanel);
            this.Name = "BasicInfoControl";
            this.Size = new System.Drawing.Size(250, 230);
            this.EditInfoPanel.ResumeLayout(false);
            this.EditInfoPanel.PerformLayout();
            this.DisplayInfoPanel.ResumeLayout(false);
            this.DisplayInfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel EditInfoPanel;
        private System.Windows.Forms.Label DisplayLabel;
        private System.Windows.Forms.Button ConfirmEditsButton;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label ConfirmPasswordLabelEdit;
        private System.Windows.Forms.Label GenderLabelEdit;
        private System.Windows.Forms.Label EmailLabelEdit;
        private System.Windows.Forms.Label FirstNameLabelEdit;
        private System.Windows.Forms.Panel DisplayInfoPanel;
        private System.Windows.Forms.Label DisplayLabel2;
        private System.Windows.Forms.Button EditInfoButton;
        private System.Windows.Forms.Label UserGenderLabel;
        private System.Windows.Forms.Label UserDOBLabel;
        private System.Windows.Forms.Label UserFirstNameLabel;
        private System.Windows.Forms.ComboBox YearBox;
        private System.Windows.Forms.ComboBox DayBox;
        private System.Windows.Forms.ComboBox MonthBox;
        private System.Windows.Forms.ComboBox SexBox;
        private System.Windows.Forms.ComboBox GenderBox;
        private System.Windows.Forms.Label UserSexLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

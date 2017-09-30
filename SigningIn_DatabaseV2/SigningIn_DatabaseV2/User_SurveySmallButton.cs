using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SigningIn_DatabaseV2
{
    public partial class User_SurveySmallButton : UserControl
    {
        string[] details;
        public User_SurveySmallButton()
        {
            InitializeComponent();
        }

        public User_SurveySmallButton(string[] details)
        {
            InitializeComponent();
            if (details.Length == 8)
            {
                this.details = details;
            }
            SurveyNameLabel.Text = details[1];
            NumberLabel.Text = "Questions: " + details[5];
            AmountLabel.Text = "Amount Paid: " + details[6];
            SurveyNameLabel.Click += new System.EventHandler(User_SurveySmallButton_Click);
            NumberLabel.Click += new System.EventHandler(User_SurveySmallButton_Click);
            AmountLabel.Click += new System.EventHandler(User_SurveySmallButton_Click);
        }

        private void User_SurveySmallButton_Click(object sender, EventArgs e)
        {
            User_SurveyDetails sd = new User_SurveyDetails(details);
            OpeningForm.switchUserControl(sd);
            //parentPanel.Controls.Add(sd);
            //sd.Location = new Point(20, 20);
            //sd.BringToFront();
        }
    }
}

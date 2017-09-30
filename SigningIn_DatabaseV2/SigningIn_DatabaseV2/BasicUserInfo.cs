using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;   // System.Data.dll 

namespace SigningIn_DatabaseV2
{
    public partial class BasicUserInfo : UserControl
    {
        public int[] stateOfSections = new int[3];
        public UserControl[] usercontrols = new UserControl[3];
        private Label[] Labels = new Label[3];
        private Button[] Buttons = new Button[3];
        /*
         * 
         * Used to display info in a way asthenically pleasing to user depending on info was given earlier or not
         * 1 - Account Info
         * 2 - Basic Info
         * 
         * */
        public BasicUserInfo()
        {
            InitializeComponent();

            #region DefaultArrays
            Labels[0] = AccountInfoLabel;
            Labels[1] = BasicInfoLabel;
            Labels[2] = PersonalityInfoLabel;

            Buttons[0] = AccountInfoShowHide;
            Buttons[1] = BasicInfoShowHide;
            Buttons[2] = PersonalityInfoShowHide;
            #endregion

            #region DefaultValuesForSections
            //a value of 0 means the form needs to be edited. A value of 1 means the form should display the info.
            try
            {

                using (var connection = new SqlConnection(OpeningForm.cb.ConnectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();


                    SqlDataReader reader;
                    //cmd.CommandText = "SELECT * FROM Users";
                    cmd.CommandText = string.Format(@"SELECT BasicInfo.FirstName, PersonalityInfo.MBTI_EI 
                                                      FROM BasicInfo
                                                      FULL OUTER JOIN  PersonalityInfo  ON  BasicInfo.UserName = PersonalityInfo.UserName
                                                      WHERE BasicInfo.UserName = '{0}' OR PersonalityInfo.UserName = '{0}';", OpeningForm._username);
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        if (reader["FirstName"].ToString().Equals(""))
                        {
                            stateOfSections[1] = 0;
                            BasicInfoPanel.Visible = true;
                            BasicInfoShowHide.Text = "Hide";
                            BasicInfoLabel.ForeColor = Color.PaleVioletRed;
                            BasicInfoShowHide.BackColor = Color.PaleVioletRed;
                        }
                        else
                        {
                            stateOfSections[1] = 1;
                            BasicInfoPanel.Visible = false;
                            BasicInfoShowHide.Text = "Show";
                        }
                        if (reader["MBTI_EI"].ToString().Equals(""))
                        {
                            stateOfSections[2] = 0;
                            PersonalityInfoPanel.Visible = true;
                            PersonalityInfoShowHide.Text = "Hide";
                            PersonalityInfoLabel.ForeColor = Color.PaleVioletRed;
                            PersonalityInfoShowHide.BackColor = Color.PaleVioletRed;
                        }
                        else
                        {
                            stateOfSections[2] = 1;
                            PersonalityInfoPanel.Visible = false;
                            PersonalityInfoShowHide.Text = "Show";
                        }
                    }
                    else
                    {
                        stateOfSections[1] = 0;
                        BasicInfoPanel.Visible = true;
                        BasicInfoShowHide.Text = "Hide";
                        BasicInfoLabel.ForeColor = Color.PaleVioletRed;
                        BasicInfoShowHide.BackColor = Color.PaleVioletRed;

                        stateOfSections[2] = 0;
                        PersonalityInfoPanel.Visible = true;
                        PersonalityInfoShowHide.Text = "Hide";
                        PersonalityInfoLabel.ForeColor = Color.PaleVioletRed;
                        PersonalityInfoShowHide.BackColor = Color.PaleVioletRed;
                    }
                    reader.Close();
                    cmd.Dispose();
                    connection.Close();
                }

            }
            catch (SqlException ex)
            {
                DisplayLabel.Text = "SQL Exception";
            }
            stateOfSections[0] = 1;
            AccountInfoPanel.Visible = false;
            #endregion
            loadForm();
        }

        public void loadForm()
        {
            usercontrols[0] = new AccountInfoControl(stateOfSections[0], this);
            AccountInfoPanel.Controls.Add(usercontrols[0]);
            usercontrols[1] = new BasicInfoControl(stateOfSections[1], this);
            BasicInfoPanel.Controls.Add(usercontrols[1]);
            usercontrols[2] = new PersonalityInfoControl(stateOfSections[2], this);
            PersonalityInfoPanel.Controls.Add(usercontrols[2]);
        }
        public void changeColors(int i)
        {
            if (stateOfSections[i] == 1) {
                Labels[i].ForeColor = Color.MediumAquamarine;
                Buttons[i].BackColor = Color.MediumAquamarine;
            }

        }
        private void AccountInfoShowHide_Click(object sender, EventArgs e)
        {
            if (AccountInfoPanel.Visible == false)
            {
                AccountInfoPanel.Visible = true;
                AccountInfoShowHide.Text = "Hide";
            }
            else
            {
                AccountInfoPanel.Visible = false;
                AccountInfoShowHide.Text = "Show";
            }
        }

        private void BasicInfoShowHide_Click(object sender, EventArgs e)
        {
            if (BasicInfoPanel.Visible == false)
            {
                BasicInfoPanel.Visible = true;
                BasicInfoShowHide.Text = "Hide";
            }
            else
            {
                BasicInfoPanel.Visible = false;
                BasicInfoShowHide.Text = "Show";
            }
        }

        private void PersonalityInfoShowHide_Click(object sender, EventArgs e)
        {
            if (PersonalityInfoPanel.Visible == false)
            {
                PersonalityInfoPanel.Visible = true;
                PersonalityInfoShowHide.Text = "Hide";
            }
            else
            {
                PersonalityInfoPanel.Visible = false;
                PersonalityInfoShowHide.Text = "Show";
            }
        }

        private void ViewSurveysButton_Click(object sender, EventArgs e)
        {
            User_ViewSurveysControl vsc = new User_ViewSurveysControl();
            OpeningForm.switchUserControl(vsc);
        }
    }
}

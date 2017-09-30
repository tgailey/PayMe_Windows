using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;   // System.Data.dll 


namespace SigningIn_DatabaseV2
{

    public partial class User_SurveyDetails : UserControl
    {
        string[] details;
        public User_SurveyDetails(string[] details)
        {
            InitializeComponent();
            this.details = details;
            SurveyNameLabel.Text = details[1];
            SurveyDescriptionLabel.Text = details[2];
            NumberOfQuestionsLabel.Text = details[5];
            AmountPaidLabel.Text = details[6];

        }

        private void LinkButton_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo(details[3]);
            Process.Start(sInfo);
        }

        private void CompleteSurveyButton_Click(object sender, EventArgs e)
        {
            if (SurveyConfirmationTextBox.Text.Equals(details[4]))
            {
                //DisplayLabel.Text = "Confirmation Key Correct";
                try
                {
                    using (var connection = new SqlConnection(OpeningForm.cb.ConnectionString))
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = string.Format("update users set availablesurveys = substring(availablesurveys, 1, CHARINDEX('{1}', availablesurveys) - 1) + " +
                                                            "substring(availablesurveys, CHARINDEX('{1}', availablesurveys) + 2, LEN(availablesurveys) - CHARINDEX('{1}', availablesurveys) + 2)\n" +
                                                            "where username = '{0}';", OpeningForm._username, details[0] + "/");
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = connection;
                        cmd.ExecuteNonQuery();

                        cmd.CommandText = string.Format("Update surveys set submittedusers = submittedusers + '{0}/', currentresults = currentresults + 1 where surveyid = '{1}'", OpeningForm._username, details[0]);
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = connection;
                        cmd.ExecuteNonQuery();
                        connection.Close();

                        OpeningForm.updateSurveys(details[0], details[7]);

                        User_ViewSurveysControl vsc = new User_ViewSurveysControl();
                        OpeningForm.switchUserControl(vsc);
                    }
                }
                catch (SqlException ex)
                {
                    DisplayLabel.Text = "SQLError " + ex.Message;
                }
            }
            else
            {
                DisplayLabel.Text = "Confirmation Key Not Correct";
            }
        }

        private void ViewSurveysButton_Click(object sender, EventArgs e)
        {
            User_ViewSurveysControl vsc = new User_ViewSurveysControl();
            OpeningForm.switchUserControl(vsc);
        }
    }
}

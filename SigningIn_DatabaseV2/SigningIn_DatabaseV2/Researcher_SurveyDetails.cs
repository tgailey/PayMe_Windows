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
    public partial class Researcher_SurveyDetails : UserControl
    {
        string[] details;
        public Researcher_SurveyDetails(string[] details)
        {
            InitializeComponent();
            this.details = details;

            SurveyNameLabel.Text = details[1];
            SurveyDescriptionLabel.Text = details[2];
            SampleSizeLabel.Text = details[5];
            CurrentResultsLabel.Text = details[6];
            AmountPaidLabel.Text = details[7];
        }

        private void LinkButton_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo(details[3]);
            Process.Start(sInfo);
        }

        private void DeleteSurveyButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new SqlConnection(OpeningForm.cb.ConnectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;
                    cmd.CommandText = string.Format("update users set availablesurveys = substring(availablesurveys, 1, CHARINDEX('{0}', availablesurveys) - 1) + substring(availablesurveys, CHARINDEX('{0}', availablesurveys) + 2, LEN(availablesurveys) - CHARINDEX('{0}', availablesurveys) + 2) where charindex('{0}', availablesurveys) > 0", details[0] + "/");
                    cmd.ExecuteNonQuery();

                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;
                    cmd.CommandText = string.Format("delete from surveys where surveyid = '{0}'", details[0]);
                    cmd.ExecuteNonQuery();

                    connection.Close();
                }

            }
            catch (SqlException ex)
            {

            }

            Researcher_ViewSurveysControl vsc = new Researcher_ViewSurveysControl();
            OpeningForm.switchUserControl(vsc);
        }

        private void ViewSurveysButton_Click(object sender, EventArgs e)
        {
            Researcher_ViewSurveysControl vsc = new Researcher_ViewSurveysControl();
            OpeningForm.switchUserControl(vsc);
        }
    }
}

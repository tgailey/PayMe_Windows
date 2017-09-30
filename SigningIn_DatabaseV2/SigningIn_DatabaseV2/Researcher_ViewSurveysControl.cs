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
    public partial class Researcher_ViewSurveysControl : UserControl
    {
        public Researcher_ViewSurveysControl()
        {
            InitializeComponent();

            try
            {

                using (var connection = new SqlConnection(OpeningForm.cb.ConnectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();


                    SqlDataReader reader;
                    //cmd.CommandText = "SELECT * FROM Users";
                    cmd.CommandText = string.Format(@"SELECT * FROM surveys
                                                      WHERE UserName = '{0}';", OpeningForm._username);
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;

                    reader = cmd.ExecuteReader();
                    
                    while (reader.Read())
                    {
                        string[] surveyInfo = new string[9];
                        surveyInfo[0] = reader["SurveyID"].ToString();
                        surveyInfo[1] = reader["SurveyName"].ToString();
                        surveyInfo[2] = reader["SurveyDescription"].ToString();
                        surveyInfo[3] = reader["SurveyLink"].ToString();
                        surveyInfo[4] = reader["ConfirmationString"].ToString();
                        surveyInfo[5] = reader["SampleSize"].ToString();
                        surveyInfo[6] = reader["CurrentResults"].ToString();
                        surveyInfo[7] = reader["AmountPaid"].ToString();
                        surveyInfo[8] = reader["Controls"].ToString();

                        Researcher_SurveySmallButton rssb = new Researcher_SurveySmallButton(surveyInfo);
                        SurveyListPanel.Controls.Add(rssb);
                    }

                    connection.Close();
                }
            }
            catch (SqlException ex)
            {
                WelcomeLabel.Text = "SQL Error Refresh";
            }


        }

        private void CreateSurveyButton_Click(object sender, EventArgs e)
        {
            CreateSurveyControl csc = new CreateSurveyControl();
            OpeningForm.switchUserControl(csc);
        }
    }
}

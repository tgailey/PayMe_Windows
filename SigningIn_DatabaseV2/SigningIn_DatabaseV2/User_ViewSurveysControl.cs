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
    public partial class User_ViewSurveysControl : UserControl
    {
        string[,] surveyInfo;
        Button b;
        public User_ViewSurveysControl()
        {
            InitializeComponent();
            SurveyListPanel.AutoSize = true;
            SurveyListPanel.RowStyles.Clear();
            if (OpeningForm._changesMade == 0)
            {
                if (OpeningForm._surveys != null && OpeningForm._surveys.Length > 0)
                {
                    RefreshSurveys();
                }
                else
                {
                    //Testing
                    WelcomeLabel.Text = "0 Surveys";
                }
            }
            else
            {
                b = new Button();
                b.Click += new System.EventHandler(this.CalculateSurveys);
                b.Size = new Size(255, 60);
                b.Text = "You have changed your information, press to recalculate surveys";
                b.BackColor = Color.LightGray;
                SurveyListPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(SizeType.AutoSize));
                SurveyListPanel.Controls.Add(b);
            }
        }
        private void CalculateSurveys(object sender, EventArgs e)
        {
            try
            {

                using (var connection = new SqlConnection(OpeningForm.cb.ConnectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();


                    SqlDataReader reader;
                    cmd.CommandText = "update users set availablesurveys = '/' where username = '" + OpeningForm._username + "'";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = string.Format("Select surveyid, wstatement from surveys where charindex('{0}', submittedusers) = 0", OpeningForm._username + "/");
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;
                    reader = cmd.ExecuteReader();

                    LinkedList<string> totalStrings = new LinkedList<string>();
                    while (reader.Read())
                    {
                        string wstatement = reader["WStatement"].ToString().Replace('|', '\'');
                        string totalCommand = string.Format(@"UPDATE Users SET  Users.AvailableSurveys = Users.AvailableSurveys + '{0}/' 
                                                            FROM Users
                                                            " + "full outer join basicinfo on basicinfo.username = users.username " + "full outer join personalityinfo on personalityinfo.username = users.username " + "WHERE users.Username = '{1}' AND " + wstatement, reader["SurveyID"].ToString(), OpeningForm._username);
                        totalCommand = totalCommand.Substring(0, totalCommand.Length - 4);
                        totalCommand += ";";
                        totalStrings.AddLast(totalCommand);

                    }

                    reader.Close();
                    LinkedListNode<string> headNode = totalStrings.First;
                    while (headNode != null)
                    {
                        cmd.CommandText = headNode.Value;
                        cmd.ExecuteNonQuery();
                        headNode = headNode.Next;
                    }
                    OpeningForm._changesMade = 0;
                    cmd.CommandText = "update users set changesmade = 0 where username = '" + OpeningForm._username + "'";
                    cmd.ExecuteNonQuery();
                    b.Dispose();
                    RefreshSurveys();

                }
            }
            catch (SqlException ex)
            {
               WelcomeLabel.Text = "sqle" + ex.Message;
            }
        }
        public void RefreshSurveys()
        {
            SurveyListPanel.RowStyles.Clear();
            try
            {

                using (var connection = new SqlConnection(OpeningForm.cb.ConnectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();


                    SqlDataReader reader;
                    //cmd.CommandText = "SELECT * FROM Users";
                    cmd.CommandText = string.Format(@"SELECT * FROM Users
                                                      WHERE UserName = '{0}';", OpeningForm._username);
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;

                    reader = cmd.ExecuteReader();
                    reader.Read();
                    
                    OpeningForm.addSurveys(reader["AvailableSurveys"].ToString().Split('/'));

                    connection.Close();
                }
            }
            catch (SqlException ex)
            {
                WelcomeLabel.Text = "SQL Error Refresh";
            }
            if (OpeningForm._surveys != null && OpeningForm._surveys.Length > 0)
            {
                OpenSurveys();
            }
            else
            {
                WelcomeLabel.Text = "NO SURVEYS AVAILABLE, CHECK BACK LATER";
            }
        }
        public void OpenSurveys()
        {
            int j = 0;
            surveyInfo = new string[OpeningForm._surveys.Length, 8];

            try
            {

                using (var connection = new SqlConnection(OpeningForm.cb.ConnectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    string where = "WHERE ";
                    for (int i = 0; i < OpeningForm._surveys.Length; i++)
                    {
                        where += "SurveyID = " + OpeningForm._surveys[i].ToString() + " OR ";
                    }
                    where = where.Substring(0, where.Length - 3);
                    where += ";";

                    cmd.CommandText = "SELECT * FROM Surveys " + where;
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;

                    SqlDataReader reader;
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        surveyInfo[j, 0] = reader["SurveyID"].ToString();
                        surveyInfo[j, 1] = reader["SurveyName"].ToString();
                        surveyInfo[j, 2] = reader["SurveyDescription"].ToString();
                        surveyInfo[j, 3] = reader["SurveyLink"].ToString();
                        surveyInfo[j, 4] = reader["ConfirmationString"].ToString();
                        surveyInfo[j, 5] = reader["NumberOfQuestions"].ToString();
                        surveyInfo[j, 6] = reader["AmountPaid"].ToString();
                        surveyInfo[j, 7] = reader["Controls"].ToString();
                        j++;
                    }
                    connection.Close();
                }

            }
            catch (SqlException ex)
            {
                WelcomeLabel.Text = "SQL Error Open Surveys";
            }

            for (int i = 0; i < j; i++)
            {
                string[] oneDim = new string[8];
                for (int k = 0; k < 8; k++)
                {
                    oneDim[k] = surveyInfo[i, k];
                }
                SurveyListPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(SizeType.AutoSize));
                User_SurveySmallButton ssb = new User_SurveySmallButton(oneDim);
                SurveyListPanel.Controls.Add(ssb);
            }
        }

        private void AccountInfoButton_Click(object sender, EventArgs e)
        {
            BasicUserInfo bui = new BasicUserInfo();
            OpeningForm.switchUserControl(bui);
        }
    }
}

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
    public partial class CreateSurveyControl : UserControl
    {

        public CreateSurveyControl()
        {
            InitializeComponent();
        }

        private void ClearInfoButton_Click(object sender, EventArgs e)
        {
            FirstNameTextBox.Text = "";
            MonthBox.SelectedIndex = -1;
            DayBox.SelectedIndex = -1;
            YearBox.SelectedIndex = -1;
            GenderBox.SelectedIndex = -1;
            SexBox.SelectedIndex = -1;
            MBTIBox.SelectedIndex = -1;
            OTE_Operator.SelectedIndex = -1;
            OTE_Value.SelectedIndex = -1;
            C_Operator.SelectedIndex = -1;
            C_Value.SelectedIndex = -1;
            E_Operator.SelectedIndex = -1;
            E_Value.SelectedIndex = -1;
            A_Operator.SelectedIndex = -1;
            A_Value.SelectedIndex = -1;
            N_Operator.SelectedIndex = -1;
            N_Value.SelectedIndex = -1;
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            int numquestions = 0;
            int amountpaid = 0;
            int samplesize = 0;
            if (!int.TryParse(SampleSizeTextBox.Text.ToString(), out samplesize))
            {
                DisplayLabel.Text = "Must input an integer in 'Sample Size' Text Box";
                return;
            }
            else if (!int.TryParse(NumberOfQuestionsTextBox.Text.ToString(), out numquestions))
            {
                DisplayLabel.Text = "Must input an integer in 'Number of Questions' Text Box";
                return;
            }
            else if (!int.TryParse(AmountPaidTextBox.Text.ToString(), out amountpaid))
            {
                DisplayLabel.Text = "Must input an integer in 'Amount Paid' Text Box";
                return;
            }
            else if (SurveyDescriptionTextBox.Text.Length > 360)
            {
                DisplayLabel.Text = "Survey Description Too Long";
                return;
            }
            else if (SurveyNameTextBox.Text.Length > 100)
            {
                DisplayLabel.Text = "Survey Name Too Long";
                return;
            }
            else if (SurveyLinkTextBox.Text.Length > 120)
            {
                DisplayLabel.Text = "Survey Link Too Long, try using a link shortener.";
                return;
            }
            else if (SurveyConfirmationTextBox.Text.Length > 64)
            {
                DisplayLabel.Text = "Confirmation String Too Long";
                return;
            }
            else if (OTE_Value.SelectedIndex != -1 && OTE_Operator.SelectedIndex == -1)
            {
                DisplayLabel.Text = "Choose an operator for Openness to Experience";
                return;
            }
            else if (C_Value.SelectedIndex != -1 && C_Operator.SelectedIndex == -1)
            {
                DisplayLabel.Text = "Choose an operator for conscientiousness";
                return;
            }
            else if (E_Value.SelectedIndex != -1 && E_Operator.SelectedIndex == -1)
            {
                DisplayLabel.Text = "Choose an operator for Extroversion";
                return;
            }
            else if (A_Value.SelectedIndex != -1 && A_Operator.SelectedIndex == -1)
            {
                DisplayLabel.Text = "Choose an operator for Agreeableness";
                return;
            }
            else if (N_Value.SelectedIndex != -1 && N_Operator.SelectedIndex == -1)
            {
                DisplayLabel.Text = "Choose an operator for neuroticism";
                return;
            }
            else if (!(MonthBox.SelectedIndex == -1 && DayBox.SelectedIndex == -1 && YearBox.SelectedIndex == -1) && !(!(MonthBox.SelectedIndex == -1) && !(DayBox.SelectedIndex == -1) && !(YearBox.SelectedIndex == -1)))
            {
                DisplayLabel.Text = "weird value for date, make changes";
                return;
            }
            try
            {

                using (var connection = new SqlConnection(OpeningForm.cb.ConnectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    int[] controls = new int[4];
                    if (ControlAge.Checked)
                    {
                        controls[0] = 1;
                    }
                    if (ControlGender.Checked)
                    {
                        controls[1] = 1;
                    }
                    if (ControlSex.Checked)
                    {
                        controls[2] = 1;
                    }
                    if (ControlMBTI.Checked)
                    {
                        controls[3] = 1;
                    }
                    string control = controls[0].ToString() + "/" + controls[1].ToString() + "/" + controls[2].ToString() + "/" + controls[3].ToString();
                    cmd.CommandText = string.Format(@"INSERT INTO Surveys 
                                            (UserName, SurveyName, SurveyDescription, SurveyLink, ConfirmationString, SampleSize, CurrentResults, NumberOfQuestions, AmountPaid, Controls)
                                               VALUES
                                                 ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', 0, '{6}', '{7}', '{8}');", 
                                                 OpeningForm._username, SurveyNameTextBox.Text, SurveyDescriptionTextBox.Text, SurveyLinkTextBox.Text, 
                                                 SurveyConfirmationTextBox.Text, samplesize, numquestions, amountpaid, control);
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;
                    cmd.ExecuteNonQuery();

                    SqlDataReader reader;
                    //cmd.CommandText = "SELECT * FROM Users";
                    cmd.CommandText = string.Format(@"SELECT SurveyID FROM Surveys
                                                      WHERE UserName = '{0}'
                                                      ORDER BY SurveyID DESC;", OpeningForm._username);
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    int surveyid = int.Parse(reader["SurveyID"].ToString());
                    reader.Close();

                    #region DeterminingParameters
                    string fullouterBasic = "";
                    string fullouterPersonality = "";
                  //  string where = "";
                    string firstNameParameter;
                    string dateParameter;
                    string genderParameter;
                    string sexParameter;
                    string mbtiParamter;
                    string oteParameter;
                    string cParameter;
                    string eParameter;
                    string aParameter;
                    string nParameter;

                    if (FirstNameTextBox.Text.Equals(""))
                    {
                        firstNameParameter = "";
                    }
                    else
                    {
                        fullouterBasic = "FULL OUTER JOIN BasicInfo ON BasicInfo.UserName = Users.UserName\n";
                   //     where = "WHERE ";
                        firstNameParameter = "BasicInfo.FirstName = '" + FirstNameTextBox.Text + "' AND ";
                    }
                    if (MonthBox.SelectedIndex == -1)
                    {
                        dateParameter = "";
                    }
                    else
                    {
                        fullouterBasic = "FULL OUTER JOIN BasicInfo ON BasicInfo.UserName = Users.UserName\n";
                  //      where = "WHERE ";
                        dateParameter = "BasicInfo.DateOfBirth = '" + (MonthBox.SelectedIndex + 1).ToString() + "/" + DayBox.SelectedItem.ToString() + "/" + YearBox.SelectedItem.ToString() + "' AND ";
                    }
                    if (GenderBox.SelectedIndex == -1)
                    {
                        genderParameter = "";
                    }
                    else
                    {
                        fullouterBasic = "FULL OUTER JOIN BasicInfo ON BasicInfo.UserName = Users.UserName\n";
                     //   where = "WHERE ";
                        genderParameter = "BasicInfo.Gender = '" + GenderBox.SelectedItem.ToString() + "' AND ";
                    }
                    if (SexBox.SelectedIndex == -1)
                    {
                        sexParameter = "";
                    }
                    else
                    {
                        fullouterBasic = "FULL OUTER JOIN BasicInfo ON BasicInfo.UserName = Users.UserName\n";
                        //where = "WHERE ";
                        sexParameter = "BasicInfo.Sex = '" + SexBox.SelectedItem.ToString() + "' AND ";
                    }
                    if (MBTIBox.SelectedIndex == -1)
                    {
                        mbtiParamter = "";
                    }
                    else
                    {
                        fullouterPersonality = "FULL OUTER JOIN PersonalityInfo ON PersonalityInfo.UserName = Users.UserName\n";
                       // where = "WHERE ";
                        string operator1;
                        string operator2;
                        string operator3;
                        string operator4;
                        string mbtitype = MBTIBox.SelectedItem.ToString();
                        #region decideOperators
                        if (mbtitype[0] == 'I')
                        {
                            operator1 = "> 50";
                        }
                        else
                        {
                            operator1 = "<= 50";
                        }
                        if (mbtitype[1] == 'S')
                        {
                            operator2 = "> 50";
                        }
                        else
                        {
                            operator2 = "<= 50";
                        }
                        if (mbtitype[2] == 'F')
                        {
                            operator3 = "> 50";
                        }
                        else
                        {
                            operator3 = "<= 50";
                        }
                        if (mbtitype[3] == 'P')
                        {
                            operator4 = "> 50";
                        }
                        else
                        {
                            operator4 = "<= 50";
                        }
                        #endregion
                        mbtiParamter = "PersonalityInfo.MBTI_EI " + operator1 + " AND PersonalityInfo.MBTI_NS " + operator2
                            + "PersonalityInfo.MBTI_TF " + operator3 + " AND PersonalityInfo.MBTI_JP " + operator4 + " AND ";
                    }
                    if (OTE_Value.SelectedIndex == -1)
                    {
                        oteParameter = "";
                    }
                    else
                    {
                        fullouterPersonality = "FULL OUTER JOIN PersonalityInfo ON PersonalityInfo.UserName = Users.UserName\n";
                        //where = "WHERE ";
                        int number;
                        number = 20 * (5 - OTE_Value.SelectedIndex);
                        if (OTE_Operator.SelectedItem.ToString().Equals("="))
                        {
                            oteParameter = "PersonalityInfo.BIG5_OTE > " + (number - 20) + " AND PersonalityInfo.BIG5_OTE <= " + number.ToString() + " AND ";
                        }
                        else if (OTE_Operator.SelectedItem.ToString().Equals("<"))
                        {
                            oteParameter = "PersonalityInfo.BIG5_OTE " + OTE_Operator.SelectedItem.ToString() + " " + (number - 20).ToString() + " AND ";
                        }
                        else
                        {
                            oteParameter = "PersonalityInfo.BIG5_OTE " + OTE_Operator.SelectedItem.ToString() + " " + number.ToString() + " AND ";
                        }
                    }
                    if (C_Value.SelectedIndex == -1)
                    {
                        cParameter = "";
                    }
                    else
                    {
                        fullouterPersonality = "FULL OUTER JOIN PersonalityInfo ON PersonalityInfo.UserName = Users.UserName\n";
                       // where = "WHERE ";
                        int number;
                        number = 20 * (5 - C_Value.SelectedIndex);
                        if (C_Operator.SelectedItem.ToString().Equals("="))
                        {
                            cParameter = "PersonalityInfo.BIG5_C > " + (number - 20) + " AND PersonalityInfo.BIG5_C <= " + number.ToString() + " AND ";
                        }
                        else if (C_Operator.SelectedItem.ToString().Equals("<"))
                        {
                            cParameter = "PersonalityInfo.BIG5_C " + C_Operator.SelectedItem.ToString() + " " + (number - 20).ToString() + " AND ";
                        }
                        else
                        {
                            cParameter = "PersonalityInfo.BIG5_C " + C_Operator.SelectedItem.ToString() + " " + number.ToString() + " AND ";
                        }
                    }
                    if (E_Value.SelectedIndex == -1)
                    {
                        eParameter = "";
                    }
                    else
                    {
                        fullouterPersonality = "FULL OUTER JOIN PersonalityInfo ON PersonalityInfo.UserName = Users.UserName\n";
                        //where = "WHERE ";
                        int number;
                        number = 20 * (5 - E_Value.SelectedIndex);
                        if (E_Operator.SelectedItem.ToString().Equals("="))
                        {
                            eParameter = "PersonalityInfo.BIG5_E > " + (number - 20) + " AND PersonalityInfo.BIG5_E <= " + number.ToString() + " AND ";
                        }
                        else if (E_Operator.SelectedItem.ToString().Equals("<"))
                        {
                            eParameter = "PersonalityInfo.BIG5_E " + E_Operator.SelectedItem.ToString() + " " + (number - 20).ToString() + " AND ";
                        }
                        else
                        {
                            eParameter = "PersonalityInfo.BIG5_E " + E_Operator.SelectedItem.ToString() + " " + number.ToString() + " AND ";
                        }
                    }
                    if (A_Value.SelectedIndex == -1)
                    {
                        aParameter = "";
                    }
                    else
                    {
                        fullouterPersonality = "FULL OUTER JOIN PersonalityInfo ON PersonalityInfo.UserName = Users.UserName\n";
                        //where = "WHERE ";
                        int number;
                        number = 20 * (5 - A_Value.SelectedIndex);
                        if (A_Operator.SelectedItem.ToString().Equals("="))
                        {
                            aParameter = "PersonalityInfo.BIG5_A > " + (number - 20) + " AND PersonalityInfo.BIG5_A <= " + number.ToString() + " AND ";
                        }
                        else if (A_Operator.SelectedItem.ToString().Equals("<"))
                        {
                            aParameter = "PersonalityInfo.BIG5_A " + A_Operator.SelectedItem.ToString() + " " + (number - 20).ToString() + " AND ";
                        }
                        else
                        {
                            aParameter = "PersonalityInfo.BIG5_A " + A_Operator.SelectedItem.ToString() + " " + number.ToString() + " AND ";
                        }
                    }
                    if (N_Value.SelectedIndex == -1)
                    {
                        nParameter = "";
                    }
                    else
                    {
                        fullouterPersonality = "FULL OUTER JOIN PersonalityInfo ON PersonalityInfo.UserName = Users.UserName\n";
                        //where = "WHERE ";
                        int number;
                        number = 20 * (5 - N_Value.SelectedIndex);
                        if (N_Operator.SelectedItem.ToString().Equals("="))
                        {
                            nParameter = "PersonalityInfo.BIG5_N > " + (number - 20) + " AND PersonalityInfo.BIG5_N <= " + number.ToString() + " AND ";
                        }
                        else if (N_Operator.SelectedItem.ToString().Equals("<"))
                        {
                            nParameter = "PersonalityInfo.BIG5_N " + N_Operator.SelectedItem.ToString() + " " + (number - 20).ToString() + " AND ";
                        }
                        else
                        {
                            nParameter = "PersonalityInfo.BIG5_N " + N_Operator.SelectedItem.ToString() + " " + number.ToString() + " AND ";
                        }
                    }
                    #endregion
                    string totalCommand = string.Format(@"UPDATE Users SET  Users.AvailableSurveys = Users.AvailableSurveys + '/{0}' 
                                                            FROM Users
                                                            " + fullouterBasic + fullouterPersonality + "WHERE Researcher = 0 AND " + firstNameParameter + dateParameter 
                                                             + genderParameter + sexParameter + mbtiParamter + oteParameter + cParameter + eParameter + aParameter + nParameter, surveyid);
                   // if (where.Equals("WHERE "))
                  //  {
                        totalCommand = totalCommand.Substring(0, totalCommand.Length - 4);
                  //  }
                    totalCommand += ";";
                    cmd.CommandText = totalCommand;
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;
                    cmd.ExecuteNonQuery();

                    connection.Close();

                    ViewSurveysControl vsc = new ViewSurveysControl();
                    OpeningForm.switchUserControl(vsc);
                }
            }
            catch (SqlException ex)
            {
                DisplayLabel.Text = "Connection Failed. " + OpeningForm.cb.DataSource;
            }
        }
        /* Maybe Do These Checks in Create Button
private void NumberOfQuestionsTextBox_TextChanged(object sender, EventArgs e)
{
if (!int.TryParse(NumberOfQuestionsTextBox.ToString(), out numquestions))
{
DisplayLabel.Text = "Must input a number in 'Number of Questions' Text Box";
}
}

private void AmountPaidTextBox_TextChanged(object sender, EventArgs e)
{
if (!int.TryParse(AmountPaidTextBox.ToString(), out amountpaid))
{
DisplayLabel.Text = "Must input a number in 'Amount Paid' Text Box";
}
}

private void SurveyDescriptionTextBox_TextChanged(object sender, EventArgs e)
{
if (SurveyDescriptionTextBox.Text.Length > 360)
{

}
}
*/
    }
}

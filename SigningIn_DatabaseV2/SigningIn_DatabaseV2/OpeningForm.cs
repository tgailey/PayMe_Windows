using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;   // System.Data.dll 

namespace SigningIn_DatabaseV2
{
    public partial class OpeningForm : Form
    {
        public static SqlConnectionStringBuilder cb = new SqlConnectionStringBuilder();
        static UserControl currentControl;
        public static string _username = "";
        public static int _researcher = 0;
        public static string[] _surveys = new string[1];
        public static int _changesMade = 1;
        public OpeningForm()
        {
            InitializeComponent();
            cb.DataSource = "mynewtestingserver.database.windows.net";
            cb.UserID = "defaultadmin";
            cb.Password = "defaultP@ssword";
            cb.InitialCatalog = "mySampleDatabase";

            OpeningScreen os = new OpeningScreen();
            currentControl = os;
            this.BlankPanel.Controls.Add(os);
        }

        public static void switchUserControl(UserControl uc)
        {
            ((OpeningForm)ActiveForm).BlankPanel.Controls.Add(uc);
            ((OpeningForm)ActiveForm).BlankPanel.Controls.Remove(currentControl);
            currentControl.Dispose();
            currentControl = uc;
        }

        public static void  openApp()
        {
            UserControl uc;
            if (_researcher == 0)
            {
                uc = new BasicUserInfo();
            }
            else
            {
                uc = new Researcher_ViewSurveysControl();
            }
            ((OpeningForm)ActiveForm).BlankPanel.Controls.Add(uc);
            ((OpeningForm)ActiveForm).BlankPanel.Controls.Remove(currentControl);
            currentControl.Dispose();
            currentControl = uc;
        }

        public static void addSurveys(string[] unformattedSurveyes)
        {
            if (unformattedSurveyes.Length > 2)
            {
                _surveys = new string[unformattedSurveyes.Length - 2];
                for (int i = 1; i < unformattedSurveyes.Length - 1; i++)
                {
                    _surveys[i - 1] = unformattedSurveyes[i];
                }
            }
            else
            {
                _surveys = null;
            }
        }

        public static void updateSurveys(string surveyID, string controls)
        {
            //variable control not implemented yet
            try
            {
                using (var connection = new SqlConnection(OpeningForm.cb.ConnectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "select currentresults, samplesize from surveys where currentresults >= samplesize";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        reader.Close();
                        SqlCommand cmd2 = new SqlCommand();
                        cmd2.CommandType = CommandType.Text;
                        cmd2.Connection = connection;
                        cmd2.CommandText = string.Format("update users set availablesurveys = substring(availablesurveys, 1, CHARINDEX('{0}', availablesurveys) - 1) + substring(availablesurveys, CHARINDEX('{0}', availablesurveys) + 2, LEN(availablesurveys) - CHARINDEX('{0}', availablesurveys) + 2) where charindex('{0}', availablesurveys) > 0", surveyID + "/");
                        cmd2.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }
            catch (SqlException ex)
            {
        
            }
        }
    }
}

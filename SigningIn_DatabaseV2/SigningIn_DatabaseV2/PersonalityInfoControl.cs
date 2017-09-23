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
    public partial class PersonalityInfoControl : UserControl
    {
        BasicUserInfo ParentControl;
        private bool first = false;

        public PersonalityInfoControl(int state, BasicUserInfo bInfo)
        {
            InitializeComponent();

            #region GetInfoFromDatabase
            try
            {
                using (var connection = new SqlConnection(OpeningForm.cb.ConnectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();


                    SqlDataReader reader;
                    //cmd.CommandText = "SELECT * FROM Users";
                    cmd.CommandText = string.Format(@"SELECT * FROM PersonalityInfo
                                                      WHERE UserName = '{0}';", OpeningForm._username);
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string percentage = reader["MBTI_EI"].ToString();
                        string inverse = (100 - int.Parse(percentage)).ToString();
                        Edit_MBTI_ExtraversionLabel.Text = inverse;
                        Edit_MBTI_IntroversionLabel.Text = percentage;
                        EDIT_MBTI_IEBAR.Value = int.Parse(percentage);
                        ExtrovertedPercentLabel.Text = inverse;
                        IntrovertedPercentLabel.Text = percentage;
                        MBTI_IE_BAR.Value = int.Parse(percentage);

                        percentage = reader["MBTI_NS"].ToString();
                        inverse = (100 - int.Parse(percentage)).ToString();
                        Edit_MBTI_IntuitionLabel.Text = inverse;
                        Edit_MBTI_SensingLabel.Text = percentage;
                        EDIT_MBTI_NSBAR.Value = int.Parse(percentage);
                        IntuitivePercentLabel.Text = inverse;
                        SensingPercentLabel.Text = percentage;
                        MBTI_NS_BAR.Value = int.Parse(percentage);

                        percentage = reader["MBTI_TF"].ToString();
                        inverse = (100 - int.Parse(percentage)).ToString();
                        Edit_MBTI_ThinkingLabel.Text = inverse;
                        Edit_MBTI_FeelingLabel.Text = percentage;
                        EDIT_MBTI_TFBAR.Value = int.Parse(percentage);
                        ThinkingPercentLabel.Text = inverse;
                        FeelingPercentLabel.Text = percentage;
                        MBTI_TF_BAR.Value = int.Parse(percentage);

                        percentage = reader["MBTI_JP"].ToString();
                        inverse = (100 - int.Parse(percentage)).ToString();
                        Edit_MBTI_JudgingLabel.Text = inverse;
                        Edit_MBTI_PerceivingLabel.Text = percentage;
                        EDIT_MBTI_JPBAR.Value = int.Parse(percentage);
                        JudgingPercentLabel.Text = inverse;
                        PerceivingPercentLabel.Text = percentage;
                        MBTI_JP_BAR.Value = int.Parse(percentage);

                        string value = reader["BIG5_OTE"].ToString();
                        int parsedInt = int.Parse(value);
                        Edit_BIG5_OTELabel.Text = value;
                        EDIT_BIG5_OTEBAR.Value = parsedInt;
                        Big5_OpennessPercentLabel.Text = value;
                        BIG5_OTE_BAR.Value = parsedInt;

                        value = reader["BIG5_C"].ToString();
                        parsedInt = int.Parse(value);
                        Edit_BIG5_CLabel.Text = value;
                        EDIT_BIG5_CBAR.Value = parsedInt;
                        Big5_ConscientiousnessPercentLabel.Text = value;
                        BIG5_C_BAR.Value = parsedInt;

                        value = reader["BIG5_E"].ToString();
                        parsedInt = int.Parse(value);
                        Edit_BIG5_ELabel.Text = value;
                        EDIT_BIG5_EBAR.Value = parsedInt;
                        Big5_ExtraversionPercentLabel.Text = value;
                        BIG5_E_BAR.Value = parsedInt;

                        value = reader["BIG5_A"].ToString();
                        parsedInt = int.Parse(value);
                        Edit_BIG5_ALabel.Text = value;
                        EDIT_BIG5_ABAR.Value = parsedInt;
                        Big5_AgreeablenessPercentLabel.Text = value;
                        BIG5_A_BAR.Value = parsedInt;

                        value = reader["BIG5_N"].ToString();
                        parsedInt = int.Parse(value);
                        Edit_BIG5_NLabel.Text = value;
                        EDIT_BIG5_NBAR.Value = parsedInt;
                        Big5_NeuroticismPercentLabel.Text = value;
                        BIG5_N_BAR.Value = parsedInt;

                    }
                    else
                    {
                        //UserFirstNameLabel.Text = "CANT FIND NOTHING";
                        first = true;
                    }
                    reader.Close();
                    cmd.Dispose();
                    connection.Close();
                }

            }
            catch (SqlException ex)
            {
                //UserFirstNameLabel.Text = "SQL Exception";
            }
            #endregion
            ParentControl = bInfo;
            if (state == 0)
            {
                EditPanel.Visible = true;
                EditPanel.Location = new Point(0, 0);
                #region Make sure the track doesn't move with mouse wheel
                EDIT_MBTI_IEBAR.MouseWheel += new MouseEventHandler(DoNothing_MouseWheel);
                EDIT_MBTI_NSBAR.MouseWheel += new MouseEventHandler(DoNothing_MouseWheel);
                EDIT_MBTI_TFBAR.MouseWheel += new MouseEventHandler(DoNothing_MouseWheel);
                EDIT_MBTI_JPBAR.MouseWheel += new MouseEventHandler(DoNothing_MouseWheel);
                EDIT_BIG5_OTEBAR.MouseWheel += new MouseEventHandler(DoNothing_MouseWheel);
                EDIT_BIG5_CBAR.MouseWheel += new MouseEventHandler(DoNothing_MouseWheel);
                EDIT_BIG5_EBAR.MouseWheel += new MouseEventHandler(DoNothing_MouseWheel);
                EDIT_BIG5_ABAR.MouseWheel += new MouseEventHandler(DoNothing_MouseWheel);
                EDIT_BIG5_NBAR.MouseWheel += new MouseEventHandler(DoNothing_MouseWheel);

                #endregion
                DisplayPanel.Visible = false;
                DisplayPanel.Dispose();
            }
            else
            {
                DisplayPanel.Visible = true;
                DisplayPanel.Location = new Point(0, 0);
                EditPanel.Visible = false;
                EditPanel.Dispose();


            }
        }

        private void TestMBTIButton_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.16personalities.com/");
            Process.Start(sInfo);
        }

        private void TestBIG5Button_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.truity.com/test/big-five-personality-test");
            Process.Start(sInfo);
        }

        private void ConfirmEditsButton_Click(object sender, EventArgs e)
        {
            
            try
            {

                using (var connection = new SqlConnection(OpeningForm.cb.ConnectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();

                    /*
                    string EI = Edit_MBTI_ExtraversionLabel.Text + "/" + Edit_MBTI_IntroversionLabel.Text;
                    string NS = Edit_MBTI_IntuitionLabel.Text + "/" + Edit_MBTI_SensingLabel.Text;
                    string TF = Edit_MBTI_ThinkingLabel.Text + "/" + Edit_MBTI_FeelingLabel.Text;
                    string JP = Edit_MBTI_JudgingLabel.Text + "/" + Edit_MBTI_PerceivingLabel.Text;
                    */
                    string EI = Edit_MBTI_IntroversionLabel.Text;
                    string NS = Edit_MBTI_SensingLabel.Text;
                    string TF = Edit_MBTI_FeelingLabel.Text;
                    string JP = Edit_MBTI_PerceivingLabel.Text;
                    string OTE = Edit_BIG5_OTELabel.Text;
                    string C = Edit_BIG5_CLabel.Text;
                    string E = Edit_BIG5_ELabel.Text;
                    string A = Edit_BIG5_ALabel.Text;
                    string N = Edit_BIG5_NLabel.Text;

                    if (first)
                    {
                        cmd.CommandText = string.Format(@"INSERT INTO PersonalityInfo 
                                            (UserName, MBTI_EI, MBTI_NS, MBTI_TF, MBTI_JP, BIG5_OTE, BIG5_C, BIG5_E, BIG5_A, BIG5_N)
                                               VALUES
                                                 ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}');", OpeningForm._username, EI, NS, TF, JP, OTE, C, E, A, N);
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = connection;
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                    else
                    {
                        SqlDataReader reader;
                        cmd.CommandText = string.Format(@"SELECT * FROM SurveyInfo
                                                    WHERE UserName = '{0}';", OpeningForm._username);
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = connection;

                        reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            // UserID = int.Parse(reader["UserID"].ToString());
                            // DisplayLabel.Text = "Log in successfull. " + int.Parse(reader["UserID"].ToString()).ToString();
                            reader.Close();

                            cmd.CommandText = string.Format(@"UPDATE PersonalityInfo
                                                      SET MBTI_EI = '{1}', MBTI_NS = '{2}', MBTI_TF = '{3}', MBTI_JP = '{4}', BIG5_OTE = '{5}', BIG5_C = '{6}', BIG5_E = '{7}', BIG5_A = '{8}', BIG5_N = '{9}'
                                                      WHERE UserName = '{0}';", OpeningForm._username, EI, NS, TF, JP, OTE, C, E, A, N);
                            cmd.CommandType = CommandType.Text;
                            cmd.Connection = connection;
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                            connection.Close();
                        }
                    }
                }

            }
            catch (SqlException ex)
            {
                DisplayLabel.Text = "Connection Failed. " + OpeningForm.cb.DataSource;
            }
            ParentControl.PersonalityInfoPanel.Controls.Remove(this);
            PersonalityInfoControl pic = new PersonalityInfoControl(1, ParentControl);
            ParentControl.usercontrols[2] = pic;
            ParentControl.PersonalityInfoPanel.Controls.Add(pic);
            ParentControl.stateOfSections[2] = 1;
            if (first)
            {
                ParentControl.changeColors(2);
            }
            this.Dispose();
        }

        private void EditInfoButton_Click(object sender, EventArgs e)
        {
            ParentControl.PersonalityInfoPanel.Controls.Remove(this);
            PersonalityInfoControl pic = new PersonalityInfoControl(0, ParentControl);
            ParentControl.usercontrols[2] = pic;
            ParentControl.PersonalityInfoPanel.Controls.Add(pic);
            ParentControl.stateOfSections[2] = 0;
            this.Dispose();
        }

        private void EDIT_MBTI_IEBAR_Scroll(object sender, EventArgs e)
        {
            int percent = EDIT_MBTI_IEBAR.Value;
            Edit_MBTI_ExtraversionLabel.Text = (100 - percent).ToString();
            Edit_MBTI_IntroversionLabel.Text = percent.ToString();
        }

        private void EDIT_MBTI_NSBAR_Scroll(object sender, EventArgs e)
        {
            int percent = EDIT_MBTI_NSBAR.Value;
            Edit_MBTI_IntuitionLabel.Text = (100 - percent).ToString();
            Edit_MBTI_SensingLabel.Text = percent.ToString();
        }

        private void EDIT_MBTI_TFBAR_Scroll(object sender, EventArgs e)
        {
            int percent = EDIT_MBTI_TFBAR.Value;
            Edit_MBTI_ThinkingLabel.Text = (100 - percent).ToString();
            Edit_MBTI_FeelingLabel.Text = percent.ToString();
        }

        private void EDIT_MBTI_JPBAR_Scroll(object sender, EventArgs e)
        {
            int percent = EDIT_MBTI_JPBAR.Value;
            Edit_MBTI_JudgingLabel.Text = (100 - percent).ToString();
            Edit_MBTI_PerceivingLabel.Text = percent.ToString();
        }

        private void EDIT_BIG5_OTEBAR_Scroll(object sender, EventArgs e)
        {
            int percent = EDIT_BIG5_OTEBAR.Value;
            Edit_BIG5_OTELabel.Text = percent.ToString();
        }

        private void EDIT_BIG5_CBAR_Scroll(object sender, EventArgs e)
        {
            int percent = EDIT_BIG5_CBAR.Value;
            Edit_BIG5_CLabel.Text = percent.ToString();
        }

        private void EDIT_BIG5_EBAR_Scroll(object sender, EventArgs e)
        {
            int percent = EDIT_BIG5_EBAR.Value;
            Edit_BIG5_ELabel.Text = percent.ToString();
        }

        private void EDIT_BIG5_ABAR_Scroll(object sender, EventArgs e)
        {
            int percent = EDIT_BIG5_ABAR.Value;
            Edit_BIG5_ALabel.Text = percent.ToString();
        }

        private void EDIT_BIG5_NBAR_Scroll(object sender, EventArgs e)
        {
            int percent = EDIT_BIG5_NBAR.Value;
            Edit_BIG5_NLabel.Text = percent.ToString();
        }

        private void DoNothing_MouseWheel(object sender, EventArgs e)
        {
            HandledMouseEventArgs ee = (HandledMouseEventArgs)e;
            ee.Handled = true;
        }
    }
}

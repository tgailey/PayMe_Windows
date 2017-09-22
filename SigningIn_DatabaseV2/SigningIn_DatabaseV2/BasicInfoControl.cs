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
    public partial class BasicInfoControl : UserControl
    {
        BasicUserInfo ParentControl;
        private bool first = false;
        public BasicInfoControl()
        {
            InitializeComponent();
        }
        public BasicInfoControl(int state, BasicUserInfo bInfo)
        {
            InitializeComponent();
            first = false;
            #region GetInfoFromDatabase
            try
            {
                using (var connection = new SqlConnection(OpeningForm.cb.ConnectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();


                    SqlDataReader reader;
                    //cmd.CommandText = "SELECT * FROM Users";
                    cmd.CommandText = string.Format(@"SELECT * FROM BasicInfo
                                                      WHERE UserName = '{0}';", OpeningForm._username);
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        UserFirstNameLabel.Text = reader["FirstName"].ToString();
                        FirstNameTextBox.Text = reader["FirstName"].ToString();

                        UserDOBLabel.Text = reader["DateOfBirth"].ToString();
                        string[] dob = reader["DateOfBirth"].ToString().Split('/');
                        MonthBox.SelectedIndex = int.Parse(dob[0])-1;
                        DayBox.SelectedItem = dob[1];
                        YearBox.SelectedItem = dob[2];

                        UserGenderLabel.Text = reader["Gender"].ToString();
                        GenderBox.SelectedItem = reader["Gender"].ToString();

                        UserSexLabel.Text = reader["Sex"].ToString();
                        SexBox.SelectedItem = reader["Sex"].ToString();
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
                UserFirstNameLabel.Text = "SQL Exception";
            }
            #endregion
            ParentControl = bInfo;
            if (state == 0)
            {
                EditInfoPanel.Visible = true;
                EditInfoPanel.Location = new Point(0, 0);
                DisplayInfoPanel.Visible = false;
                DisplayInfoPanel.Dispose();
            }
            else
            {
                DisplayInfoPanel.Visible = true;
                DisplayInfoPanel.Location = new Point(0, 0);
                EditInfoPanel.Visible = false;
                EditInfoPanel.Dispose();


            }
        }
        private void ConfirmEditsButton_Click(object sender, EventArgs e)
        {
            if (FirstNameTextBox.Text.Length > 16)
            {
                DisplayLabel.Text = "Name too long (space will be increased later). Please choose shorten to 16 letters.";
                return;
            }
            else if (MonthBox.SelectedText == null || DayBox.SelectedText == null || YearBox.SelectedText == null || GenderBox.SelectedText == null || SexBox.SelectedText == null)
            {
                DisplayLabel.Text = "One of the required fields is blank";
                return;
            }
            try
            {

                using (var connection = new SqlConnection(OpeningForm.cb.ConnectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();

                    if (first)
                    {
                        string dateOfBirth = (MonthBox.SelectedIndex + 1).ToString() + "/" + DayBox.SelectedItem.ToString() + "/" + YearBox.SelectedItem.ToString();
                        cmd.CommandText = string.Format(@"INSERT INTO BasicInfo 
                                            (UserName, FirstName, DateOfBirth, Gender, Sex)
                                               VALUES
                                                 ('{0}', '{1}', '{2}', '{3}', '{4}');", OpeningForm._username, FirstNameTextBox.Text, dateOfBirth, GenderBox.SelectedItem.ToString(), SexBox.SelectedItem.ToString());
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = connection;
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                    else
                    {
                        SqlDataReader reader;
                        cmd.CommandText = string.Format(@"SELECT * FROM BasicInfo
                                                    WHERE UserName = '{0}';", OpeningForm._username);
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = connection;

                        reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            // UserID = int.Parse(reader["UserID"].ToString());
                            // DisplayLabel.Text = "Log in successfull. " + int.Parse(reader["UserID"].ToString()).ToString();
                            reader.Close();


                            string dateOfBirth = (MonthBox.SelectedIndex + 1).ToString() + "/" + DayBox.SelectedItem.ToString() + "/" + YearBox.SelectedItem.ToString();
                            cmd.CommandText = string.Format(@"UPDATE BasicInfo 
                                                      SET FirstName = '{0}', DateOfBirth = '{1}', Gender = '{2}', Sex = '{3}'
                                                      WHERE UserName = '{4}';",FirstNameTextBox.Text, dateOfBirth, GenderBox.SelectedItem.ToString(), SexBox.SelectedItem.ToString(), OpeningForm._username);
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
            ParentControl.BasicInfoPanel.Controls.Remove(this);
            BasicInfoControl bic = new BasicInfoControl(1, ParentControl);
            ParentControl.usercontrols[1] = bic;
            ParentControl.BasicInfoPanel.Controls.Add(bic);
            ParentControl.stateOfSections[1] = 1;
            if (first)
            {
                ParentControl.changeColors(1);
            }
            this.Dispose();
        }

        private void EditInfoButton_Click(object sender, EventArgs e)
        {
            ParentControl.BasicInfoPanel.Controls.Remove(this);
            BasicInfoControl bic = new BasicInfoControl(0, ParentControl);
            ParentControl.usercontrols[1] = bic;
            ParentControl.BasicInfoPanel.Controls.Add(bic);
            ParentControl.stateOfSections[1] = 0;
            this.Dispose();
        }
    }
}

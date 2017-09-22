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
    public partial class AccountInfoControl : UserControl
    {
        BasicUserInfo ParentControl;
        public AccountInfoControl()
        {
            InitializeComponent();
        }
        public AccountInfoControl(int state, BasicUserInfo bInfo)
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
                    cmd.CommandText = string.Format(@"SELECT * FROM Users
                                                      WHERE UserName = '{0}';", OpeningForm._username);
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        UserUsernameLabel.Text = reader["UserName"].ToString();
                        UsernameTextBox.Text = reader["UserName"].ToString();
                        UserEmailLabel.Text = reader["EmailAddress"].ToString();
                        EmailTextBox.Text = reader["EmailAddress"].ToString();
                        UserPasswordLabel.Text = reader["UserPassword"].ToString();
                        PasswordTextBox.Text = reader["UserPassword"].ToString();
                        PasswordTextBox.UseSystemPasswordChar = false;
                        ConfirmPasswordTextBox.Text = reader["UserPassword"].ToString();
                        ConfirmPasswordTextBox.UseSystemPasswordChar = false;
                    }
                    else
                    {
                        UserUsernameLabel.Text = "CANT FIND NOTHING";
                    }
                    reader.Close();
                    cmd.Dispose();
                    connection.Close();
                }

            }
            catch (SqlException ex)
            {
                UserUsernameLabel.Text = "SQL Exception";
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
            if (UsernameTextBox.Text.Length == 0 || EmailTextBox.Text.Length == 0 || PasswordTextBox.Text.Length == 0 || ConfirmPasswordTextBox.Text.Length == 0)
            {
                DisplayLabel.Text = "One of the required fields is blank.";
                return;
            }
            else if (UsernameTextBox.Text.Length > 16)
            {
                DisplayLabel.Text = "Username too long. Please choose another.";
                return;
            }
            else if (PasswordTextBox.Text.Length > 32)
            {
                DisplayLabel.Text = "Password too long. Please choose another.";
                return;
            }
            else if (!PasswordTextBox.Text.Equals(ConfirmPasswordTextBox.Text))
            {
                DisplayLabel.Text = "Passwords Don't Match.";
                return;
            }
            try
            {

                using (var connection = new SqlConnection(OpeningForm.cb.ConnectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();


                    SqlDataReader reader;
                    cmd.CommandText = string.Format(@"SELECT * FROM Users
                                                      WHERE (UserName = '{0}' OR EmailAddress = '{0}')
                                                      AND UserPassword = '{1}';", UsernameTextBox.Text, PasswordTextBox.Text);
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;

                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        // UserID = int.Parse(reader["UserID"].ToString());
                       // DisplayLabel.Text = "Log in successfull. " + int.Parse(reader["UserID"].ToString()).ToString();
                        reader.Close();



                        cmd.CommandText = string.Format(@"UPDATE Users 
                                                      SET UserName = '{0}', EmailAddress = '{1}', UserPassword = '{2}'
                                                      WHERE UserName = '{3}';", UsernameTextBox.Text, EmailTextBox.Text, PasswordTextBox.Text, OpeningForm._username);
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = connection;
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        connection.Close();
                        OpeningForm._username = UsernameTextBox.Text;
                    }
                }

            }
            catch (SqlException ex)
            {
                DisplayLabel.Text = "Connection Failed. " + OpeningForm.cb.DataSource;
            }
            ParentControl.AccountInfoPanel.Controls.Remove(this);
            AccountInfoControl aic = new AccountInfoControl(1, ParentControl);
            ParentControl.usercontrols[0] = aic;
            ParentControl.AccountInfoPanel.Controls.Add(aic);
            ParentControl.stateOfSections[0] = 1;
            this.Dispose();
        }

        private void EditInfoButton_Click(object sender, EventArgs e)
        {
            ParentControl.AccountInfoPanel.Controls.Remove(this);
            AccountInfoControl aic = new AccountInfoControl(0, ParentControl);
            ParentControl.usercontrols[0] = aic;
            ParentControl.AccountInfoPanel.Controls.Add(aic);
            ParentControl.stateOfSections[0] = 0;
            this.Dispose();
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = true;
        }

        private void ConfirmPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            ConfirmPasswordTextBox.UseSystemPasswordChar = true;
        }
    }
}

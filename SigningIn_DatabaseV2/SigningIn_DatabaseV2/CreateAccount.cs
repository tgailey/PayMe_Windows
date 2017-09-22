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
    public partial class CreateAccount : UserControl
    {
        public CreateAccount()
        {
            InitializeComponent();

        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            UsernameTextBox.ForeColor = Color.Black;
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            EmailTextBox.ForeColor = Color.Black;
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            PasswordTextBox.ForeColor = Color.Black;
            PasswordTextBox.UseSystemPasswordChar = true;
        }

        private void ConfirmPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            ConfirmPasswordTextBox.ForeColor = Color.Black;
            ConfirmPasswordTextBox.UseSystemPasswordChar = true;
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
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
                    // cmd.CommandText = "SELECT UserID, UserName FROM Users";
                    cmd.CommandText = string.Format(@"SELECT UserName, EmailAddress FROM Users
                                                      WHERE UserName = '{0}' OR EmailAddress = '{1}';", UsernameTextBox.Text, EmailTextBox.Text);
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;

                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        if (reader["UserName"].Equals(UsernameTextBox.Text))
                        {
                            DisplayLabel.Text = "Username already taken. Please choose another.";
                        }
                        else
                            DisplayLabel.Text = "Email Address already taken. Please choose another.";
                        return;
                    }
                    else
                    {
                        DisplayLabel.Text = "Account Created";
                    }
                    reader.Close();

                    cmd.CommandText = string.Format(@"INSERT INTO Users 
                                            (UserName, EmailAddress, UserPassword)
                                               VALUES
                                                 ('{0}', '{1}', '{2}');", UsernameTextBox.Text, EmailTextBox.Text, PasswordTextBox.Text);
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    OpeningForm._username = UsernameTextBox.Text;
                    BasicUserInfo bui = new BasicUserInfo();
                    OpeningForm.switchUserControl(bui);
                }
            }
            catch (SqlException ex)
            {
                DisplayLabel.Text = "Connection Failed. " + OpeningForm.cb.DataSource;
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            OpeningForm.switchUserControl(l);
        }
    }
}

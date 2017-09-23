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
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            UsernameTextBox.ForeColor = Color.Black;
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            PasswordTextBox.ForeColor = Color.Black;
            PasswordTextBox.UseSystemPasswordChar = true;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text.Length == 0 || PasswordTextBox.Text.Length == 0)
            {
                DisplayLabel.Text = "One of the fields is blank";
                return;
            }

            try
            {

                using (var connection = new SqlConnection(OpeningForm.cb.ConnectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();


                    SqlDataReader reader;
                    //cmd.CommandText = "SELECT * FROM Users";
                    cmd.CommandText = string.Format(@"SELECT * FROM Users
                                                      WHERE (UserName = '{0}' OR EmailAddress = '{0}')
                                                      AND UserPassword = '{1}';", UsernameTextBox.Text, PasswordTextBox.Text);
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;

                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                       // UserID = int.Parse(reader["UserID"].ToString());
                        DisplayLabel.Text = "Log in successfull. " + int.Parse(reader["UserID"].ToString()).ToString();

                        OpeningForm._username = reader["UserName"].ToString();
                        OpeningForm._researcher = int.Parse(reader["Researcher"].ToString());
                        reader.Close();
                        cmd.Dispose();
                        connection.Close();
                        OpeningForm.openApp();
                        return;
                    }
                    reader.Close();
                    cmd.Dispose();
                    connection.Close();
                    DisplayLabel.Text = "Username or password did not match";
                }
            }
            catch (SqlException ex)
            {
                DisplayLabel.Text = "SQL Exception";
            }
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            CreateAccount ca = new CreateAccount();
            OpeningForm.switchUserControl(ca);
        }
    }
}

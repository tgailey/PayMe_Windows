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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SigningIn_DatabaseV2
{
    public partial class AboutMeControl : UserControl
    {
        public AboutMeControl()
        {
            InitializeComponent();
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            CreateAccount ca = new CreateAccount();
            OpeningForm.switchUserControl(ca);
        }
    }
}

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
    public partial class ViewSurveysControl : UserControl
    {
        public ViewSurveysControl()
        {
            InitializeComponent();
        }

        private void CreateSurveyButton_Click(object sender, EventArgs e)
        {
            CreateSurveyControl csc = new CreateSurveyControl();
            OpeningForm.switchUserControl(csc);
        }
    }
}

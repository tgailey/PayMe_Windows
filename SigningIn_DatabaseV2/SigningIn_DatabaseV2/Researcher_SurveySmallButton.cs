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
    public partial class Researcher_SurveySmallButton : UserControl
    {
        string[] details;
        public Researcher_SurveySmallButton(string[] details)
        {
            InitializeComponent();
            this.details = details;
            SurveyNameLabel.Text = details[1];
            SampleSizeLabel.Text = "Sample Size: " + details[5];
            CurrentResultsLabel.Text = "Current Results: " + details[6];
            SurveyNameLabel.Click += new System.EventHandler(Researcher_SurveySmallButton_Click);
            SampleSizeLabel.Click += new System.EventHandler(Researcher_SurveySmallButton_Click);
            CurrentResultsLabel.Click += new System.EventHandler(Researcher_SurveySmallButton_Click);
        }

        private void Researcher_SurveySmallButton_Click(object sender, EventArgs e)
        {
            Researcher_SurveyDetails sd = new Researcher_SurveyDetails(details);
            OpeningForm.switchUserControl(sd);
        }
    }
}

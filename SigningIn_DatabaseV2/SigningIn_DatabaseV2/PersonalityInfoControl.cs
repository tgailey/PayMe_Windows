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
        public PersonalityInfoControl()
        {
            InitializeComponent();
        }

        public PersonalityInfoControl(int state, BasicUserInfo bInfo)
        {
            InitializeComponent();
        }

        private void TestMBTIButton_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.16personalities.com/");
            Process.Start(sInfo);
        }

        private void MBTI_IE_BAR_Scroll(object sender, EventArgs e)
        {
            int percent = MBTI_IE_BAR.Value;
            ExtrovertedPercentLabel.Text = (100 - percent).ToString();
            IntrovertedPercentLabel.Text = percent.ToString();
            //ExtrovertedPercentLabel.Text = (MBTI_IE_BAR.Value).ToString();
            //IntrovertedPercentLabel.Text = (MBTI_IE_BAR.Maximum).ToString();
        }

        private void MBTI_NS_BAR_Scroll(object sender, EventArgs e)
        {
            int percent = MBTI_NS_BAR.Value;
            IntuitivePercentLabel.Text = (100 - percent).ToString();
            SensingPercentLabel.Text = percent.ToString();
        }

        private void MBTI_TF_BAR_Scroll(object sender, EventArgs e)
        {
            int percent = MBTI_TF_BAR.Value;
            ThinkingPercentLabel.Text = (100 - percent).ToString();
            FeelingPercentLabel.Text = percent.ToString();
        }

        private void MBTI_JP_BAR_Scroll(object sender, EventArgs e)
        {
            int percent = MBTI_JP_BAR.Value;
            JudgingPercentLabel.Text = (100 - percent).ToString();
            PerceivingPercentLabel.Text = percent.ToString();
        }

        private void TestBIG5Button_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.truity.com/test/big-five-personality-test");
            Process.Start(sInfo);
        }

        private void BIG5_OTE_BAR_Scroll(object sender, EventArgs e)
        {
            int percent = BIG5_OTE_BAR.Value;
            Big5_OpennessPercentLabel.Text = percent.ToString();
        }

        private void BIG5_C_BAR_Scroll(object sender, EventArgs e)
        {
            int percent = BIG5_C_BAR.Value;
            Big5_ConscientiousnessPercentLabel.Text = percent.ToString();
        }

        private void BIG5_E_BAR_Scroll(object sender, EventArgs e)
        {
            int percent = BIG5_E_BAR.Value;
            Big5_ExtraversionPercentLabel.Text = percent.ToString();
        }

        private void BIG5_A_BAR_Scroll(object sender, EventArgs e)
        {
            int percent = BIG5_A_BAR.Value;
            Big5_AgreeablenessPercentLabel.Text = percent.ToString();
        }

        private void BIG5_N_BAR_Scroll(object sender, EventArgs e)
        {
            int percent = BIG5_N_BAR.Value;
            Big5_NeuroticismPercentLabel.Text = percent.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyTech
{
    public partial class StagePageForm : Form
    {
        public StagePageForm()
        {
            InitializeComponent();
        }

        private void StagePageForm_Load(object sender, EventArgs e)
        {
            //reviewer Name retrieval from database here
        }

        private void cvTemplatePage_Click(object sender, EventArgs e)
        {
            this.Hide();
            CVTemplateForm cvTemplatePage = new CVTemplateForm();
            cvTemplatePage.ShowDialog();
            this.Close();
        }

        private void onlineTestTemplatePage_Click(object sender, EventArgs e)
        {
            this.Hide();
            onlineTestTemplateForm onlineTestTemplatePage = new onlineTestTemplateForm();
            onlineTestTemplatePage.ShowDialog();
            this.Close();
        }

        private void interviewTemplatePage_Click(object sender, EventArgs e)
        {
            this.Hide();
            InterviewReportTemplateForm interviewReportTemplatePage = new InterviewReportTemplateForm();
            interviewReportTemplatePage.ShowDialog();
            this.Close();
        }
    }
}

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
    public partial class CreateUserForm : Form
    {
        public CreateUserForm()
        {
            InitializeComponent();
        }

        private void CreateUserForm_Load(object sender, EventArgs e)
        {
            logoDisplay.Image = Properties.Resources.logo;
            logoDisplay.Refresh();
            logoDisplay.Visible = true;
        }

        private void confirmUserInfo_Click(object sender, EventArgs e)
        {
            //Store data to DB and redirect to Stage
            this.Hide();
            StagePageForm stagePage = new StagePageForm();
            stagePage.ShowDialog();
            this.Close();
        }
    }
}

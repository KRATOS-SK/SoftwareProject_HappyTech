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
    public partial class LoginPageForm : Form
    {
        public LoginPageForm()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            logoDisplay.Image = Properties.Resources.logo;
            logoDisplay.Refresh();
            logoDisplay.Visible = true;
        }

        private void loginSubmit_Click(object sender, EventArgs e)
        {
            //validation check here (Backend)
            this.Hide();
            StagePageForm stagePage = new StagePageForm();
            stagePage.ShowDialog();
            this.Close();
        }

        private void createUserLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            CreateUserForm newUserPage = new CreateUserForm();
            newUserPage.ShowDialog();
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HappyTech
{
    public partial class onlineTestTemplateForm : Form
    {
        public onlineTestTemplateForm()
        {
            InitializeComponent();
        }
        private void CVTemplateForm_Load(object sender, EventArgs e)
        {
            //jobsList.DataSource = assign data source for jobs list from DB
            string onlineTestTemplatePath = System.IO.Path.Combine(Application.UserAppDataPath, Application.UserAppDataPath + "\\onlineTestTemplates");
            if (!Directory.Exists(onlineTestTemplatePath))
            {
                System.IO.Directory.CreateDirectory(onlineTestTemplatePath);
                AssignDataSourceToTemplateList();
            }
            else
            {
                AssignDataSourceToTemplateList();
            }
        }
        private void deleteTemplateButton_Click(object sender, EventArgs e)
        {
            string selectedItem = templateList.Items[templateList.SelectedIndex].ToString();
            string cvTemplatePath = System.IO.Path.Combine(Application.UserAppDataPath, Application.UserAppDataPath + "\\onlineTestTemplates");
            string filePath = cvTemplatePath + "\\" + selectedItem;

            DialogResult deleteConfirmation = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (deleteConfirmation == DialogResult.OK)
            {
                File.Delete(filePath);
                AssignDataSourceToTemplateList();
            }
        }

        private void createNewTemplateButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateTemplateForm createTemplate = new CreateTemplateForm("Online Test");
            createTemplate.ShowDialog();
            this.Close();
        }

        private void useTemplateButton_Click(object sender, EventArgs e)
        {

        }

        private void editTemplateButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditTemplateForm editTemplate = new EditTemplateForm("Online Test", templateList.Items[templateList.SelectedIndex].ToString());
            editTemplate.ShowDialog();
            this.Close();
        }

        private void selectCVButton_Click(object sender, EventArgs e)
        {
            //openCVDialog.Filter = "PDF document (*.pdf)|*.pdf|Word document (*.docx)|*.docx"; could filter the types of files to view

            DialogResult result = openTestReportDialog.ShowDialog();

            if (result == DialogResult.OK)

            {
                try
                {
                    string selectedFile = openTestReportDialog.FileName;
                    this.onlineTestViewer.LoadDocument(selectedFile);
                }
                catch (Exception exe)
                {
                    MessageBox.Show(exe.Message, "Unexpected Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void templateList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = templateList.Items[templateList.SelectedIndex].ToString();
            string cvTemplatePath = System.IO.Path.Combine(Application.UserAppDataPath, Application.UserAppDataPath + "\\onlineTestTemplates");
            string filePath = cvTemplatePath + "\\" + selectedItem;
            try
            {
                this.templateViewer.LoadDocument(filePath);
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message, "Unexpected Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AssignDataSourceToTemplateList()
        {
            string pathString = System.IO.Path.Combine(Application.UserAppDataPath, Application.UserAppDataPath + "\\onlineTestTemplates");
            DirectoryInfo getDirectoryInformation = new DirectoryInfo(pathString);
            FileInfo[] files = getDirectoryInformation.GetFiles();
            templateList.DataSource = files;
        }
    }
}

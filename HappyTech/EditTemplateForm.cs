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
    public partial class EditTemplateForm : Form
    {
        public String templateType = null;
        public String fileToEdit = null;
        public EditTemplateForm()
        {
            InitializeComponent();
        }
        public EditTemplateForm(String templateTypeParameter, String selectedFileForEdit)
        {
            InitializeComponent();
            templateType = templateTypeParameter;
            fileToEdit = selectedFileForEdit;
        }
        private void CreateOrEditTemplate_Load(object sender, EventArgs e)
        {
            //Get Reviewer Name
            templateTypeLabel.Text = templateType + " Templates";
            dateOnTemplate.Text = "Date: " + System.DateTime.Today.ToString("d");
            commentSectionSelection.SelectedIndex = 0;

            //Load data into commentsTable from DB
            DataSet ds = DatabaseConnection.getInstanceOfDBConnection().getDataSet("SELECT * FROM CVComments");
            commentsTable.DataSource = ds.Tables[0];

            DataGridViewColumn setColumnWidth = commentsTable.Columns[0];
            setColumnWidth.Width = 50;
            //commentsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            if (this.fileToEdit!=null) //open contents of selected file for edit here
            {
                section1TextBox.Text = fileToEdit;
                section2TextBox.Text = fileToEdit;
                section3TextBox.Text = fileToEdit; //test code
                section4TextBox.Text = fileToEdit;

            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            switch(templateType)
            {
                case "CV":
                    CVTemplateForm cvTemplatePage = new CVTemplateForm();
                    cvTemplatePage.ShowDialog();
                    this.Close();
                    break;
                case "Online Test":
                    onlineTestTemplateForm onlineTestTemplatePage = new onlineTestTemplateForm();
                    onlineTestTemplatePage.ShowDialog();
                    this.Close();
                    break;
                case "Interview Report":
                    InterviewReportTemplateForm interviewReportTemplatePage = new InterviewReportTemplateForm();
                    interviewReportTemplatePage.ShowDialog();
                    this.Close();
                    break;
                default: 
                    StagePageForm stagePage = new StagePageForm();
                    stagePage.ShowDialog();
                    this.Close();
                    break;
            }

        }

        private void saveTemplateButton_Click(object sender, EventArgs e)
        {

        }

        private void saveAndUseButton_Click(object sender, EventArgs e)
        {

        }

        private void commentSectionSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet commentsToDisplay;
            String selectCommentsTable = locateCommentTableInDatabase(templateType);
            //commentsTable.DataSource = ds.Tables[0];
            //switch(commentSectionSelection.SelectedIndex)
            //{
            //    case 0:
            //        commentsToDisplay = DatabaseConnection.getInstanceOfDBConnection().getDataSet("SELECT * FROM CVComments");
            //        commentsTable.DataSource = ds.Tables[0];
            //        break;
            //}
        }

        public String locateCommentTableInDatabase(String typeOfTemplate)
        {
            typeOfTemplate = templateType;
            String commentsTableName = null;

            if(templateType != null)
            {
                switch(templateType)
                {
                    case "CV":
                        commentsTableName = "CVComments";
                        break;
                    case "Online Test":
                        commentsTableName = "OnlineTestComments";
                        break;
                    case "Interview Report":
                        commentsTableName = "InterviewComments";
                        break;
                    default:
                        commentsTableName = null;
                        break;                       
                }
            }

            return commentsTableName;
        }
    }
}

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
    public partial class CreateTemplateForm : Form
    {
        public String templateType = null;
        public String tableName = null;
        private List<string> commentCodeList = new List<string>();
        public CreateTemplateForm()
        {
            InitializeComponent();
        }

        public CreateTemplateForm(String templateTypeParameter)
        {
            InitializeComponent();
            templateType = templateTypeParameter;
        }
        private void CreateTemplateForm_Load(object sender, EventArgs e)
        {
            //Get Reviewer Name
            templateTypeLabel.Text = templateType + " Templates";

            dateOnTemplate.Text = "Date: " + System.DateTime.Today.ToString("d");

            tableName = locateCommentTableInDatabase(templateType); //Which table to get comments from

            //Load data into commentsTable from DB
            DataSet initialData = DatabaseConnection.getInstanceOfDBConnection().getDataSet("SELECT * FROM " + tableName);
            commentsTable.DataSource = initialData.Tables[0];

            commentSectionSelection.SelectedIndex = 0; //Assigning Default selection for commentsList

            DataGridViewColumn setColumnWidth = commentsTable.Columns[0]; // change Column Width
            setColumnWidth.Width = 50;
            //commentsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            switch (templateType)
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
            AssignCommentCodeRange codeRange = new AssignCommentCodeRange(templateType);

            switch (commentSectionSelection.SelectedIndex)
            {
                case 0:
                    commentsToDisplay = DatabaseConnection.getInstanceOfDBConnection().getDataSet("SELECT * FROM " + tableName);
                    commentsTable.DataSource = commentsToDisplay.Tables[0];
                    break;
                case 1:
                    commentsToDisplay = DatabaseConnection.getInstanceOfDBConnection().getDataSet("SELECT * FROM " + tableName + " WHERE commentCode BETWEEN " + codeRange.baseValue + " AND " + codeRange.section1Range);
                    commentsTable.DataSource = commentsToDisplay.Tables[0];
                    break;
                case 2:
                    commentsToDisplay = DatabaseConnection.getInstanceOfDBConnection().getDataSet("SELECT * FROM " + tableName + " WHERE commentCode BETWEEN " + codeRange.section1Range + " AND " + codeRange.section2Range);
                    commentsTable.DataSource = commentsToDisplay.Tables[0];
                    break;
                case 3:
                    commentsToDisplay = DatabaseConnection.getInstanceOfDBConnection().getDataSet("SELECT * FROM " + tableName + " WHERE commentCode BETWEEN " + codeRange.section2Range + " AND " + codeRange.section3Range);
                    commentsTable.DataSource = commentsToDisplay.Tables[0];
                    break;
                case 4:
                    commentsToDisplay = DatabaseConnection.getInstanceOfDBConnection().getDataSet("SELECT * FROM " + tableName + " WHERE commentCode BETWEEN " + codeRange.section3Range + " AND " + codeRange.section4Range);
                    commentsTable.DataSource = commentsToDisplay.Tables[0];
                    break;
                default:
                    MessageBox.Show("Section Not Found!");
                    break;
            }
        }

        public String locateCommentTableInDatabase(String typeOfTemplate)
        {
            typeOfTemplate = templateType;
            String commentsTableName = null;

            if (typeOfTemplate != null)
            {
                switch (typeOfTemplate)
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

        private void commentsTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int commentSectionBoxSelector;
            AssignCommentCodeRange codeRange = new AssignCommentCodeRange(templateType);

            if (commentsTable.CurrentCell.ColumnIndex == 0)
            {
                commentSectionBoxSelector = int.Parse(commentsTable.CurrentCell.Value.ToString());
            }
            else
            {
                commentSectionBoxSelector = int.Parse(commentsTable[commentsTable.CurrentCell.ColumnIndex - 1, commentsTable.CurrentCell.RowIndex].Value.ToString());
            }

            switch(commentSectionBoxSelector)
            {
                case int commentCodeRange when (commentCodeRange > codeRange.baseValue && commentCodeRange < codeRange.section1Range):
                    if (commentsTable.CurrentCell.Style.BackColor != System.Drawing.Color.Aquamarine)
                    {
                        AddCommentToSection1();
                    }
                    else
                    {
                        RemoveCommentFromSection1();
                    }
                    break;

                case int commentCodeRange when (commentCodeRange > codeRange.section1Range && commentCodeRange < codeRange.section2Range):
                    if (commentsTable.CurrentCell.Style.BackColor != System.Drawing.Color.Aquamarine)
                    {
                        AddCommentToSection2();
                    }
                    else
                    {
                        RemoveCommentFromSection2();
                    }
                    break;

                case int commentCodeRange when (commentCodeRange > codeRange.section2Range && commentCodeRange < codeRange.section3Range):
                    if (commentsTable.CurrentCell.Style.BackColor != System.Drawing.Color.Aquamarine)
                    {
                        AddCommentToSection3();
                    }
                    else
                    {
                        RemoveCommentFromSection3();
                    }
                    break;

                case int commentCodeRange when (commentCodeRange > codeRange.section3Range && commentCodeRange < codeRange.section4Range):
                    if (commentsTable.CurrentCell.Style.BackColor != System.Drawing.Color.Aquamarine)
                    {
                        AddCommentToSection4();
                    }
                    else
                    {
                        RemoveCommentFromSection4();
                    }
                    break;

                default:
                    MessageBox.Show("Invalid Comment Code!");
                    break;
            }
        }

        public void AddCommentToSection1()
        {
            string oldString = section1TextBox.Text;

            if (commentsTable.CurrentCell.ColumnIndex == 0)
            {
                string newString = String.Concat(oldString, "\n", commentsTable.CurrentCell.Value.ToString(), " - ");
                string newString2 = String.Concat(newString, commentsTable[commentsTable.CurrentCell.ColumnIndex + 1, commentsTable.CurrentCell.RowIndex].Value.ToString(), "\n");
                section1TextBox.Text = StringTrimmer(newString2);

                commentCodeList.Add(commentsTable.CurrentCell.Value.ToString()); //add comment code to list

                commentsTable.CurrentCell.Style.BackColor = System.Drawing.Color.Aquamarine;
                commentsTable[commentsTable.CurrentCell.ColumnIndex + 1, commentsTable.CurrentCell.RowIndex].Style.BackColor = System.Drawing.Color.Aquamarine;

            }
            else
            {
                string newString = String.Concat(oldString, "\n", commentsTable[commentsTable.CurrentCell.ColumnIndex - 1, commentsTable.CurrentCell.RowIndex].Value.ToString(), " - ");
                string newString2 = String.Concat(newString, commentsTable.CurrentCell.Value.ToString(), "\n");
                section1TextBox.Text = StringTrimmer(newString2);

                commentCodeList.Add(commentsTable[commentsTable.CurrentCell.ColumnIndex - 1, commentsTable.CurrentCell.RowIndex].Value.ToString()); //add comment code to list for adjacent comment

                commentsTable.CurrentCell.Style.BackColor = System.Drawing.Color.Aquamarine;
                commentsTable[commentsTable.CurrentCell.ColumnIndex - 1, commentsTable.CurrentCell.RowIndex].Style.BackColor = System.Drawing.Color.Aquamarine;

            }
        }
        public void AddCommentToSection2()
        {
            string oldString = section2TextBox.Text;

            if (commentsTable.CurrentCell.ColumnIndex == 0)
            {
                string newString = String.Concat(oldString, "\n", commentsTable.CurrentCell.Value.ToString(), " - ");
                string newString2 = String.Concat(newString, commentsTable[commentsTable.CurrentCell.ColumnIndex + 1, commentsTable.CurrentCell.RowIndex].Value.ToString(), "\n");
                section2TextBox.Text = StringTrimmer(newString2);

                commentCodeList.Add(commentsTable.CurrentCell.Value.ToString()); //add comment code to list

                commentsTable.CurrentCell.Style.BackColor = System.Drawing.Color.Aquamarine;
                commentsTable[commentsTable.CurrentCell.ColumnIndex + 1, commentsTable.CurrentCell.RowIndex].Style.BackColor = System.Drawing.Color.Aquamarine;

            }
            else
            {
                string newString = String.Concat(oldString, "\n", commentsTable[commentsTable.CurrentCell.ColumnIndex - 1, commentsTable.CurrentCell.RowIndex].Value.ToString(), " - ");
                string newString2 = String.Concat(newString, commentsTable.CurrentCell.Value.ToString(), "\n");
                section2TextBox.Text = StringTrimmer(newString2);

                commentCodeList.Add(commentsTable[commentsTable.CurrentCell.ColumnIndex - 1, commentsTable.CurrentCell.RowIndex].Value.ToString()); //add comment code to list for adjacent comment

                commentsTable.CurrentCell.Style.BackColor = System.Drawing.Color.Aquamarine;
                commentsTable[commentsTable.CurrentCell.ColumnIndex - 1, commentsTable.CurrentCell.RowIndex].Style.BackColor = System.Drawing.Color.Aquamarine;

            }
        }
        public void AddCommentToSection3()
        {
            string oldString = section3TextBox.Text;

            if (commentsTable.CurrentCell.ColumnIndex == 0)
            {
                string newString = String.Concat(oldString, "\n", commentsTable.CurrentCell.Value.ToString(), " - ");
                string newString2 = String.Concat(newString, commentsTable[commentsTable.CurrentCell.ColumnIndex + 1, commentsTable.CurrentCell.RowIndex].Value.ToString(), "\n");
                section3TextBox.Text = StringTrimmer(newString2);

                commentCodeList.Add(commentsTable.CurrentCell.Value.ToString()); //add comment code to list

                commentsTable.CurrentCell.Style.BackColor = System.Drawing.Color.Aquamarine;
                commentsTable[commentsTable.CurrentCell.ColumnIndex + 1, commentsTable.CurrentCell.RowIndex].Style.BackColor = System.Drawing.Color.Aquamarine;

            }
            else
            {
                string newString = String.Concat(oldString, "\n", commentsTable[commentsTable.CurrentCell.ColumnIndex - 1, commentsTable.CurrentCell.RowIndex].Value.ToString(), " - ");
                string newString2 = String.Concat(newString, commentsTable.CurrentCell.Value.ToString(), "\n");
                section3TextBox.Text = StringTrimmer(newString2);

                commentCodeList.Add(commentsTable[commentsTable.CurrentCell.ColumnIndex - 1, commentsTable.CurrentCell.RowIndex].Value.ToString()); //add comment code to list for adjacent comment

                commentsTable.CurrentCell.Style.BackColor = System.Drawing.Color.Aquamarine;
                commentsTable[commentsTable.CurrentCell.ColumnIndex - 1, commentsTable.CurrentCell.RowIndex].Style.BackColor = System.Drawing.Color.Aquamarine;

            }
        }
        public void AddCommentToSection4()
        {
            string oldString = section4TextBox.Text;

            if (commentsTable.CurrentCell.ColumnIndex == 0)
            {
                string newString = String.Concat(oldString, "\n", commentsTable.CurrentCell.Value.ToString(), " - ");
                string newString2 = String.Concat(newString, commentsTable[commentsTable.CurrentCell.ColumnIndex + 1, commentsTable.CurrentCell.RowIndex].Value.ToString(), "\n");
                section4TextBox.Text = StringTrimmer(newString2);

                commentCodeList.Add(commentsTable.CurrentCell.Value.ToString()); //add comment code to list

                commentsTable.CurrentCell.Style.BackColor = System.Drawing.Color.Aquamarine;
                commentsTable[commentsTable.CurrentCell.ColumnIndex + 1, commentsTable.CurrentCell.RowIndex].Style.BackColor = System.Drawing.Color.Aquamarine;

            }
            else
            {
                string newString = String.Concat(oldString, "\n", commentsTable[commentsTable.CurrentCell.ColumnIndex - 1, commentsTable.CurrentCell.RowIndex].Value.ToString(), " - ");
                string newString2 = String.Concat(newString, commentsTable.CurrentCell.Value.ToString(), "\n");
                section4TextBox.Text = StringTrimmer(newString2);

                commentCodeList.Add(commentsTable[commentsTable.CurrentCell.ColumnIndex - 1, commentsTable.CurrentCell.RowIndex].Value.ToString()); //add comment code to list for adjacent comment

                commentsTable.CurrentCell.Style.BackColor = System.Drawing.Color.Aquamarine;
                commentsTable[commentsTable.CurrentCell.ColumnIndex - 1, commentsTable.CurrentCell.RowIndex].Style.BackColor = System.Drawing.Color.Aquamarine;

            }
        }
        public void RemoveCommentFromSection1()
        {

            if (commentsTable.CurrentCell.ColumnIndex == 0)
            {
                String removalString;
                String stringToBeTrimmed;
                removalString = String.Concat(commentsTable.CurrentCell.Value.ToString(), " - ", commentsTable[commentsTable.CurrentCell.ColumnIndex + 1, commentsTable.CurrentCell.RowIndex].Value.ToString());
                stringToBeTrimmed = section1TextBox.Text.Replace(removalString, "");
                section1TextBox.Text = StringTrimmer(stringToBeTrimmed);

                commentCodeList.Remove(commentsTable.CurrentCell.Value.ToString());

                commentsTable.CurrentCell.Style.BackColor = System.Drawing.Color.White;
                commentsTable[commentsTable.CurrentCell.ColumnIndex + 1, commentsTable.CurrentCell.RowIndex].Style.BackColor = System.Drawing.Color.White;
            }
            else
            {
                String removalString;
                String stringToBeTrimmed;
                removalString = String.Concat(commentsTable[commentsTable.CurrentCell.ColumnIndex - 1, commentsTable.CurrentCell.RowIndex].Value.ToString(), " - ", commentsTable.CurrentCell.Value.ToString());
                stringToBeTrimmed = section1TextBox.Text.Replace(removalString, "");
                section1TextBox.Text = StringTrimmer(stringToBeTrimmed);

                commentCodeList.Remove(commentsTable[commentsTable.CurrentCell.ColumnIndex - 1, commentsTable.CurrentCell.RowIndex].Value.ToString());

                commentsTable.CurrentCell.Style.BackColor = System.Drawing.Color.White;
                commentsTable[commentsTable.CurrentCell.ColumnIndex - 1, commentsTable.CurrentCell.RowIndex].Style.BackColor = System.Drawing.Color.White;
            }
        }
        public void RemoveCommentFromSection2()
        {

            if (commentsTable.CurrentCell.ColumnIndex == 0)
            {
                String removalString;
                String stringToBeTrimmed;
                removalString = String.Concat(commentsTable.CurrentCell.Value.ToString(), " - ", commentsTable[commentsTable.CurrentCell.ColumnIndex + 1, commentsTable.CurrentCell.RowIndex].Value.ToString());
                stringToBeTrimmed = section2TextBox.Text.Replace(removalString, "");
                section2TextBox.Text = StringTrimmer(stringToBeTrimmed);

                commentCodeList.Remove(commentsTable.CurrentCell.Value.ToString());

                commentsTable.CurrentCell.Style.BackColor = System.Drawing.Color.White;
                commentsTable[commentsTable.CurrentCell.ColumnIndex + 1, commentsTable.CurrentCell.RowIndex].Style.BackColor = System.Drawing.Color.White;
            }
            else
            {
                String removalString;
                String stringToBeTrimmed;
                removalString = String.Concat(commentsTable[commentsTable.CurrentCell.ColumnIndex - 1, commentsTable.CurrentCell.RowIndex].Value.ToString(), " - ", commentsTable.CurrentCell.Value.ToString());
                stringToBeTrimmed = section2TextBox.Text.Replace(removalString, "");
                section2TextBox.Text = StringTrimmer(stringToBeTrimmed);

                commentCodeList.Remove(commentsTable[commentsTable.CurrentCell.ColumnIndex - 1, commentsTable.CurrentCell.RowIndex].Value.ToString());

                commentsTable.CurrentCell.Style.BackColor = System.Drawing.Color.White;
                commentsTable[commentsTable.CurrentCell.ColumnIndex - 1, commentsTable.CurrentCell.RowIndex].Style.BackColor = System.Drawing.Color.White;
            }
        }
        public void RemoveCommentFromSection3()
        {

            if (commentsTable.CurrentCell.ColumnIndex == 0)
            {
                String removalString;
                String stringToBeTrimmed;
                removalString = String.Concat(commentsTable.CurrentCell.Value.ToString(), " - ", commentsTable[commentsTable.CurrentCell.ColumnIndex + 1, commentsTable.CurrentCell.RowIndex].Value.ToString());
                stringToBeTrimmed = section3TextBox.Text.Replace(removalString, "");
                section3TextBox.Text = StringTrimmer(stringToBeTrimmed);

                commentCodeList.Remove(commentsTable.CurrentCell.Value.ToString());

                commentsTable.CurrentCell.Style.BackColor = System.Drawing.Color.White;
                commentsTable[commentsTable.CurrentCell.ColumnIndex + 1, commentsTable.CurrentCell.RowIndex].Style.BackColor = System.Drawing.Color.White;
            }
            else
            {
                String removalString;
                String stringToBeTrimmed;
                removalString = String.Concat(commentsTable[commentsTable.CurrentCell.ColumnIndex - 1, commentsTable.CurrentCell.RowIndex].Value.ToString(), " - ", commentsTable.CurrentCell.Value.ToString());
                stringToBeTrimmed = section3TextBox.Text.Replace(removalString, "");
                section3TextBox.Text = StringTrimmer(stringToBeTrimmed);

                commentCodeList.Remove(commentsTable[commentsTable.CurrentCell.ColumnIndex - 1, commentsTable.CurrentCell.RowIndex].Value.ToString());

                commentsTable.CurrentCell.Style.BackColor = System.Drawing.Color.White;
                commentsTable[commentsTable.CurrentCell.ColumnIndex - 1, commentsTable.CurrentCell.RowIndex].Style.BackColor = System.Drawing.Color.White;
            }
        }
        public void RemoveCommentFromSection4()
        {

            if (commentsTable.CurrentCell.ColumnIndex == 0)
            {
                String removalString;
                String stringToBeTrimmed;
                removalString = String.Concat(commentsTable.CurrentCell.Value.ToString(), " - ", commentsTable[commentsTable.CurrentCell.ColumnIndex + 1, commentsTable.CurrentCell.RowIndex].Value.ToString());
                stringToBeTrimmed = section4TextBox.Text.Replace(removalString, "");
                section4TextBox.Text = StringTrimmer(stringToBeTrimmed);

                commentCodeList.Remove(commentsTable.CurrentCell.Value.ToString());

                commentsTable.CurrentCell.Style.BackColor = System.Drawing.Color.White;
                commentsTable[commentsTable.CurrentCell.ColumnIndex + 1, commentsTable.CurrentCell.RowIndex].Style.BackColor = System.Drawing.Color.White;
            }
            else
            {
                String removalString;
                String stringToBeTrimmed;
                removalString = String.Concat(commentsTable[commentsTable.CurrentCell.ColumnIndex - 1, commentsTable.CurrentCell.RowIndex].Value.ToString(), " - ", commentsTable.CurrentCell.Value.ToString());
                stringToBeTrimmed = section4TextBox.Text.Replace(removalString, "");
                section4TextBox.Text = StringTrimmer(stringToBeTrimmed);

                commentCodeList.Remove(commentsTable[commentsTable.CurrentCell.ColumnIndex - 1, commentsTable.CurrentCell.RowIndex].Value.ToString());

                commentsTable.CurrentCell.Style.BackColor = System.Drawing.Color.White;
                commentsTable[commentsTable.CurrentCell.ColumnIndex - 1, commentsTable.CurrentCell.RowIndex].Style.BackColor = System.Drawing.Color.White;
            }
        }

        public String StringTrimmer(String stringToTrim)
        {
            String finalString = null;
            char[] spearator = { '\n' };
            String[] strList = stringToTrim.Split(spearator, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < strList.Length; i++)
            {
                strList[i] = strList[i].Trim();
            }

            for (int i = 0; i < strList.Length; i++)
            {
                if (finalString != null)
                {
                    finalString = String.Concat(finalString, "\n", strList[i]);
                }

                else
                {
                    finalString = String.Concat(strList[i], finalString);
                }
            }
            return finalString;
        }

        private void commentsTable_DataSourceChanged(object sender, EventArgs e)
        {
            for(int i=0; i<commentCodeList.Count; i++)
            {
                for(int j=0; j<commentsTable.Rows.Count; j++)
                {
                    if(commentCodeList[i] == commentsTable[0,j].Value.ToString())
                    {
                        commentsTable[0, j].Style.BackColor = System.Drawing.Color.Aquamarine;
                        commentsTable[1, j].Style.BackColor = System.Drawing.Color.Aquamarine;
                        break;
                    }
                }
            }
        }
    }
}

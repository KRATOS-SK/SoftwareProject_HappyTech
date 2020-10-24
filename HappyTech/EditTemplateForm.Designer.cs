namespace HappyTech
{
    partial class EditTemplateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.section1TextBox = new System.Windows.Forms.RichTextBox();
            this.section2TextBox = new System.Windows.Forms.RichTextBox();
            this.section3TextBox = new System.Windows.Forms.RichTextBox();
            this.section4TextBox = new System.Windows.Forms.RichTextBox();
            this.commentsTable = new System.Windows.Forms.DataGridView();
            this.saveAndUseButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveTemplateButton = new System.Windows.Forms.Button();
            this.commentSectionSelection = new System.Windows.Forms.ComboBox();
            this.templateTypeLabel = new System.Windows.Forms.Label();
            this.reviewerName = new System.Windows.Forms.Label();
            this.dateOnTemplate = new System.Windows.Forms.Label();
            this.jobsList = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.commentsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // section1TextBox
            // 
            this.section1TextBox.Location = new System.Drawing.Point(36, 163);
            this.section1TextBox.Name = "section1TextBox";
            this.section1TextBox.ReadOnly = true;
            this.section1TextBox.Size = new System.Drawing.Size(760, 106);
            this.section1TextBox.TabIndex = 0;
            this.section1TextBox.Text = "";
            // 
            // section2TextBox
            // 
            this.section2TextBox.Location = new System.Drawing.Point(36, 293);
            this.section2TextBox.Name = "section2TextBox";
            this.section2TextBox.ReadOnly = true;
            this.section2TextBox.Size = new System.Drawing.Size(760, 106);
            this.section2TextBox.TabIndex = 1;
            this.section2TextBox.Text = "";
            // 
            // section3TextBox
            // 
            this.section3TextBox.Location = new System.Drawing.Point(36, 423);
            this.section3TextBox.Name = "section3TextBox";
            this.section3TextBox.ReadOnly = true;
            this.section3TextBox.Size = new System.Drawing.Size(760, 106);
            this.section3TextBox.TabIndex = 2;
            this.section3TextBox.Text = "";
            // 
            // section4TextBox
            // 
            this.section4TextBox.Location = new System.Drawing.Point(36, 551);
            this.section4TextBox.Name = "section4TextBox";
            this.section4TextBox.ReadOnly = true;
            this.section4TextBox.Size = new System.Drawing.Size(760, 106);
            this.section4TextBox.TabIndex = 3;
            this.section4TextBox.Text = "";
            // 
            // commentsTable
            // 
            this.commentsTable.AllowUserToAddRows = false;
            this.commentsTable.AllowUserToDeleteRows = false;
            this.commentsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.commentsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.commentsTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.commentsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.commentsTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.commentsTable.Location = new System.Drawing.Point(802, 193);
            this.commentsTable.MultiSelect = false;
            this.commentsTable.Name = "commentsTable";
            this.commentsTable.ReadOnly = true;
            this.commentsTable.RowHeadersVisible = false;
            this.commentsTable.Size = new System.Drawing.Size(944, 424);
            this.commentsTable.TabIndex = 4;
            // 
            // saveAndUseButton
            // 
            this.saveAndUseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveAndUseButton.Location = new System.Drawing.Point(1363, 623);
            this.saveAndUseButton.Name = "saveAndUseButton";
            this.saveAndUseButton.Size = new System.Drawing.Size(125, 44);
            this.saveAndUseButton.TabIndex = 5;
            this.saveAndUseButton.Text = "Save And Use";
            this.saveAndUseButton.UseVisualStyleBackColor = true;
            this.saveAndUseButton.Click += new System.EventHandler(this.saveAndUseButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(1621, 623);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(125, 44);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveTemplateButton
            // 
            this.saveTemplateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveTemplateButton.Location = new System.Drawing.Point(1492, 623);
            this.saveTemplateButton.Name = "saveTemplateButton";
            this.saveTemplateButton.Size = new System.Drawing.Size(125, 44);
            this.saveTemplateButton.TabIndex = 7;
            this.saveTemplateButton.Text = "Save Template";
            this.saveTemplateButton.UseVisualStyleBackColor = true;
            this.saveTemplateButton.Click += new System.EventHandler(this.saveTemplateButton_Click);
            // 
            // commentSectionSelection
            // 
            this.commentSectionSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.commentSectionSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.commentSectionSelection.FormattingEnabled = true;
            this.commentSectionSelection.Items.AddRange(new object[] {
            "All Comments",
            "Section 1 Comments",
            "Section 2 Comments",
            "Section 3 Comments",
            "Section 4 Comments"});
            this.commentSectionSelection.Location = new System.Drawing.Point(1526, 163);
            this.commentSectionSelection.Name = "commentSectionSelection";
            this.commentSectionSelection.Size = new System.Drawing.Size(219, 21);
            this.commentSectionSelection.TabIndex = 8;
            this.commentSectionSelection.SelectedIndexChanged += new System.EventHandler(this.commentSectionSelection_SelectedIndexChanged);
            // 
            // templateTypeLabel
            // 
            this.templateTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.templateTypeLabel.AutoSize = true;
            this.templateTypeLabel.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.templateTypeLabel.Location = new System.Drawing.Point(657, 26);
            this.templateTypeLabel.Name = "templateTypeLabel";
            this.templateTypeLabel.Size = new System.Drawing.Size(490, 78);
            this.templateTypeLabel.TabIndex = 9;
            this.templateTypeLabel.Text = "Template Type";
            this.templateTypeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // reviewerName
            // 
            this.reviewerName.AutoSize = true;
            this.reviewerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewerName.Location = new System.Drawing.Point(1522, 53);
            this.reviewerName.Name = "reviewerName";
            this.reviewerName.Size = new System.Drawing.Size(125, 24);
            this.reviewerName.TabIndex = 10;
            this.reviewerName.Text = "Reviewed By,";
            // 
            // dateOnTemplate
            // 
            this.dateOnTemplate.AutoSize = true;
            this.dateOnTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOnTemplate.Location = new System.Drawing.Point(1522, 88);
            this.dateOnTemplate.Name = "dateOnTemplate";
            this.dateOnTemplate.Size = new System.Drawing.Size(53, 24);
            this.dateOnTemplate.TabIndex = 11;
            this.dateOnTemplate.Text = "Date:";
            // 
            // jobsList
            // 
            this.jobsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jobsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobsList.FormattingEnabled = true;
            this.jobsList.Location = new System.Drawing.Point(36, 109);
            this.jobsList.Name = "jobsList";
            this.jobsList.Size = new System.Drawing.Size(219, 33);
            this.jobsList.TabIndex = 12;
            // 
            // CreateOrEditTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1769, 808);
            this.Controls.Add(this.jobsList);
            this.Controls.Add(this.dateOnTemplate);
            this.Controls.Add(this.reviewerName);
            this.Controls.Add(this.templateTypeLabel);
            this.Controls.Add(this.commentSectionSelection);
            this.Controls.Add(this.saveTemplateButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveAndUseButton);
            this.Controls.Add(this.commentsTable);
            this.Controls.Add(this.section4TextBox);
            this.Controls.Add(this.section3TextBox);
            this.Controls.Add(this.section2TextBox);
            this.Controls.Add(this.section1TextBox);
            this.Icon = global::HappyTech.Properties.Resources.logoIcon;
            this.Name = "CreateOrEditTemplate";
            this.Text = "Create/Edit Template";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CreateOrEditTemplate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.commentsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox section1TextBox;
        private System.Windows.Forms.RichTextBox section2TextBox;
        private System.Windows.Forms.RichTextBox section3TextBox;
        private System.Windows.Forms.RichTextBox section4TextBox;
        private System.Windows.Forms.DataGridView commentsTable;
        private System.Windows.Forms.Button saveAndUseButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveTemplateButton;
        private System.Windows.Forms.ComboBox commentSectionSelection;
        private System.Windows.Forms.Label templateTypeLabel;
        private System.Windows.Forms.Label reviewerName;
        private System.Windows.Forms.Label dateOnTemplate;
        private System.Windows.Forms.ComboBox jobsList;
    }
}
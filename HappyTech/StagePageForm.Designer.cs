namespace HappyTech
{
    partial class StagePageForm
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
            this.cvTemplatePage = new System.Windows.Forms.Button();
            this.onlineTestTemplatePage = new System.Windows.Forms.Button();
            this.interviewTemplatePage = new System.Windows.Forms.Button();
            this.reviewerName = new System.Windows.Forms.Label();
            this.greetingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cvTemplatePage
            // 
            this.cvTemplatePage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cvTemplatePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cvTemplatePage.Location = new System.Drawing.Point(216, 55);
            this.cvTemplatePage.Name = "cvTemplatePage";
            this.cvTemplatePage.Size = new System.Drawing.Size(379, 127);
            this.cvTemplatePage.TabIndex = 0;
            this.cvTemplatePage.Text = "CV Templates";
            this.cvTemplatePage.UseVisualStyleBackColor = true;
            this.cvTemplatePage.Click += new System.EventHandler(this.cvTemplatePage_Click);
            // 
            // onlineTestTemplatePage
            // 
            this.onlineTestTemplatePage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.onlineTestTemplatePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlineTestTemplatePage.Location = new System.Drawing.Point(216, 221);
            this.onlineTestTemplatePage.Name = "onlineTestTemplatePage";
            this.onlineTestTemplatePage.Size = new System.Drawing.Size(379, 127);
            this.onlineTestTemplatePage.TabIndex = 1;
            this.onlineTestTemplatePage.Text = "Online Test Templates";
            this.onlineTestTemplatePage.UseVisualStyleBackColor = true;
            this.onlineTestTemplatePage.Click += new System.EventHandler(this.onlineTestTemplatePage_Click);
            // 
            // interviewTemplatePage
            // 
            this.interviewTemplatePage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.interviewTemplatePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interviewTemplatePage.Location = new System.Drawing.Point(216, 394);
            this.interviewTemplatePage.Name = "interviewTemplatePage";
            this.interviewTemplatePage.Size = new System.Drawing.Size(379, 127);
            this.interviewTemplatePage.TabIndex = 2;
            this.interviewTemplatePage.Text = "Interview Templates";
            this.interviewTemplatePage.UseVisualStyleBackColor = true;
            this.interviewTemplatePage.Click += new System.EventHandler(this.interviewTemplatePage_Click);
            // 
            // reviewerName
            // 
            this.reviewerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reviewerName.AutoSize = true;
            this.reviewerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewerName.Location = new System.Drawing.Point(775, 15);
            this.reviewerName.Name = "reviewerName";
            this.reviewerName.Size = new System.Drawing.Size(109, 20);
            this.reviewerName.TabIndex = 3;
            this.reviewerName.Text = "reviewerName";
            // 
            // greetingLabel
            // 
            this.greetingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.greetingLabel.AutoSize = true;
            this.greetingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetingLabel.Location = new System.Drawing.Point(730, 15);
            this.greetingLabel.Name = "greetingLabel";
            this.greetingLabel.Size = new System.Drawing.Size(49, 20);
            this.greetingLabel.TabIndex = 4;
            this.greetingLabel.Text = "Hello,";
            // 
            // StagePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 560);
            this.Controls.Add(this.greetingLabel);
            this.Controls.Add(this.reviewerName);
            this.Controls.Add(this.interviewTemplatePage);
            this.Controls.Add(this.onlineTestTemplatePage);
            this.Controls.Add(this.cvTemplatePage);
            this.Icon = global::HappyTech.Properties.Resources.logoIcon;
            this.Name = "StagePageForm";
            this.Text = "Stage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StagePageForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cvTemplatePage;
        private System.Windows.Forms.Button onlineTestTemplatePage;
        private System.Windows.Forms.Button interviewTemplatePage;
        private System.Windows.Forms.Label reviewerName;
        private System.Windows.Forms.Label greetingLabel;
    }
}
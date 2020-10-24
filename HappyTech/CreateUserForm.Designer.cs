namespace HappyTech
{
    partial class CreateUserForm
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
            this.userID = new System.Windows.Forms.TextBox();
            this.NameOfUser = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.confirmPassword = new System.Windows.Forms.TextBox();
            this.logoDisplay = new System.Windows.Forms.PictureBox();
            this.confirmUserInfo = new System.Windows.Forms.Button();
            this.userIDLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // userID
            // 
            this.userID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userID.Location = new System.Drawing.Point(458, 359);
            this.userID.Name = "userID";
            this.userID.Size = new System.Drawing.Size(259, 29);
            this.userID.TabIndex = 0;
            // 
            // NameOfUser
            // 
            this.NameOfUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NameOfUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameOfUser.Location = new System.Drawing.Point(458, 411);
            this.NameOfUser.Name = "NameOfUser";
            this.NameOfUser.Size = new System.Drawing.Size(259, 29);
            this.NameOfUser.TabIndex = 1;
            // 
            // Password
            // 
            this.Password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(458, 463);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(259, 29);
            this.Password.TabIndex = 2;
            // 
            // confirmPassword
            // 
            this.confirmPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.confirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassword.Location = new System.Drawing.Point(458, 516);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(259, 29);
            this.confirmPassword.TabIndex = 3;
            // 
            // logoDisplay
            // 
            this.logoDisplay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logoDisplay.Location = new System.Drawing.Point(414, 12);
            this.logoDisplay.Name = "logoDisplay";
            this.logoDisplay.Size = new System.Drawing.Size(355, 320);
            this.logoDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoDisplay.TabIndex = 1;
            this.logoDisplay.TabStop = false;
            // 
            // confirmUserInfo
            // 
            this.confirmUserInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.confirmUserInfo.Location = new System.Drawing.Point(505, 570);
            this.confirmUserInfo.Name = "confirmUserInfo";
            this.confirmUserInfo.Size = new System.Drawing.Size(164, 42);
            this.confirmUserInfo.TabIndex = 4;
            this.confirmUserInfo.Text = "Create User";
            this.confirmUserInfo.UseVisualStyleBackColor = true;
            this.confirmUserInfo.Click += new System.EventHandler(this.confirmUserInfo_Click);
            // 
            // userIDLabel
            // 
            this.userIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userIDLabel.AutoSize = true;
            this.userIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIDLabel.Location = new System.Drawing.Point(372, 362);
            this.userIDLabel.Name = "userIDLabel";
            this.userIDLabel.Size = new System.Drawing.Size(76, 24);
            this.userIDLabel.TabIndex = 5;
            this.userIDLabel.Text = "User ID:";
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(383, 413);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(66, 24);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Name:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(353, 465);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(97, 24);
            this.passwordLabel.TabIndex = 7;
            this.passwordLabel.Text = "Password:";
            this.passwordLabel.UseMnemonic = false;
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordLabel.Location = new System.Drawing.Point(285, 517);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(167, 24);
            this.confirmPasswordLabel.TabIndex = 8;
            this.confirmPasswordLabel.Text = "Confirm Password:";
            // 
            // CreateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 699);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.userIDLabel);
            this.Controls.Add(this.confirmUserInfo);
            this.Controls.Add(this.logoDisplay);
            this.Controls.Add(this.confirmPassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.NameOfUser);
            this.Controls.Add(this.userID);
            this.Icon = global::HappyTech.Properties.Resources.logoIcon;
            this.Name = "CreateUserForm";
            this.Text = "Create User";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CreateUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    
        private System.Windows.Forms.TextBox userID;
        private System.Windows.Forms.TextBox NameOfUser;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox confirmPassword;
        private System.Windows.Forms.PictureBox logoDisplay;
        private System.Windows.Forms.Button confirmUserInfo;
        private System.Windows.Forms.Label userIDLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label confirmPasswordLabel;
    }
}
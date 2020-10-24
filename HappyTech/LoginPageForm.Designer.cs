namespace HappyTech
{
    partial class LoginPageForm
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
            this.logoDisplay = new System.Windows.Forms.PictureBox();
            this.userId = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.loginSubmit = new System.Windows.Forms.Button();
            this.createUserLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.logoDisplay)).BeginInit();
            this.SuspendLayout();
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
            // userId
            // 
            this.userId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userId.Location = new System.Drawing.Point(485, 363);
            this.userId.Name = "userId";
            this.userId.Size = new System.Drawing.Size(219, 29);
            this.userId.TabIndex = 2;
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(485, 407);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(219, 29);
            this.password.TabIndex = 3;
            // 
            // loginSubmit
            // 
            this.loginSubmit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loginSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginSubmit.Location = new System.Drawing.Point(553, 452);
            this.loginSubmit.Name = "loginSubmit";
            this.loginSubmit.Size = new System.Drawing.Size(86, 32);
            this.loginSubmit.TabIndex = 4;
            this.loginSubmit.Text = "Login";
            this.loginSubmit.UseVisualStyleBackColor = true;
            this.loginSubmit.Click += new System.EventHandler(this.loginSubmit_Click);
            // 
            // createUserLabel
            // 
            this.createUserLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.createUserLabel.AutoSize = true;
            this.createUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUserLabel.Location = new System.Drawing.Point(518, 509);
            this.createUserLabel.Name = "createUserLabel";
            this.createUserLabel.Size = new System.Drawing.Size(159, 18);
            this.createUserLabel.TabIndex = 5;
            this.createUserLabel.TabStop = true;
            this.createUserLabel.Text = "New User? Click Here.";
            this.createUserLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createUserLabel_LinkClicked);
            // 
            // LoginPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 552);
            this.Controls.Add(this.createUserLabel);
            this.Controls.Add(this.loginSubmit);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userId);
            this.Controls.Add(this.logoDisplay);
            this.Icon = global::HappyTech.Properties.Resources.logoIcon;
            this.Name = "LoginPageForm";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LoginPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoDisplay;
        private System.Windows.Forms.TextBox userId;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button loginSubmit;
        private System.Windows.Forms.LinkLabel createUserLabel;
    }
}


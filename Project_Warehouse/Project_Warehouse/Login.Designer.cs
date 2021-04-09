namespace Project_Warehouse
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.gbxLogin = new System.Windows.Forms.GroupBox();
            this.panLogin = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.cbxRememberMe = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.lbPassword = new System.Windows.Forms.Label();
            this.panLock = new System.Windows.Forms.Panel();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lnkChangepass = new System.Windows.Forms.LinkLabel();
            this.lbLogin = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panCopyright2 = new System.Windows.Forms.Panel();
            this.lbCopyright = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTitle1 = new System.Windows.Forms.Label();
            this.Minimizebtn = new System.Windows.Forms.Button();
            this.gbxLogin.SuspendLayout();
            this.panLogin.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panCopyright2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxLogin
            // 
            this.gbxLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxLogin.BackColor = System.Drawing.Color.Transparent;
            this.gbxLogin.Controls.Add(this.panLogin);
            this.gbxLogin.Controls.Add(this.lbLogin);
            this.gbxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxLogin.Location = new System.Drawing.Point(93, 78);
            this.gbxLogin.Name = "gbxLogin";
            this.gbxLogin.Size = new System.Drawing.Size(342, 207);
            this.gbxLogin.TabIndex = 6;
            this.gbxLogin.TabStop = false;
            // 
            // panLogin
            // 
            this.panLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panLogin.BackColor = System.Drawing.Color.Transparent;
            this.panLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panLogin.Controls.Add(this.txtUsername);
            this.panLogin.Controls.Add(this.cbxRememberMe);
            this.panLogin.Controls.Add(this.txtPassword);
            this.panLogin.Controls.Add(this.loginbtn);
            this.panLogin.Controls.Add(this.lbPassword);
            this.panLogin.Controls.Add(this.panLock);
            this.panLogin.Controls.Add(this.lbUsername);
            this.panLogin.Controls.Add(this.lnkChangepass);
            this.panLogin.Location = new System.Drawing.Point(12, 20);
            this.panLogin.Name = "panLogin";
            this.panLogin.Size = new System.Drawing.Size(318, 178);
            this.panLogin.TabIndex = 2;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtUsername.Location = new System.Drawing.Point(18, 39);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(281, 22);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.Text = "Enter your username";
            this.txtUsername.Click += new System.EventHandler(this.txtUsername_Click);
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // cbxRememberMe
            // 
            this.cbxRememberMe.AutoSize = true;
            this.cbxRememberMe.BackColor = System.Drawing.Color.Silver;
            this.cbxRememberMe.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRememberMe.Location = new System.Drawing.Point(88, 151);
            this.cbxRememberMe.Name = "cbxRememberMe";
            this.cbxRememberMe.Size = new System.Drawing.Size(108, 19);
            this.cbxRememberMe.TabIndex = 8;
            this.cbxRememberMe.Text = "Remember Me";
            this.cbxRememberMe.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtPassword.Location = new System.Drawing.Point(18, 87);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(281, 22);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "Enter Password";
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.loginbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginbtn.BackgroundImage")));
            this.loginbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginbtn.FlatAppearance.BorderSize = 0;
            this.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginbtn.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginbtn.Location = new System.Drawing.Point(202, 139);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(97, 32);
            this.loginbtn.TabIndex = 0;
            this.loginbtn.Text = "Log in";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.BackColor = System.Drawing.Color.White;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(19, 68);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(75, 18);
            this.lbPassword.TabIndex = 2;
            this.lbPassword.Text = "Password";
            // 
            // panLock
            // 
            this.panLock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panLock.BackgroundImage")));
            this.panLock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panLock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panLock.Location = new System.Drawing.Point(18, 112);
            this.panLock.Name = "panLock";
            this.panLock.Size = new System.Drawing.Size(62, 59);
            this.panLock.TabIndex = 7;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.BackColor = System.Drawing.Color.White;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(16, 20);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(77, 18);
            this.lbUsername.TabIndex = 1;
            this.lbUsername.Text = "Username";
            // 
            // lnkChangepass
            // 
            this.lnkChangepass.AutoSize = true;
            this.lnkChangepass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkChangepass.LinkColor = System.Drawing.Color.DarkBlue;
            this.lnkChangepass.Location = new System.Drawing.Point(88, 118);
            this.lnkChangepass.Name = "lnkChangepass";
            this.lnkChangepass.Size = new System.Drawing.Size(199, 15);
            this.lnkChangepass.TabIndex = 6;
            this.lnkChangepass.TabStop = true;
            this.lnkChangepass.Text = "Change Username and Password?";
            this.lnkChangepass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkChangepass_LinkClicked);
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbLogin.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.Location = new System.Drawing.Point(148, 0);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(54, 17);
            this.lbLogin.TabIndex = 0;
            this.lbLogin.Text = "Sign in";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(522, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            this.exitToolStripMenuItem.MouseLeave += new System.EventHandler(this.exitToolStripMenuItem_MouseLeave);
            this.exitToolStripMenuItem.MouseHover += new System.EventHandler(this.exitToolStripMenuItem_MouseHover);
            // 
            // panCopyright2
            // 
            this.panCopyright2.BackColor = System.Drawing.Color.LightBlue;
            this.panCopyright2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panCopyright2.Controls.Add(this.lbCopyright);
            this.panCopyright2.Controls.Add(this.pictureBox1);
            this.panCopyright2.Location = new System.Drawing.Point(1, 349);
            this.panCopyright2.Name = "panCopyright2";
            this.panCopyright2.Size = new System.Drawing.Size(520, 30);
            this.panCopyright2.TabIndex = 8;
            // 
            // lbCopyright
            // 
            this.lbCopyright.AutoSize = true;
            this.lbCopyright.BackColor = System.Drawing.Color.LightBlue;
            this.lbCopyright.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lbCopyright.Location = new System.Drawing.Point(135, 8);
            this.lbCopyright.Name = "lbCopyright";
            this.lbCopyright.Size = new System.Drawing.Size(249, 13);
            this.lbCopyright.TabIndex = 6;
            this.lbCopyright.Text = "Copyright © 2020, Adeleke Idris. All rights reserved.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lbTitle1
            // 
            this.lbTitle1.AutoSize = true;
            this.lbTitle1.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTitle1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle1.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbTitle1.Location = new System.Drawing.Point(83, 26);
            this.lbTitle1.Name = "lbTitle1";
            this.lbTitle1.Size = new System.Drawing.Size(368, 34);
            this.lbTitle1.TabIndex = 9;
            this.lbTitle1.Text = "Student\'s Project Warehouse";
            // 
            // Minimizebtn
            // 
            this.Minimizebtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Minimizebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Minimizebtn.BackgroundImage")));
            this.Minimizebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Minimizebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Minimizebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimizebtn.Location = new System.Drawing.Point(482, 2);
            this.Minimizebtn.Name = "Minimizebtn";
            this.Minimizebtn.Size = new System.Drawing.Size(38, 21);
            this.Minimizebtn.TabIndex = 10;
            this.Minimizebtn.UseVisualStyleBackColor = false;
            this.Minimizebtn.Click += new System.EventHandler(this.Minimizebtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(522, 380);
            this.Controls.Add(this.Minimizebtn);
            this.Controls.Add(this.lbTitle1);
            this.Controls.Add(this.panCopyright2);
            this.Controls.Add(this.gbxLogin);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.gbxLogin.ResumeLayout(false);
            this.gbxLogin.PerformLayout();
            this.panLogin.ResumeLayout(false);
            this.panLogin.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panCopyright2.ResumeLayout(false);
            this.panCopyright2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxLogin;
        private System.Windows.Forms.Panel panLogin;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.CheckBox cbxRememberMe;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Panel panLock;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.LinkLabel lnkChangepass;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Panel panCopyright2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbCopyright;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lbTitle1;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Button Minimizebtn;
    }
}
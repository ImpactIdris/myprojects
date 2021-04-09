namespace Project_Warehouse
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LoadingBar = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbLoading = new System.Windows.Forms.Label();
            this.panLoad = new System.Windows.Forms.Panel();
            this.lbCopyright = new System.Windows.Forms.Label();
            this.panCopyright1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTitle1 = new System.Windows.Forms.Label();
            this.panLoad.SuspendLayout();
            this.panCopyright1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadingBar
            // 
            this.LoadingBar.BackColor = System.Drawing.Color.White;
            this.LoadingBar.ForeColor = System.Drawing.Color.Red;
            this.LoadingBar.Location = new System.Drawing.Point(3, 3);
            this.LoadingBar.Name = "LoadingBar";
            this.LoadingBar.Size = new System.Drawing.Size(514, 10);
            this.LoadingBar.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbLoading
            // 
            this.lbLoading.AutoSize = true;
            this.lbLoading.BackColor = System.Drawing.Color.Transparent;
            this.lbLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoading.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbLoading.Location = new System.Drawing.Point(428, -1);
            this.lbLoading.Name = "lbLoading";
            this.lbLoading.Size = new System.Drawing.Size(87, 15);
            this.lbLoading.TabIndex = 1;
            this.lbLoading.Text = " Loading . . .";
            // 
            // panLoad
            // 
            this.panLoad.BackColor = System.Drawing.Color.Azure;
            this.panLoad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panLoad.Controls.Add(this.lbLoading);
            this.panLoad.Controls.Add(this.LoadingBar);
            this.panLoad.Location = new System.Drawing.Point(-1, 330);
            this.panLoad.Name = "panLoad";
            this.panLoad.Size = new System.Drawing.Size(522, 18);
            this.panLoad.TabIndex = 2;
            // 
            // lbCopyright
            // 
            this.lbCopyright.AutoSize = true;
            this.lbCopyright.BackColor = System.Drawing.Color.LightBlue;
            this.lbCopyright.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lbCopyright.Location = new System.Drawing.Point(137, 358);
            this.lbCopyright.Name = "lbCopyright";
            this.lbCopyright.Size = new System.Drawing.Size(249, 13);
            this.lbCopyright.TabIndex = 3;
            this.lbCopyright.Text = "Copyright © 2020, Adeleke Idris. All rights reserved.";
            // 
            // panCopyright1
            // 
            this.panCopyright1.BackColor = System.Drawing.Color.LightBlue;
            this.panCopyright1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panCopyright1.Controls.Add(this.pictureBox1);
            this.panCopyright1.Location = new System.Drawing.Point(1, 349);
            this.panCopyright1.Name = "panCopyright1";
            this.panCopyright1.Size = new System.Drawing.Size(520, 30);
            this.panCopyright1.TabIndex = 4;
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
            this.lbTitle1.ForeColor = System.Drawing.Color.Ivory;
            this.lbTitle1.Location = new System.Drawing.Point(72, 28);
            this.lbTitle1.Name = "lbTitle1";
            this.lbTitle1.Size = new System.Drawing.Size(381, 34);
            this.lbTitle1.TabIndex = 5;
            this.lbTitle1.Text = "Electronic Project-Warehouse";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(522, 380);
            this.Controls.Add(this.lbTitle1);
            this.Controls.Add(this.lbCopyright);
            this.Controls.Add(this.panLoad);
            this.Controls.Add(this.panCopyright1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Warehouse";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panLoad.ResumeLayout(false);
            this.panLoad.PerformLayout();
            this.panCopyright1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar LoadingBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbLoading;
        private System.Windows.Forms.Panel panLoad;
        private System.Windows.Forms.Label lbCopyright;
        private System.Windows.Forms.Panel panCopyright1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbTitle1;
    }
}


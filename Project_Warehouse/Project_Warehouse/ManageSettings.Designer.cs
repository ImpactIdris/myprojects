namespace Project_Warehouse
{
    partial class ManageSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageSettings));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbManageSettings = new System.Windows.Forms.Label();
            this.btn_MsHome = new System.Windows.Forms.Button();
            this.gbxMS = new System.Windows.Forms.GroupBox();
            this.lbMsDepartment = new System.Windows.Forms.Label();
            this.lbMsProject = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTopic = new System.Windows.Forms.TextBox();
            this.dgvProjectTopic = new System.Windows.Forms.DataGridView();
            this.btnAddTopic = new System.Windows.Forms.Button();
            this.btnDelTopic = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.dgvDepartment = new System.Windows.Forms.DataGridView();
            this.btnAddDept = new System.Windows.Forms.Button();
            this.lbMsSupervisor = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSupervisor = new System.Windows.Forms.TextBox();
            this.dgvSupervisor = new System.Windows.Forms.DataGridView();
            this.btnAddSupervisor = new System.Windows.Forms.Button();
            this.btnDelSupervisor = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbxMS.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectTopic)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupervisor)).BeginInit();
            this.SuspendLayout();
            // 
            // lbManageSettings
            // 
            this.lbManageSettings.AutoSize = true;
            this.lbManageSettings.BackColor = System.Drawing.Color.DarkRed;
            this.lbManageSettings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbManageSettings.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbManageSettings.ForeColor = System.Drawing.Color.Snow;
            this.lbManageSettings.Location = new System.Drawing.Point(63, 17);
            this.lbManageSettings.Name = "lbManageSettings";
            this.lbManageSettings.Size = new System.Drawing.Size(225, 26);
            this.lbManageSettings.TabIndex = 4;
            this.lbManageSettings.Text = "MANAGE SETTINGS";
            // 
            // btn_MsHome
            // 
            this.btn_MsHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_MsHome.BackgroundImage")));
            this.btn_MsHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_MsHome.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_MsHome.Location = new System.Drawing.Point(10, 10);
            this.btn_MsHome.Name = "btn_MsHome";
            this.btn_MsHome.Size = new System.Drawing.Size(49, 39);
            this.btn_MsHome.TabIndex = 3;
            this.btn_MsHome.UseVisualStyleBackColor = true;
            this.btn_MsHome.Click += new System.EventHandler(this.btn_MsHome_Click);
            // 
            // gbxMS
            // 
            this.gbxMS.BackColor = System.Drawing.Color.Transparent;
            this.gbxMS.Controls.Add(this.lbMsDepartment);
            this.gbxMS.Controls.Add(this.lbMsProject);
            this.gbxMS.Controls.Add(this.panel4);
            this.gbxMS.Controls.Add(this.panel3);
            this.gbxMS.Controls.Add(this.lbMsSupervisor);
            this.gbxMS.Controls.Add(this.panel2);
            this.gbxMS.Location = new System.Drawing.Point(12, 61);
            this.gbxMS.Name = "gbxMS";
            this.gbxMS.Size = new System.Drawing.Size(945, 456);
            this.gbxMS.TabIndex = 5;
            this.gbxMS.TabStop = false;
            // 
            // lbMsDepartment
            // 
            this.lbMsDepartment.AutoSize = true;
            this.lbMsDepartment.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbMsDepartment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbMsDepartment.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMsDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbMsDepartment.Location = new System.Drawing.Point(736, 23);
            this.lbMsDepartment.Name = "lbMsDepartment";
            this.lbMsDepartment.Size = new System.Drawing.Size(127, 20);
            this.lbMsDepartment.TabIndex = 6;
            this.lbMsDepartment.Text = "DEPARTMENT";
            // 
            // lbMsProject
            // 
            this.lbMsProject.AutoSize = true;
            this.lbMsProject.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbMsProject.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbMsProject.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMsProject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbMsProject.Location = new System.Drawing.Point(402, 23);
            this.lbMsProject.Name = "lbMsProject";
            this.lbMsProject.Size = new System.Drawing.Size(140, 20);
            this.lbMsProject.TabIndex = 8;
            this.lbMsProject.Text = "PROJECT TOPIC";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.txtTopic);
            this.panel4.Controls.Add(this.dgvProjectTopic);
            this.panel4.Controls.Add(this.btnAddTopic);
            this.panel4.Controls.Add(this.btnDelTopic);
            this.panel4.Location = new System.Drawing.Point(273, 42);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(397, 399);
            this.panel4.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(146, 356);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(116, 36);
            this.panel1.TabIndex = 7;
            // 
            // txtTopic
            // 
            this.txtTopic.BackColor = System.Drawing.SystemColors.Control;
            this.txtTopic.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTopic.Location = new System.Drawing.Point(6, 327);
            this.txtTopic.Name = "txtTopic";
            this.txtTopic.Size = new System.Drawing.Size(382, 25);
            this.txtTopic.TabIndex = 6;
            // 
            // dgvProjectTopic
            // 
            this.dgvProjectTopic.AllowUserToResizeRows = false;
            this.dgvProjectTopic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProjectTopic.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProjectTopic.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProjectTopic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProjectTopic.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProjectTopic.EnableHeadersVisualStyles = false;
            this.dgvProjectTopic.Location = new System.Drawing.Point(6, 6);
            this.dgvProjectTopic.Name = "dgvProjectTopic";
            this.dgvProjectTopic.ReadOnly = true;
            this.dgvProjectTopic.RowHeadersVisible = false;
            this.dgvProjectTopic.Size = new System.Drawing.Size(382, 318);
            this.dgvProjectTopic.TabIndex = 4;
            // 
            // btnAddTopic
            // 
            this.btnAddTopic.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddTopic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddTopic.BackgroundImage")));
            this.btnAddTopic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddTopic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddTopic.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTopic.Location = new System.Drawing.Point(6, 356);
            this.btnAddTopic.Name = "btnAddTopic";
            this.btnAddTopic.Size = new System.Drawing.Size(138, 36);
            this.btnAddTopic.TabIndex = 3;
            this.btnAddTopic.UseVisualStyleBackColor = false;
            this.btnAddTopic.Click += new System.EventHandler(this.btnAddTopic_Click);
            // 
            // btnDelTopic
            // 
            this.btnDelTopic.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelTopic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelTopic.BackgroundImage")));
            this.btnDelTopic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelTopic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelTopic.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelTopic.Location = new System.Drawing.Point(264, 356);
            this.btnDelTopic.Name = "btnDelTopic";
            this.btnDelTopic.Size = new System.Drawing.Size(124, 36);
            this.btnDelTopic.TabIndex = 1;
            this.btnDelTopic.UseVisualStyleBackColor = false;
            this.btnDelTopic.Click += new System.EventHandler(this.btnDelTopic_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtDepartment);
            this.panel3.Controls.Add(this.dgvDepartment);
            this.panel3.Controls.Add(this.btnAddDept);
            this.panel3.Location = new System.Drawing.Point(668, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(266, 399);
            this.panel3.TabIndex = 7;
            // 
            // txtDepartment
            // 
            this.txtDepartment.BackColor = System.Drawing.SystemColors.Control;
            this.txtDepartment.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartment.Location = new System.Drawing.Point(7, 327);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(250, 25);
            this.txtDepartment.TabIndex = 6;
            // 
            // dgvDepartment
            // 
            this.dgvDepartment.AllowUserToResizeRows = false;
            this.dgvDepartment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepartment.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDepartment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDepartment.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDepartment.EnableHeadersVisualStyles = false;
            this.dgvDepartment.Location = new System.Drawing.Point(7, 6);
            this.dgvDepartment.Name = "dgvDepartment";
            this.dgvDepartment.ReadOnly = true;
            this.dgvDepartment.RowHeadersVisible = false;
            this.dgvDepartment.Size = new System.Drawing.Size(250, 318);
            this.dgvDepartment.TabIndex = 4;
            // 
            // btnAddDept
            // 
            this.btnAddDept.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddDept.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddDept.BackgroundImage")));
            this.btnAddDept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddDept.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddDept.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDept.Location = new System.Drawing.Point(7, 356);
            this.btnAddDept.Name = "btnAddDept";
            this.btnAddDept.Size = new System.Drawing.Size(250, 36);
            this.btnAddDept.TabIndex = 3;
            this.btnAddDept.UseVisualStyleBackColor = false;
            this.btnAddDept.Click += new System.EventHandler(this.btnAddDept_Click);
            // 
            // lbMsSupervisor
            // 
            this.lbMsSupervisor.AutoSize = true;
            this.lbMsSupervisor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbMsSupervisor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbMsSupervisor.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMsSupervisor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbMsSupervisor.Location = new System.Drawing.Point(83, 23);
            this.lbMsSupervisor.Name = "lbMsSupervisor";
            this.lbMsSupervisor.Size = new System.Drawing.Size(115, 20);
            this.lbMsSupervisor.TabIndex = 0;
            this.lbMsSupervisor.Text = "SUPERVISOR";
            this.toolTip1.SetToolTip(this.lbMsSupervisor, "Click to reload data");
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtSupervisor);
            this.panel2.Controls.Add(this.dgvSupervisor);
            this.panel2.Controls.Add(this.btnAddSupervisor);
            this.panel2.Controls.Add(this.btnDelSupervisor);
            this.panel2.Location = new System.Drawing.Point(10, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 399);
            this.panel2.TabIndex = 5;
            // 
            // txtSupervisor
            // 
            this.txtSupervisor.BackColor = System.Drawing.SystemColors.Control;
            this.txtSupervisor.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupervisor.Location = new System.Drawing.Point(6, 327);
            this.txtSupervisor.Name = "txtSupervisor";
            this.txtSupervisor.Size = new System.Drawing.Size(250, 25);
            this.txtSupervisor.TabIndex = 6;
            // 
            // dgvSupervisor
            // 
            this.dgvSupervisor.AllowUserToResizeRows = false;
            this.dgvSupervisor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSupervisor.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSupervisor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSupervisor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSupervisor.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSupervisor.EnableHeadersVisualStyles = false;
            this.dgvSupervisor.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvSupervisor.Location = new System.Drawing.Point(6, 6);
            this.dgvSupervisor.Name = "dgvSupervisor";
            this.dgvSupervisor.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSupervisor.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSupervisor.RowHeadersVisible = false;
            this.dgvSupervisor.Size = new System.Drawing.Size(250, 318);
            this.dgvSupervisor.TabIndex = 4;
            // 
            // btnAddSupervisor
            // 
            this.btnAddSupervisor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddSupervisor.BackgroundImage")));
            this.btnAddSupervisor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddSupervisor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddSupervisor.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSupervisor.Location = new System.Drawing.Point(7, 356);
            this.btnAddSupervisor.Name = "btnAddSupervisor";
            this.btnAddSupervisor.Size = new System.Drawing.Size(130, 36);
            this.btnAddSupervisor.TabIndex = 3;
            this.btnAddSupervisor.UseVisualStyleBackColor = true;
            this.btnAddSupervisor.Click += new System.EventHandler(this.btnAddSupervisor_Click);
            // 
            // btnDelSupervisor
            // 
            this.btnDelSupervisor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelSupervisor.BackgroundImage")));
            this.btnDelSupervisor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelSupervisor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelSupervisor.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelSupervisor.Location = new System.Drawing.Point(140, 356);
            this.btnDelSupervisor.Name = "btnDelSupervisor";
            this.btnDelSupervisor.Size = new System.Drawing.Size(116, 36);
            this.btnDelSupervisor.TabIndex = 1;
            this.btnDelSupervisor.UseVisualStyleBackColor = true;
            this.btnDelSupervisor.Click += new System.EventHandler(this.btnDelSupervisor_Click);
            // 
            // ManageSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(969, 652);
            this.Controls.Add(this.gbxMS);
            this.Controls.Add(this.lbManageSettings);
            this.Controls.Add(this.btn_MsHome);
            this.Name = "ManageSettings";
            this.Text = "ManageSettings";
            this.Shown += new System.EventHandler(this.ManageSettings_Shown);
            this.gbxMS.ResumeLayout(false);
            this.gbxMS.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectTopic)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupervisor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbManageSettings;
        private System.Windows.Forms.Button btn_MsHome;
        private System.Windows.Forms.GroupBox gbxMS;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvSupervisor;
        private System.Windows.Forms.Button btnAddSupervisor;
        private System.Windows.Forms.Button btnDelSupervisor;
        private System.Windows.Forms.Label lbMsSupervisor;
        private System.Windows.Forms.TextBox txtSupervisor;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtTopic;
        private System.Windows.Forms.DataGridView dgvProjectTopic;
        private System.Windows.Forms.Button btnAddTopic;
        private System.Windows.Forms.Button btnDelTopic;
        private System.Windows.Forms.Label lbMsProject;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.DataGridView dgvDepartment;
        private System.Windows.Forms.Button btnAddDept;
        private System.Windows.Forms.Label lbMsDepartment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
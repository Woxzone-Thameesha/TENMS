namespace TENMS
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSubHeader = new System.Windows.Forms.Panel();
            this.btnProfile = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblProfile = new System.Windows.Forms.Label();
            this.btnSetting = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMainMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlMainMenu = new System.Windows.Forms.Panel();
            this.btnDashboard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPayroll = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLeave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAttendance = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEmployee = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHelp = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnClose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pnlMDI = new TENMS.MdiClientPanel();
            this.pnlSubHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMainMenu)).BeginInit();
            this.pnlMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(84)))), ((int)(((byte)(255)))));
            this.pnlHeader.Location = new System.Drawing.Point(0, 29);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1080, 10);
            this.pnlHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(37, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Smart Human Resource Management System";
            // 
            // pnlSubHeader
            // 
            this.pnlSubHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(124)))), ((int)(((byte)(255)))));
            this.pnlSubHeader.Controls.Add(this.btnProfile);
            this.pnlSubHeader.Controls.Add(this.lblProfile);
            this.pnlSubHeader.Controls.Add(this.btnSetting);
            this.pnlSubHeader.Controls.Add(this.btnMainMenu);
            this.pnlSubHeader.Location = new System.Drawing.Point(0, 40);
            this.pnlSubHeader.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlSubHeader.Name = "pnlSubHeader";
            this.pnlSubHeader.Size = new System.Drawing.Size(1080, 30);
            this.pnlSubHeader.TabIndex = 1;
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.ImageActive = null;
            this.btnProfile.Location = new System.Drawing.Point(705, 0);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(30, 30);
            this.btnProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnProfile.TabIndex = 12;
            this.btnProfile.TabStop = false;
            this.btnProfile.Zoom = 50;
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfile.ForeColor = System.Drawing.Color.White;
            this.lblProfile.Location = new System.Drawing.Point(741, 5);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(49, 16);
            this.lblProfile.TabIndex = 13;
            this.lblProfile.Text = "Admin";
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.Image = global::TENMS.Properties.Resources.Settings_32px;
            this.btnSetting.ImageActive = null;
            this.btnSetting.Location = new System.Drawing.Point(796, -4);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(30, 30);
            this.btnSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSetting.TabIndex = 11;
            this.btnSetting.TabStop = false;
            this.btnSetting.Zoom = 25;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMainMenu.Image = global::TENMS.Properties.Resources.Menu_64px;
            this.btnMainMenu.ImageActive = null;
            this.btnMainMenu.Location = new System.Drawing.Point(3, 0);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(30, 30);
            this.btnMainMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMainMenu.TabIndex = 10;
            this.btnMainMenu.TabStop = false;
            this.btnMainMenu.Zoom = 25;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // pnlMainMenu
            // 
            this.pnlMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(87)))), ((int)(((byte)(151)))));
            this.pnlMainMenu.Controls.Add(this.btnDashboard);
            this.pnlMainMenu.Controls.Add(this.btnPayroll);
            this.pnlMainMenu.Controls.Add(this.btnLeave);
            this.pnlMainMenu.Controls.Add(this.btnAttendance);
            this.pnlMainMenu.Controls.Add(this.btnEmployee);
            this.pnlMainMenu.Location = new System.Drawing.Point(0, 69);
            this.pnlMainMenu.Name = "pnlMainMenu";
            this.pnlMainMenu.Size = new System.Drawing.Size(195, 385);
            this.pnlMainMenu.TabIndex = 9;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(87)))), ((int)(((byte)(151)))));
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDashboard.BorderRadius = 0;
            this.btnDashboard.ButtonText = "        Dashboard";
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.DisabledColor = System.Drawing.Color.Gray;
            this.btnDashboard.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDashboard.Iconimage = global::TENMS.Properties.Resources.Dashboard_32px;
            this.btnDashboard.Iconimage_right = null;
            this.btnDashboard.Iconimage_right_Selected = null;
            this.btnDashboard.Iconimage_Selected = null;
            this.btnDashboard.IconMarginLeft = 10;
            this.btnDashboard.IconMarginRight = 0;
            this.btnDashboard.IconRightVisible = true;
            this.btnDashboard.IconRightZoom = 0D;
            this.btnDashboard.IconVisible = true;
            this.btnDashboard.IconZoom = 50D;
            this.btnDashboard.IsTab = false;
            this.btnDashboard.Location = new System.Drawing.Point(0, 24);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(9, 3, 9, 3);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(87)))), ((int)(((byte)(151)))));
            this.btnDashboard.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(124)))), ((int)(((byte)(255)))));
            this.btnDashboard.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDashboard.selected = false;
            this.btnDashboard.Size = new System.Drawing.Size(195, 36);
            this.btnDashboard.TabIndex = 4;
            this.btnDashboard.Text = "        Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Textcolor = System.Drawing.Color.White;
            this.btnDashboard.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnPayroll
            // 
            this.btnPayroll.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.btnPayroll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(87)))), ((int)(((byte)(151)))));
            this.btnPayroll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPayroll.BorderRadius = 0;
            this.btnPayroll.ButtonText = "        Payroll";
            this.btnPayroll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayroll.DisabledColor = System.Drawing.Color.Gray;
            this.btnPayroll.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPayroll.Iconimage = global::TENMS.Properties.Resources.Employee_64px1;
            this.btnPayroll.Iconimage_right = null;
            this.btnPayroll.Iconimage_right_Selected = null;
            this.btnPayroll.Iconimage_Selected = null;
            this.btnPayroll.IconMarginLeft = 10;
            this.btnPayroll.IconMarginRight = 0;
            this.btnPayroll.IconRightVisible = true;
            this.btnPayroll.IconRightZoom = 0D;
            this.btnPayroll.IconVisible = true;
            this.btnPayroll.IconZoom = 50D;
            this.btnPayroll.IsTab = false;
            this.btnPayroll.Location = new System.Drawing.Point(0, 192);
            this.btnPayroll.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.btnPayroll.Name = "btnPayroll";
            this.btnPayroll.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(87)))), ((int)(((byte)(151)))));
            this.btnPayroll.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(124)))), ((int)(((byte)(255)))));
            this.btnPayroll.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPayroll.selected = false;
            this.btnPayroll.Size = new System.Drawing.Size(195, 36);
            this.btnPayroll.TabIndex = 3;
            this.btnPayroll.Text = "        Payroll";
            this.btnPayroll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayroll.Textcolor = System.Drawing.Color.White;
            this.btnPayroll.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnLeave
            // 
            this.btnLeave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.btnLeave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(87)))), ((int)(((byte)(151)))));
            this.btnLeave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLeave.BorderRadius = 0;
            this.btnLeave.ButtonText = "        Leave";
            this.btnLeave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeave.DisabledColor = System.Drawing.Color.Gray;
            this.btnLeave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLeave.Iconimage = global::TENMS.Properties.Resources.Leave_48px;
            this.btnLeave.Iconimage_right = null;
            this.btnLeave.Iconimage_right_Selected = null;
            this.btnLeave.Iconimage_Selected = null;
            this.btnLeave.IconMarginLeft = 10;
            this.btnLeave.IconMarginRight = 0;
            this.btnLeave.IconRightVisible = true;
            this.btnLeave.IconRightZoom = 0D;
            this.btnLeave.IconVisible = true;
            this.btnLeave.IconZoom = 50D;
            this.btnLeave.IsTab = false;
            this.btnLeave.Location = new System.Drawing.Point(0, 150);
            this.btnLeave.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(87)))), ((int)(((byte)(151)))));
            this.btnLeave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(124)))), ((int)(((byte)(255)))));
            this.btnLeave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLeave.selected = false;
            this.btnLeave.Size = new System.Drawing.Size(195, 36);
            this.btnLeave.TabIndex = 2;
            this.btnLeave.Text = "        Leave";
            this.btnLeave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLeave.Textcolor = System.Drawing.Color.White;
            this.btnLeave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnAttendance
            // 
            this.btnAttendance.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.btnAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(87)))), ((int)(((byte)(151)))));
            this.btnAttendance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAttendance.BorderRadius = 0;
            this.btnAttendance.ButtonText = "        Attendance";
            this.btnAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAttendance.DisabledColor = System.Drawing.Color.Gray;
            this.btnAttendance.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAttendance.Iconimage = global::TENMS.Properties.Resources.Attendance_50px;
            this.btnAttendance.Iconimage_right = null;
            this.btnAttendance.Iconimage_right_Selected = null;
            this.btnAttendance.Iconimage_Selected = null;
            this.btnAttendance.IconMarginLeft = 10;
            this.btnAttendance.IconMarginRight = 0;
            this.btnAttendance.IconRightVisible = true;
            this.btnAttendance.IconRightZoom = 0D;
            this.btnAttendance.IconVisible = true;
            this.btnAttendance.IconZoom = 50D;
            this.btnAttendance.IsTab = false;
            this.btnAttendance.Location = new System.Drawing.Point(0, 66);
            this.btnAttendance.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(87)))), ((int)(((byte)(151)))));
            this.btnAttendance.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(124)))), ((int)(((byte)(255)))));
            this.btnAttendance.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAttendance.selected = false;
            this.btnAttendance.Size = new System.Drawing.Size(195, 36);
            this.btnAttendance.TabIndex = 1;
            this.btnAttendance.Text = "        Attendance";
            this.btnAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttendance.Textcolor = System.Drawing.Color.White;
            this.btnAttendance.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnEmployee
            // 
            this.btnEmployee.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.btnEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(87)))), ((int)(((byte)(151)))));
            this.btnEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmployee.BorderRadius = 0;
            this.btnEmployee.ButtonText = "        Employee";
            this.btnEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployee.DisabledColor = System.Drawing.Color.Gray;
            this.btnEmployee.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEmployee.Iconimage = global::TENMS.Properties.Resources.Employee_64px1;
            this.btnEmployee.Iconimage_right = null;
            this.btnEmployee.Iconimage_right_Selected = null;
            this.btnEmployee.Iconimage_Selected = null;
            this.btnEmployee.IconMarginLeft = 10;
            this.btnEmployee.IconMarginRight = 0;
            this.btnEmployee.IconRightVisible = true;
            this.btnEmployee.IconRightZoom = 0D;
            this.btnEmployee.IconVisible = true;
            this.btnEmployee.IconZoom = 50D;
            this.btnEmployee.IsTab = false;
            this.btnEmployee.Location = new System.Drawing.Point(0, 108);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(87)))), ((int)(((byte)(151)))));
            this.btnEmployee.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(124)))), ((int)(((byte)(255)))));
            this.btnEmployee.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEmployee.selected = false;
            this.btnEmployee.Size = new System.Drawing.Size(195, 36);
            this.btnEmployee.TabIndex = 0;
            this.btnEmployee.Text = "        Employee";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.Textcolor = System.Drawing.Color.White;
            this.btnEmployee.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.Image = global::TENMS.Properties.Resources.Help_48px;
            this.btnHelp.ImageActive = null;
            this.btnHelp.Location = new System.Drawing.Point(710, -5);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(25, 25);
            this.btnHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHelp.TabIndex = 11;
            this.btnHelp.TabStop = false;
            this.btnHelp.Zoom = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TENMS.Properties.Resources.Icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 23);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.ActiveBorderThickness = 1;
            this.btnMinimize.ActiveCornerRadius = 10;
            this.btnMinimize.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(84)))), ((int)(((byte)(255)))));
            this.btnMinimize.ActiveForecolor = System.Drawing.Color.White;
            this.btnMinimize.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(84)))), ((int)(((byte)(255)))));
            this.btnMinimize.BackColor = System.Drawing.SystemColors.Control;
            this.btnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.BackgroundImage")));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.ButtonText = "    0";
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Font = new System.Drawing.Font("Marlett", 15F, System.Drawing.FontStyle.Bold);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.IdleBorderThickness = 1;
            this.btnMinimize.IdleCornerRadius = 10;
            this.btnMinimize.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.btnMinimize.IdleForecolor = System.Drawing.Color.White;
            this.btnMinimize.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(84)))), ((int)(((byte)(255)))));
            this.btnMinimize.Location = new System.Drawing.Point(748, -34);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(42, 60);
            this.btnMinimize.TabIndex = 6;
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.ActiveBorderThickness = 1;
            this.btnClose.ActiveCornerRadius = 10;
            this.btnClose.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(19)))), ((int)(((byte)(26)))));
            this.btnClose.ActiveForecolor = System.Drawing.Color.White;
            this.btnClose.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(19)))), ((int)(((byte)(26)))));
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.ButtonText = "  r";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Marlett", 15F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.IdleBorderThickness = 1;
            this.btnClose.IdleCornerRadius = 10;
            this.btnClose.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.btnClose.IdleForecolor = System.Drawing.Color.White;
            this.btnClose.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(84)))), ((int)(((byte)(255)))));
            this.btnClose.Location = new System.Drawing.Point(792, -28);
            this.btnClose.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 54);
            this.btnClose.TabIndex = 5;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlMDI
            // 
            this.pnlMDI.Enabled = false;
            this.pnlMDI.Location = new System.Drawing.Point(229, 93);
            this.pnlMDI.Name = "pnlMDI";
            this.pnlMDI.Size = new System.Drawing.Size(268, 120);
            this.pnlMDI.TabIndex = 10;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 489);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.pnlMDI);
            this.Controls.Add(this.pnlMainMenu);
            this.Controls.Add(this.pnlSubHeader);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Marlett", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SHRM";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlSubHeader.ResumeLayout(false);
            this.pnlSubHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMainMenu)).EndInit();
            this.pnlMainMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClose;
        private Bunifu.Framework.UI.BunifuThinButton2 btnMinimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlSubHeader;
        private System.Windows.Forms.Panel pnlMainMenu;
        private Bunifu.Framework.UI.BunifuImageButton btnMainMenu;
        private Bunifu.Framework.UI.BunifuFlatButton btnEmployee;
        private Bunifu.Framework.UI.BunifuFlatButton btnAttendance;
        private Bunifu.Framework.UI.BunifuFlatButton btnPayroll;
        private Bunifu.Framework.UI.BunifuFlatButton btnLeave;
        private Bunifu.Framework.UI.BunifuFlatButton btnDashboard;
        private MdiClientPanel pnlMDI;
        private Bunifu.Framework.UI.BunifuImageButton btnSetting;
        private Bunifu.Framework.UI.BunifuImageButton btnHelp;
        private Bunifu.Framework.UI.BunifuImageButton btnProfile;
        private System.Windows.Forms.Label lblProfile;
    }
}
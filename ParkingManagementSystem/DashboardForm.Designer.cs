namespace ParkingManagementSystem
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.PnlBg = new System.Windows.Forms.Panel();
            this.BtnReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlSubAdm = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnAdmn = new System.Windows.Forms.Button();
            this.BtnSlots = new System.Windows.Forms.Button();
            this.BtnMain = new System.Windows.Forms.Button();
            this.PnlLogo = new System.Windows.Forms.Panel();
            this.DshbrdTmr = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainOne1 = new ParkingManagementSystem.Panels.MainOne();
            this.mainTwo1 = new ParkingManagementSystem.Panels.MainTwo();
            this.manageAccounts1 = new ParkingManagementSystem.Panels.ManageAccounts();
            this.history1 = new ParkingManagementSystem.Panels.History();
            this.sales1 = new ParkingManagementSystem.Panels.Sales();
            this.report1 = new ParkingManagementSystem.Panels.Report();
            this.PnlBg.SuspendLayout();
            this.PnlSubAdm.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlBg
            // 
            this.PnlBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.PnlBg.Controls.Add(this.BtnReport);
            this.PnlBg.Controls.Add(this.label1);
            this.PnlBg.Controls.Add(this.PnlSubAdm);
            this.PnlBg.Controls.Add(this.BtnAdmn);
            this.PnlBg.Controls.Add(this.BtnSlots);
            this.PnlBg.Controls.Add(this.BtnMain);
            this.PnlBg.Controls.Add(this.PnlLogo);
            this.PnlBg.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlBg.Location = new System.Drawing.Point(0, 0);
            this.PnlBg.Name = "PnlBg";
            this.PnlBg.Size = new System.Drawing.Size(233, 768);
            this.PnlBg.TabIndex = 0;
            // 
            // BtnReport
            // 
            this.BtnReport.BackColor = System.Drawing.Color.Transparent;
            this.BtnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnReport.FlatAppearance.BorderSize = 0;
            this.BtnReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
            this.BtnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.BtnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReport.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReport.ForeColor = System.Drawing.Color.White;
            this.BtnReport.Image = ((System.Drawing.Image)(resources.GetObject("BtnReport.Image")));
            this.BtnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReport.Location = new System.Drawing.Point(0, 588);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnReport.Size = new System.Drawing.Size(233, 65);
            this.BtnReport.TabIndex = 7;
            this.BtnReport.Text = "        Report";
            this.BtnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReport.UseVisualStyleBackColor = false;
            this.BtnReport.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(-3, 717);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(135, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "          Logout";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PnlSubAdm
            // 
            this.PnlSubAdm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.PnlSubAdm.Controls.Add(this.button4);
            this.PnlSubAdm.Controls.Add(this.button3);
            this.PnlSubAdm.Controls.Add(this.button2);
            this.PnlSubAdm.Controls.Add(this.button1);
            this.PnlSubAdm.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlSubAdm.Location = new System.Drawing.Point(0, 312);
            this.PnlSubAdm.Name = "PnlSubAdm";
            this.PnlSubAdm.Size = new System.Drawing.Size(233, 276);
            this.PnlSubAdm.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 195);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(233, 65);
            this.button4.TabIndex = 8;
            this.button4.Text = "         Report";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 130);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(233, 65);
            this.button3.TabIndex = 7;
            this.button3.Text = "         Sales";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 65);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(233, 65);
            this.button2.TabIndex = 6;
            this.button2.Text = "         History";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(233, 65);
            this.button1.TabIndex = 5;
            this.button1.Text = "         Manage Accounts";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // BtnAdmn
            // 
            this.BtnAdmn.BackColor = System.Drawing.Color.Transparent;
            this.BtnAdmn.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAdmn.FlatAppearance.BorderSize = 0;
            this.BtnAdmn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
            this.BtnAdmn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.BtnAdmn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdmn.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnAdmn.ForeColor = System.Drawing.Color.White;
            this.BtnAdmn.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdmn.Image")));
            this.BtnAdmn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdmn.Location = new System.Drawing.Point(0, 247);
            this.BtnAdmn.Name = "BtnAdmn";
            this.BtnAdmn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnAdmn.Size = new System.Drawing.Size(233, 65);
            this.BtnAdmn.TabIndex = 4;
            this.BtnAdmn.Text = "         Admin";
            this.BtnAdmn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdmn.UseVisualStyleBackColor = false;
            this.BtnAdmn.Click += new System.EventHandler(this.BtnAdmn_Click);
            // 
            // BtnSlots
            // 
            this.BtnSlots.BackColor = System.Drawing.Color.Transparent;
            this.BtnSlots.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSlots.FlatAppearance.BorderSize = 0;
            this.BtnSlots.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
            this.BtnSlots.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.BtnSlots.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSlots.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnSlots.ForeColor = System.Drawing.Color.White;
            this.BtnSlots.Image = ((System.Drawing.Image)(resources.GetObject("BtnSlots.Image")));
            this.BtnSlots.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSlots.Location = new System.Drawing.Point(0, 182);
            this.BtnSlots.Name = "BtnSlots";
            this.BtnSlots.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnSlots.Size = new System.Drawing.Size(233, 65);
            this.BtnSlots.TabIndex = 2;
            this.BtnSlots.Text = "        Manage Parking";
            this.BtnSlots.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSlots.UseVisualStyleBackColor = false;
            // 
            // BtnMain
            // 
            this.BtnMain.BackColor = System.Drawing.Color.Transparent;
            this.BtnMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnMain.FlatAppearance.BorderSize = 0;
            this.BtnMain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(107)))), ((int)(((byte)(190)))));
            this.BtnMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.BtnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMain.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMain.ForeColor = System.Drawing.Color.White;
            this.BtnMain.Image = ((System.Drawing.Image)(resources.GetObject("BtnMain.Image")));
            this.BtnMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMain.Location = new System.Drawing.Point(0, 117);
            this.BtnMain.Name = "BtnMain";
            this.BtnMain.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnMain.Size = new System.Drawing.Size(233, 65);
            this.BtnMain.TabIndex = 1;
            this.BtnMain.Text = "        Dashboard";
            this.BtnMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMain.UseVisualStyleBackColor = false;
            // 
            // PnlLogo
            // 
            this.PnlLogo.BackColor = System.Drawing.Color.Transparent;
            this.PnlLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlLogo.BackgroundImage")));
            this.PnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlLogo.Location = new System.Drawing.Point(0, 0);
            this.PnlLogo.Name = "PnlLogo";
            this.PnlLogo.Size = new System.Drawing.Size(233, 117);
            this.PnlLogo.TabIndex = 0;
            // 
            // DshbrdTmr
            // 
            this.DshbrdTmr.Enabled = true;
            this.DshbrdTmr.Interval = 5;
            this.DshbrdTmr.Tick += new System.EventHandler(this.DshbrdTmr_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mainOne1);
            this.panel1.Controls.Add(this.mainTwo1);
            this.panel1.Controls.Add(this.manageAccounts1);
            this.panel1.Controls.Add(this.history1);
            this.panel1.Controls.Add(this.sales1);
            this.panel1.Controls.Add(this.report1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(233, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1133, 768);
            this.panel1.TabIndex = 1;
            // 
            // mainOne1
            // 
            this.mainOne1.Location = new System.Drawing.Point(0, 3);
            this.mainOne1.Name = "mainOne1";
            this.mainOne1.Size = new System.Drawing.Size(1133, 768);
            this.mainOne1.TabIndex = 6;
            // 
            // mainTwo1
            // 
            this.mainTwo1.Location = new System.Drawing.Point(0, 0);
            this.mainTwo1.Name = "mainTwo1";
            this.mainTwo1.Size = new System.Drawing.Size(1133, 768);
            this.mainTwo1.TabIndex = 5;
            // 
            // manageAccounts1
            // 
            this.manageAccounts1.Location = new System.Drawing.Point(0, 0);
            this.manageAccounts1.Name = "manageAccounts1";
            this.manageAccounts1.Size = new System.Drawing.Size(1133, 768);
            this.manageAccounts1.TabIndex = 4;
            // 
            // history1
            // 
            this.history1.Location = new System.Drawing.Point(0, 0);
            this.history1.Name = "history1";
            this.history1.Size = new System.Drawing.Size(1133, 768);
            this.history1.TabIndex = 3;
            // 
            // sales1
            // 
            this.sales1.Location = new System.Drawing.Point(0, 0);
            this.sales1.Name = "sales1";
            this.sales1.Size = new System.Drawing.Size(1133, 768);
            this.sales1.TabIndex = 1;
            // 
            // report1
            // 
            this.report1.Location = new System.Drawing.Point(0, 0);
            this.report1.Name = "report1";
            this.report1.Size = new System.Drawing.Size(1133, 768);
            this.report1.TabIndex = 0;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnlBg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.PnlBg.ResumeLayout(false);
            this.PnlSubAdm.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlBg;
        private System.Windows.Forms.Button BtnSlots;
        private System.Windows.Forms.Button BtnMain;
        private System.Windows.Forms.Panel PnlLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer DshbrdTmr;
        public System.Windows.Forms.Button BtnAdmn;
        public System.Windows.Forms.Panel PnlSubAdm;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnReport;
        private System.Windows.Forms.Panel panel1;
        private Panels.Report report1;
        public System.Windows.Forms.Button button4;
        private Panels.MainOne mainOne1;
        private Panels.MainTwo mainTwo1;
        private Panels.ManageAccounts manageAccounts1;
        private Panels.History history1;
        private Panels.Sales sales1;
    }
}
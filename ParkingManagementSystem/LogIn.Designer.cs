namespace ParkingManagementSystem
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.PnlLog = new System.Windows.Forms.Panel();
            this.LblMsgErr = new System.Windows.Forms.Label();
            this.BtnShow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Label();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.LblLogIn = new System.Windows.Forms.Label();
            this.BtnHide = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.PnlLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlLog
            // 
            this.PnlLog.BackColor = System.Drawing.Color.Transparent;
            this.PnlLog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlLog.BackgroundImage")));
            this.PnlLog.Controls.Add(this.LblMsgErr);
            this.PnlLog.Controls.Add(this.BtnShow);
            this.PnlLog.Controls.Add(this.label1);
            this.PnlLog.Controls.Add(this.BtnExit);
            this.PnlLog.Controls.Add(this.TxtPass);
            this.PnlLog.Controls.Add(this.TxtUsername);
            this.PnlLog.Controls.Add(this.LblLogIn);
            this.PnlLog.Controls.Add(this.BtnHide);
            this.PnlLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlLog.ForeColor = System.Drawing.Color.Transparent;
            this.PnlLog.Location = new System.Drawing.Point(0, 0);
            this.PnlLog.Name = "PnlLog";
            this.PnlLog.Size = new System.Drawing.Size(960, 540);
            this.PnlLog.TabIndex = 0;
            // 
            // LblMsgErr
            // 
            this.LblMsgErr.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.6F);
            this.LblMsgErr.ForeColor = System.Drawing.Color.Gold;
            this.LblMsgErr.Location = new System.Drawing.Point(377, 316);
            this.LblMsgErr.Name = "LblMsgErr";
            this.LblMsgErr.Size = new System.Drawing.Size(201, 15);
            this.LblMsgErr.TabIndex = 7;
            // 
            // BtnShow
            // 
            this.BtnShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnShow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShow.Image = ((System.Drawing.Image)(resources.GetObject("BtnShow.Image")));
            this.BtnShow.Location = new System.Drawing.Point(559, 271);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(19, 25);
            this.BtnShow.TabIndex = 5;
            this.BtnShow.UseVisualStyleBackColor = true;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(913, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = " ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label1_MouseClick);
            // 
            // BtnExit
            // 
            this.BtnExit.AutoSize = true;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(937, 9);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(11, 17);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = " ";
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // TxtPass
            // 
            this.TxtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPass.ForeColor = System.Drawing.Color.DarkGray;
            this.TxtPass.Location = new System.Drawing.Point(385, 278);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(168, 13);
            this.TxtPass.TabIndex = 2;
            this.TxtPass.Text = "Password";
            this.TxtPass.Enter += new System.EventHandler(this.TxtPass_Enter);
            this.TxtPass.Leave += new System.EventHandler(this.TxtPass_Leave);
            // 
            // TxtUsername
            // 
            this.TxtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUsername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            this.TxtUsername.ForeColor = System.Drawing.Color.DarkGray;
            this.TxtUsername.Location = new System.Drawing.Point(385, 229);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(172, 13);
            this.TxtUsername.TabIndex = 1;
            this.TxtUsername.Text = "Username";
            this.TxtUsername.Enter += new System.EventHandler(this.TxtUsername_Enter);
            this.TxtUsername.Leave += new System.EventHandler(this.TxtUsername_Leave);
            // 
            // LblLogIn
            // 
            this.LblLogIn.Location = new System.Drawing.Point(365, 347);
            this.LblLogIn.Name = "LblLogIn";
            this.LblLogIn.Size = new System.Drawing.Size(231, 37);
            this.LblLogIn.TabIndex = 0;
            this.LblLogIn.Click += new System.EventHandler(this.LblLogIn_Click);
            // 
            // BtnHide
            // 
            this.BtnHide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnHide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHide.Image = ((System.Drawing.Image)(resources.GetObject("BtnHide.Image")));
            this.BtnHide.Location = new System.Drawing.Point(559, 271);
            this.BtnHide.Name = "BtnHide";
            this.BtnHide.Size = new System.Drawing.Size(19, 25);
            this.BtnHide.TabIndex = 6;
            this.BtnHide.UseVisualStyleBackColor = true;
            this.BtnHide.Click += new System.EventHandler(this.BtnHide_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.PnlLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogIn";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PnlLog.ResumeLayout(false);
            this.PnlLog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlLog;
        private System.Windows.Forms.Label LblLogIn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.Label BtnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnHide;
        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.Label LblMsgErr;
        public System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.Timer timer2;
    }
}
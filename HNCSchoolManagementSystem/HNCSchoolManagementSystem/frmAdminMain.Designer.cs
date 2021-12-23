namespace HNCSchoolManagementSystem
{
    partial class frmAdminMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminMain));
            this.elips = new Guna.UI.WinForms.GunaElipse(this.components);
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlChangeWindow = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pnlSideMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.btnReports = new Guna.UI2.WinForms.Guna2Button();
            this.btnRegistration = new Guna.UI2.WinForms.Guna2Button();
            this.btnMembers = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.drag1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.drag2 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.pnlMain.SuspendLayout();
            this.pnlSideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // elips
            // 
            this.elips.Radius = 0;
            this.elips.TargetControl = this;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlChangeWindow);
            this.pnlMain.Controls.Add(this.btnClose);
            this.pnlMain.Controls.Add(this.pnlSideMenu);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(57)))));
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.ShadowDecoration.Parent = this.pnlMain;
            this.pnlMain.Size = new System.Drawing.Size(1330, 888);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlChangeWindow
            // 
            this.pnlChangeWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlChangeWindow.BackColor = System.Drawing.Color.Transparent;
            this.pnlChangeWindow.Location = new System.Drawing.Point(290, 52);
            this.pnlChangeWindow.Name = "pnlChangeWindow";
            this.pnlChangeWindow.ShadowDecoration.Parent = this.pnlChangeWindow;
            this.pnlChangeWindow.Size = new System.Drawing.Size(1028, 824);
            this.pnlChangeWindow.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.HoverState.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.IconColor = System.Drawing.SystemColors.ControlDark;
            this.btnClose.Location = new System.Drawing.Point(1247, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedDepth = 0;
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(83, 46);
            this.btnClose.TabIndex = 2;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.Controls.Add(this.btnReports);
            this.pnlSideMenu.Controls.Add(this.btnRegistration);
            this.pnlSideMenu.Controls.Add(this.btnMembers);
            this.pnlSideMenu.Controls.Add(this.btnDashboard);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(72)))));
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.ShadowDecoration.Parent = this.pnlSideMenu;
            this.pnlSideMenu.Size = new System.Drawing.Size(284, 888);
            this.pnlSideMenu.TabIndex = 0;
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.Transparent;
            this.btnReports.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnReports.CheckedState.Parent = this.btnReports;
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.CustomImages.Parent = this.btnReports;
            this.btnReports.FillColor = System.Drawing.Color.Transparent;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnReports.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnReports.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnReports.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.HoverState.ForeColor = System.Drawing.Color.LightGray;
            this.btnReports.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnReports.HoverState.Image")));
            this.btnReports.HoverState.Parent = this.btnReports;
            this.btnReports.Image = ((System.Drawing.Image)(resources.GetObject("btnReports.Image")));
            this.btnReports.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReports.ImageSize = new System.Drawing.Size(25, 25);
            this.btnReports.Location = new System.Drawing.Point(49, 462);
            this.btnReports.Name = "btnReports";
            this.btnReports.PressedDepth = 0;
            this.btnReports.ShadowDecoration.Parent = this.btnReports;
            this.btnReports.Size = new System.Drawing.Size(189, 45);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "Reports";
            this.btnReports.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnRegistration
            // 
            this.btnRegistration.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistration.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnRegistration.CheckedState.Parent = this.btnRegistration;
            this.btnRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistration.CustomImages.Parent = this.btnRegistration;
            this.btnRegistration.FillColor = System.Drawing.Color.Transparent;
            this.btnRegistration.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRegistration.ForeColor = System.Drawing.Color.White;
            this.btnRegistration.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnRegistration.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnRegistration.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnRegistration.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistration.HoverState.ForeColor = System.Drawing.Color.LightGray;
            this.btnRegistration.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistration.HoverState.Image")));
            this.btnRegistration.HoverState.Parent = this.btnRegistration;
            this.btnRegistration.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistration.Image")));
            this.btnRegistration.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRegistration.ImageSize = new System.Drawing.Size(25, 25);
            this.btnRegistration.Location = new System.Drawing.Point(49, 411);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.PressedDepth = 0;
            this.btnRegistration.ShadowDecoration.Parent = this.btnRegistration;
            this.btnRegistration.Size = new System.Drawing.Size(189, 45);
            this.btnRegistration.TabIndex = 2;
            this.btnRegistration.Text = "Registration";
            this.btnRegistration.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // btnMembers
            // 
            this.btnMembers.BackColor = System.Drawing.Color.Transparent;
            this.btnMembers.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnMembers.CheckedState.Parent = this.btnMembers;
            this.btnMembers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMembers.CustomImages.Parent = this.btnMembers;
            this.btnMembers.FillColor = System.Drawing.Color.Transparent;
            this.btnMembers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMembers.ForeColor = System.Drawing.Color.White;
            this.btnMembers.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnMembers.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnMembers.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnMembers.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembers.HoverState.ForeColor = System.Drawing.Color.LightGray;
            this.btnMembers.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnMembers.HoverState.Image")));
            this.btnMembers.HoverState.Parent = this.btnMembers;
            this.btnMembers.Image = ((System.Drawing.Image)(resources.GetObject("btnMembers.Image")));
            this.btnMembers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMembers.ImageSize = new System.Drawing.Size(25, 25);
            this.btnMembers.Location = new System.Drawing.Point(49, 360);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.PressedDepth = 0;
            this.btnMembers.ShadowDecoration.Parent = this.btnMembers;
            this.btnMembers.Size = new System.Drawing.Size(189, 45);
            this.btnMembers.TabIndex = 1;
            this.btnMembers.Text = "Members";
            this.btnMembers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDashboard.Checked = true;
            this.btnDashboard.CheckedState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.CheckedState.Parent = this.btnDashboard;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.CustomImages.Parent = this.btnDashboard;
            this.btnDashboard.FillColor = System.Drawing.Color.Transparent;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnDashboard.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnDashboard.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnDashboard.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.HoverState.ForeColor = System.Drawing.Color.LightGray;
            this.btnDashboard.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.HoverState.Image")));
            this.btnDashboard.HoverState.Parent = this.btnDashboard;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDashboard.Location = new System.Drawing.Point(49, 309);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.PressedDepth = 0;
            this.btnDashboard.ShadowDecoration.Parent = this.btnDashboard;
            this.btnDashboard.Size = new System.Drawing.Size(189, 45);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // drag1
            // 
            this.drag1.TargetControl = null;
            // 
            // drag2
            // 
            this.drag2.TargetControl = this.pnlMain;
            // 
            // frmAdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 888);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdminMain";
            this.Load += new System.EventHandler(this.frmAdminMain_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlSideMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse elips;
        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private Guna.UI2.WinForms.Guna2Panel pnlSideMenu;
        private Guna.UI.WinForms.GunaDragControl drag1;
        private Guna.UI.WinForms.GunaDragControl drag2;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnMembers;
        private Guna.UI2.WinForms.Guna2Button btnRegistration;
        private Guna.UI2.WinForms.Guna2Button btnReports;
        private Guna.UI2.WinForms.Guna2Panel pnlChangeWindow;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
    }
}
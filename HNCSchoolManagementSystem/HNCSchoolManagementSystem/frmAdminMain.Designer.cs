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
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.drag1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.drag2 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.pnlMain.SuspendLayout();
            this.pnlSideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // elips
            // 
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
            this.pnlChangeWindow.Location = new System.Drawing.Point(283, 52);
            this.pnlChangeWindow.Name = "pnlChangeWindow";
            this.pnlChangeWindow.ShadowDecoration.Parent = this.pnlChangeWindow;
            this.pnlChangeWindow.Size = new System.Drawing.Size(1044, 833);
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
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.Controls.Add(this.guna2Button2);
            this.pnlSideMenu.Controls.Add(this.guna2Button1);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(72)))));
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.ShadowDecoration.Parent = this.pnlSideMenu;
            this.pnlSideMenu.Size = new System.Drawing.Size(284, 888);
            this.pnlSideMenu.TabIndex = 0;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button1.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.HoverState.ForeColor = System.Drawing.Color.LightGray;
            this.guna2Button1.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.HoverState.Image")));
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button1.Location = new System.Drawing.Point(49, 309);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedDepth = 0;
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(189, 45);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "Dashboard";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // drag1
            // 
            this.drag1.TargetControl = null;
            // 
            // drag2
            // 
            this.drag2.TargetControl = this.pnlMain;
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button2.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.HoverState.ForeColor = System.Drawing.Color.LightGray;
            this.guna2Button2.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.HoverState.Image")));
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.Image")));
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button2.Location = new System.Drawing.Point(49, 360);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.PressedDepth = 0;
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(189, 45);
            this.guna2Button2.TabIndex = 1;
            this.guna2Button2.Text = "Accounts";
            this.guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Panel pnlChangeWindow;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}
namespace HNCSchoolManagementSystem
{
    partial class frmAdminRegister
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
            Guna.UI.Animation.Animation animation3 = new Guna.UI.Animation.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminRegister));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlStudent = new System.Windows.Forms.Panel();
            this.pnlTeacher = new System.Windows.Forms.Panel();
            this.btnTeacher = new Bunifu.Framework.UI.BunifuImageButton();
            this.animeStudent = new Guna.UI.WinForms.GunaTransition(this.components);
            this.btnStudent = new Bunifu.Framework.UI.BunifuImageButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlStudent.SuspendLayout();
            this.pnlTeacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // pnlStudent
            // 
            this.pnlStudent.BackColor = System.Drawing.Color.Red;
            this.pnlStudent.Controls.Add(this.btnStudent);
            this.animeStudent.SetDecoration(this.pnlStudent, Guna.UI.Animation.DecorationType.None);
            this.pnlStudent.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlStudent.Location = new System.Drawing.Point(938, 0);
            this.pnlStudent.Name = "pnlStudent";
            this.pnlStudent.Size = new System.Drawing.Size(209, 739);
            this.pnlStudent.TabIndex = 0;
            // 
            // pnlTeacher
            // 
            this.pnlTeacher.BackColor = System.Drawing.Color.Transparent;
            this.pnlTeacher.Controls.Add(this.txtUsername);
            this.pnlTeacher.Controls.Add(this.gunaLabel2);
            this.pnlTeacher.Controls.Add(this.gunaLabel1);
            this.pnlTeacher.Controls.Add(this.btnTeacher);
            this.animeStudent.SetDecoration(this.pnlTeacher, Guna.UI.Animation.DecorationType.None);
            this.pnlTeacher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTeacher.Location = new System.Drawing.Point(0, 0);
            this.pnlTeacher.Name = "pnlTeacher";
            this.pnlTeacher.Size = new System.Drawing.Size(938, 739);
            this.pnlTeacher.TabIndex = 1;
            // 
            // btnTeacher
            // 
            this.btnTeacher.BackColor = System.Drawing.Color.SeaGreen;
            this.animeStudent.SetDecoration(this.btnTeacher, Guna.UI.Animation.DecorationType.None);
            this.btnTeacher.Image = ((System.Drawing.Image)(resources.GetObject("btnTeacher.Image")));
            this.btnTeacher.ImageActive = null;
            this.btnTeacher.Location = new System.Drawing.Point(21, 12);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Size = new System.Drawing.Size(71, 71);
            this.btnTeacher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnTeacher.TabIndex = 0;
            this.btnTeacher.TabStop = false;
            this.btnTeacher.Zoom = 10;
            this.btnTeacher.Click += new System.EventHandler(this.btnTeacher_Click);
            // 
            // animeStudent
            // 
            this.animeStudent.AnimationType = Guna.UI.Animation.AnimationType.Scale;
            this.animeStudent.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.animeStudent.DefaultAnimation = animation3;
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.Color.SeaGreen;
            this.animeStudent.SetDecoration(this.btnStudent, Guna.UI.Animation.DecorationType.None);
            this.btnStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnStudent.Image")));
            this.btnStudent.ImageActive = null;
            this.btnStudent.Location = new System.Drawing.Point(17, 12);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(71, 71);
            this.btnStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnStudent.TabIndex = 1;
            this.btnStudent.TabStop = false;
            this.btnStudent.Zoom = 10;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.animeStudent.SetDecoration(this.gunaLabel1, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.Location = new System.Drawing.Point(69, 113);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(429, 57);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Teacher Registration";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.animeStudent.SetDecoration(this.gunaLabel2, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(75, 185);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(86, 20);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "gunaLabel2";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(72)))));
            this.txtUsername.BorderRadius = 10;
            this.txtUsername.BorderThickness = 5;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animeStudent.SetDecoration(this.txtUsername, Guna.UI.Animation.DecorationType.None);
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.Parent = this.txtUsername;
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(72)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.txtUsername.FocusedState.Parent = this.txtUsername;
            this.txtUsername.ForeColor = System.Drawing.Color.LightGray;
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.txtUsername.HoverState.Parent = this.txtUsername;
            this.txtUsername.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtUsername.Location = new System.Drawing.Point(79, 268);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtUsername.PlaceholderText = "Username";
            this.txtUsername.SelectedText = "";
            this.txtUsername.ShadowDecoration.Parent = this.txtUsername;
            this.txtUsername.Size = new System.Drawing.Size(292, 48);
            this.txtUsername.TabIndex = 8;
            this.txtUsername.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // frmAdminRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(1147, 739);
            this.Controls.Add(this.pnlTeacher);
            this.Controls.Add(this.pnlStudent);
            this.animeStudent.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminRegister";
            this.Text = "frmAdminDash";
            this.Load += new System.EventHandler(this.frmMembersStudents_Load);
            this.pnlStudent.ResumeLayout(false);
            this.pnlTeacher.ResumeLayout(false);
            this.pnlTeacher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel pnlTeacher;
        private System.Windows.Forms.Panel pnlStudent;
        private Guna.UI.WinForms.GunaTransition animeStudent;
        private Bunifu.Framework.UI.BunifuImageButton btnTeacher;
        private Bunifu.Framework.UI.BunifuImageButton btnStudent;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
    }
}
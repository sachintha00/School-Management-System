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
            Guna.UI.Animation.Animation animation4 = new Guna.UI.Animation.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminRegister));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlStudent = new System.Windows.Forms.Panel();
            this.btnStudent = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlTeacher = new System.Windows.Forms.Panel();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btnTeacher = new Bunifu.Framework.UI.BunifuImageButton();
            this.animeStudent = new Guna.UI.WinForms.GunaTransition(this.components);
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnStudent)).BeginInit();
            this.pnlTeacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnTeacher)).BeginInit();
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
            this.pnlStudent.Location = new System.Drawing.Point(1192, 0);
            this.pnlStudent.Name = "pnlStudent";
            this.pnlStudent.Size = new System.Drawing.Size(209, 739);
            this.pnlStudent.TabIndex = 0;
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
            // pnlTeacher
            // 
            this.pnlTeacher.BackColor = System.Drawing.Color.Transparent;
            this.pnlTeacher.Controls.Add(this.guna2TextBox2);
            this.pnlTeacher.Controls.Add(this.guna2TextBox1);
            this.pnlTeacher.Controls.Add(this.guna2TextBox4);
            this.pnlTeacher.Controls.Add(this.guna2TextBox3);
            this.pnlTeacher.Controls.Add(this.txtUsername);
            this.pnlTeacher.Controls.Add(this.gunaLabel2);
            this.pnlTeacher.Controls.Add(this.gunaLabel1);
            this.pnlTeacher.Controls.Add(this.btnTeacher);
            this.animeStudent.SetDecoration(this.pnlTeacher, Guna.UI.Animation.DecorationType.None);
            this.pnlTeacher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTeacher.Location = new System.Drawing.Point(0, 0);
            this.pnlTeacher.Name = "pnlTeacher";
            this.pnlTeacher.Size = new System.Drawing.Size(1192, 739);
            this.pnlTeacher.TabIndex = 1;
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
            this.txtUsername.PlaceholderText = "First Name";
            this.txtUsername.SelectedText = "";
            this.txtUsername.ShadowDecoration.Parent = this.txtUsername;
            this.txtUsername.Size = new System.Drawing.Size(292, 48);
            this.txtUsername.TabIndex = 8;
            this.txtUsername.TextOffset = new System.Drawing.Point(10, 0);
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
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.animeStudent.DefaultAnimation = animation4;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(72)))));
            this.guna2TextBox1.BorderRadius = 10;
            this.guna2TextBox1.BorderThickness = 5;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animeStudent.SetDecoration(this.guna2TextBox1, Guna.UI.Animation.DecorationType.None);
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(72)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.ForeColor = System.Drawing.Color.LightGray;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.guna2TextBox1.Location = new System.Drawing.Point(442, 268);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2TextBox1.PlaceholderText = "Middle Name";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(292, 48);
            this.guna2TextBox1.TabIndex = 8;
            this.guna2TextBox1.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(72)))));
            this.guna2TextBox2.BorderRadius = 10;
            this.guna2TextBox2.BorderThickness = 5;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animeStudent.SetDecoration(this.guna2TextBox2, Guna.UI.Animation.DecorationType.None);
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(72)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.guna2TextBox2.FocusedState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.ForeColor = System.Drawing.Color.LightGray;
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.guna2TextBox2.HoverState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.guna2TextBox2.Location = new System.Drawing.Point(805, 268);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2TextBox2.PlaceholderText = "Surname";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.ShadowDecoration.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Size = new System.Drawing.Size(292, 48);
            this.guna2TextBox2.TabIndex = 8;
            this.guna2TextBox2.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // guna2TextBox3
            // 
            this.guna2TextBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(72)))));
            this.guna2TextBox3.BorderRadius = 10;
            this.guna2TextBox3.BorderThickness = 5;
            this.guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animeStudent.SetDecoration(this.guna2TextBox3, Guna.UI.Animation.DecorationType.None);
            this.guna2TextBox3.DefaultText = "";
            this.guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.DisabledState.Parent = this.guna2TextBox3;
            this.guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(72)))));
            this.guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.guna2TextBox3.FocusedState.Parent = this.guna2TextBox3;
            this.guna2TextBox3.ForeColor = System.Drawing.Color.LightGray;
            this.guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.guna2TextBox3.HoverState.Parent = this.guna2TextBox3;
            this.guna2TextBox3.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.guna2TextBox3.Location = new System.Drawing.Point(79, 398);
            this.guna2TextBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox3.Name = "guna2TextBox3";
            this.guna2TextBox3.PasswordChar = '\0';
            this.guna2TextBox3.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2TextBox3.PlaceholderText = "Email   Ex: example@example.com";
            this.guna2TextBox3.SelectedText = "";
            this.guna2TextBox3.ShadowDecoration.Parent = this.guna2TextBox3;
            this.guna2TextBox3.Size = new System.Drawing.Size(541, 48);
            this.guna2TextBox3.TabIndex = 8;
            this.guna2TextBox3.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // guna2TextBox4
            // 
            this.guna2TextBox4.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(72)))));
            this.guna2TextBox4.BorderRadius = 10;
            this.guna2TextBox4.BorderThickness = 5;
            this.guna2TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animeStudent.SetDecoration(this.guna2TextBox4, Guna.UI.Animation.DecorationType.None);
            this.guna2TextBox4.DefaultText = "";
            this.guna2TextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.DisabledState.Parent = this.guna2TextBox4;
            this.guna2TextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(72)))));
            this.guna2TextBox4.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.guna2TextBox4.FocusedState.Parent = this.guna2TextBox4;
            this.guna2TextBox4.ForeColor = System.Drawing.Color.LightGray;
            this.guna2TextBox4.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.guna2TextBox4.HoverState.Parent = this.guna2TextBox4;
            this.guna2TextBox4.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.guna2TextBox4.Location = new System.Drawing.Point(696, 398);
            this.guna2TextBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox4.Name = "guna2TextBox4";
            this.guna2TextBox4.PasswordChar = '\0';
            this.guna2TextBox4.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2TextBox4.PlaceholderText = "Mobile Number";
            this.guna2TextBox4.SelectedText = "";
            this.guna2TextBox4.ShadowDecoration.Parent = this.guna2TextBox4;
            this.guna2TextBox4.Size = new System.Drawing.Size(401, 48);
            this.guna2TextBox4.TabIndex = 8;
            this.guna2TextBox4.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // frmAdminRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(1401, 739);
            this.Controls.Add(this.pnlTeacher);
            this.Controls.Add(this.pnlStudent);
            this.animeStudent.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminRegister";
            this.Text = "frmAdminDash";
            this.Load += new System.EventHandler(this.frmMembersStudents_Load);
            this.pnlStudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnStudent)).EndInit();
            this.pnlTeacher.ResumeLayout(false);
            this.pnlTeacher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnTeacher)).EndInit();
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
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox4;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
    }
}
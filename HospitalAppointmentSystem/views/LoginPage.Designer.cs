namespace OnlyWorks.views
{
    partial class LoginPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            txt_email = new TextBox();
            txt_password = new TextBox();
            btn_login = new Button();
            link_goToForgotPassword = new LinkLabel();
            link_goToSignup = new LinkLabel();
            label3 = new Label();
            label2 = new Label();
            panelLeft = new Panel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label4 = new Label();
            panelLeft.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_email
            // 
            txt_email.BackColor = Color.FromArgb(240, 240, 240);
            txt_email.BorderStyle = BorderStyle.FixedSingle;
            txt_email.Location = new Point(273, 261);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(250, 23);
            txt_email.TabIndex = 0;
            // 
            // txt_password
            // 
            txt_password.BackColor = Color.FromArgb(240, 240, 240);
            txt_password.BorderStyle = BorderStyle.FixedSingle;
            txt_password.Location = new Point(274, 351);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(250, 23);
            txt_password.TabIndex = 1;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.FromArgb(37, 99, 235);
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(273, 424);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(250, 40);
            btn_login.TabIndex = 2;
            btn_login.Text = "Log In";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // link_goToForgotPassword
            // 
            link_goToForgotPassword.AutoSize = true;
            link_goToForgotPassword.LinkColor = SystemColors.Highlight;
            link_goToForgotPassword.Location = new Point(433, 499);
            link_goToForgotPassword.Name = "link_goToForgotPassword";
            link_goToForgotPassword.Size = new Size(144, 15);
            link_goToForgotPassword.TabIndex = 7;
            link_goToForgotPassword.TabStop = true;
            link_goToForgotPassword.Text = "You forgot you password?";
            link_goToForgotPassword.LinkClicked += link_goToForgotPassword_LinkClicked;
            // 
            // link_goToSignup
            // 
            link_goToSignup.AutoSize = true;
            link_goToSignup.LinkColor = SystemColors.Highlight;
            link_goToSignup.Location = new Point(238, 499);
            link_goToSignup.Name = "link_goToSignup";
            link_goToSignup.Size = new Size(152, 15);
            link_goToSignup.TabIndex = 6;
            link_goToSignup.TabStop = true;
            link_goToSignup.Text = "You dont have an Account?";
            link_goToSignup.LinkClicked += link_goToSignup_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(273, 313);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(273, 226);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 4;
            label2.Text = "Email";
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(240, 245, 250);
            panelLeft.Controls.Add(pictureBox1);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(500, 720);
            panelLeft.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(link_goToForgotPassword);
            panel1.Controls.Add(txt_email);
            panel1.Controls.Add(link_goToSignup);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btn_login);
            panel1.Controls.Add(txt_password);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(500, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(780, 720);
            panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 720);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(340, 110);
            label1.Name = "label1";
            label1.Size = new Size(94, 40);
            label1.TabIndex = 8;
            label1.Text = "Login";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.LightGray;
            label4.Location = new Point(273, 175);
            label4.Name = "label4";
            label4.Size = new Size(232, 20);
            label4.TabIndex = 9;
            label4.Text = "Hoş Geldiniz ! Lütfen giriş yapınız.";
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            Controls.Add(panel1);
            Controls.Add(panelLeft);
            Name = "LoginPage";
            Size = new Size(1280, 720);
            panelLeft.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txt_email;
        private TextBox txt_password;
        private Button btn_login;
        private Label label2;
        private Label label3;
        private LinkLabel link_goToSignup;
        private LinkLabel link_goToForgotPassword;
        private Panel panelLeft;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label4;
        private Label label1;
    }
}

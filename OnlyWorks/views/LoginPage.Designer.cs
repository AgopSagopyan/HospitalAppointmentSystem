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
            txt_email = new TextBox();
            txt_password = new TextBox();
            btn_login = new Button();
            panel1 = new Panel();
            link_goToForgotPassword = new LinkLabel();
            link_goToSignup = new LinkLabel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txt_email
            // 
            txt_email.Location = new Point(105, 124);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(201, 23);
            txt_email.TabIndex = 0;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(104, 207);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(201, 23);
            txt_password.TabIndex = 1;
            // 
            // btn_login
            // 
            btn_login.BackColor = SystemColors.Highlight;
            btn_login.FlatStyle = FlatStyle.Popup;
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(104, 283);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(200, 47);
            btn_login.TabIndex = 2;
            btn_login.Text = "Log In";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 39, 46);
            panel1.Controls.Add(link_goToForgotPassword);
            panel1.Controls.Add(link_goToSignup);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txt_email);
            panel1.Controls.Add(btn_login);
            panel1.Controls.Add(txt_password);
            panel1.Location = new Point(380, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(422, 496);
            panel1.TabIndex = 3;
            // 
            // link_goToForgotPassword
            // 
            link_goToForgotPassword.AutoSize = true;
            link_goToForgotPassword.LinkColor = SystemColors.Highlight;
            link_goToForgotPassword.Location = new Point(126, 398);
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
            link_goToSignup.Location = new Point(126, 360);
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
            label3.ForeColor = Color.White;
            label3.Location = new Point(104, 189);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(104, 106);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 4;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(156, 42);
            label1.Name = "label1";
            label1.Size = new Size(104, 45);
            label1.TabIndex = 3;
            label1.Text = "Login";
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(panel1);
            Name = "LoginPage";
            Size = new Size(1280, 720);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txt_email;
        private TextBox txt_password;
        private Button btn_login;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label3;
        private LinkLabel link_goToSignup;
        private LinkLabel link_goToForgotPassword;
    }
}

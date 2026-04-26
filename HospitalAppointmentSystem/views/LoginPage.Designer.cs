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
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            link_goToForgotPassword = new LinkLabel();
            link_goToSignup = new LinkLabel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_email
            // 
            txt_email.Location = new Point(212, 178);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(201, 23);
            txt_email.TabIndex = 0;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(211, 261);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(201, 23);
            txt_password.TabIndex = 1;
            // 
            // btn_login
            // 
            btn_login.BackColor = SystemColors.Highlight;
            btn_login.FlatStyle = FlatStyle.Popup;
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(211, 476);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(200, 47);
            btn_login.TabIndex = 2;
            btn_login.Text = "Log In";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 45, 45);
            panel1.Controls.Add(radioButton3);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(link_goToForgotPassword);
            panel1.Controls.Add(link_goToSignup);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txt_email);
            panel1.Controls.Add(btn_login);
            panel1.Controls.Add(txt_password);
            panel1.Location = new Point(640, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(640, 720);
            panel1.TabIndex = 3;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.ForeColor = Color.White;
            radioButton3.Location = new Point(263, 381);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(94, 19);
            radioButton3.TabIndex = 10;
            radioButton3.TabStop = true;
            radioButton3.Tag = "admin_login";
            radioButton3.Text = "Admin Login";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton1_CheckedChanged_1;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.ForeColor = Color.White;
            radioButton2.Location = new Point(263, 356);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(94, 19);
            radioButton2.TabIndex = 9;
            radioButton2.TabStop = true;
            radioButton2.Tag = "doctor_login";
            radioButton2.Text = "Doctor Login";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton1_CheckedChanged_1;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.ForeColor = Color.White;
            radioButton1.Location = new Point(263, 331);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(95, 19);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.Tag = "patient_login";
            radioButton1.Text = "Patient Login";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged_1;
            // 
            // link_goToForgotPassword
            // 
            link_goToForgotPassword.AutoSize = true;
            link_goToForgotPassword.LinkColor = SystemColors.Highlight;
            link_goToForgotPassword.Location = new Point(233, 591);
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
            link_goToSignup.Location = new Point(233, 553);
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
            label3.Location = new Point(211, 243);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(211, 160);
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
            label1.Location = new Point(263, 96);
            label1.Name = "label1";
            label1.Size = new Size(104, 45);
            label1.TabIndex = 3;
            label1.Text = "Login";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = HospitalAppointmentSystem.Properties.Resources.Vector_doctor_examining_a_patient_at_the_clinic_portraying_20_qualities_that_make_a_good_doctor_1200x900;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(640, 720);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "LoginPage";
            Size = new Size(1280, 720);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}

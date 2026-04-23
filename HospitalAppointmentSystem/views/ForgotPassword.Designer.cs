namespace OnlyWorks.views
{
    partial class ForgotPassword
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
            panel1 = new Panel();
            link_goToLogin = new LinkLabel();
            label4 = new Label();
            label6 = new Label();
            btn_sendCode = new Button();
            txtBox_email = new TextBox();
            panel2 = new Panel();
            lbl_timer = new Label();
            lbl_givenEmail = new Label();
            label12 = new Label();
            label8 = new Label();
            txtBox_verificationCode = new TextBox();
            link_resendCode = new LinkLabel();
            label11 = new Label();
            btn_verificate = new Button();
            panel3 = new Panel();
            label1 = new Label();
            txt_newPasswordAgain = new TextBox();
            label5 = new Label();
            txt_newPassword = new TextBox();
            linkLabel1 = new LinkLabel();
            label7 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 39, 46);
            panel1.Controls.Add(link_goToLogin);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btn_sendCode);
            panel1.Controls.Add(txtBox_email);
            panel1.Location = new Point(12, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(422, 496);
            panel1.TabIndex = 10;
            // 
            // link_goToLogin
            // 
            link_goToLogin.AutoSize = true;
            link_goToLogin.LinkColor = SystemColors.Highlight;
            link_goToLogin.Location = new Point(105, 413);
            link_goToLogin.Name = "link_goToLogin";
            link_goToLogin.Size = new Size(209, 15);
            link_goToLogin.TabIndex = 6;
            link_goToLogin.TabStop = true;
            link_goToLogin.Text = "You already have an existing Account?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(105, 125);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 5;
            label4.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(63, 28);
            label6.Name = "label6";
            label6.Size = new Size(290, 45);
            label6.TabIndex = 3;
            label6.Text = "Verify Your E-Mail";
            // 
            // btn_sendCode
            // 
            btn_sendCode.BackColor = SystemColors.Highlight;
            btn_sendCode.FlatStyle = FlatStyle.Popup;
            btn_sendCode.ForeColor = Color.White;
            btn_sendCode.Location = new Point(105, 339);
            btn_sendCode.Name = "btn_sendCode";
            btn_sendCode.Size = new Size(200, 47);
            btn_sendCode.TabIndex = 2;
            btn_sendCode.Text = "Send Code";
            btn_sendCode.UseVisualStyleBackColor = false;
            btn_sendCode.Click += btn_sendCode_Click;
            // 
            // txtBox_email
            // 
            txtBox_email.Location = new Point(105, 143);
            txtBox_email.Name = "txtBox_email";
            txtBox_email.Size = new Size(201, 23);
            txtBox_email.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 39, 46);
            panel2.Controls.Add(lbl_timer);
            panel2.Controls.Add(lbl_givenEmail);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtBox_verificationCode);
            panel2.Controls.Add(link_resendCode);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(btn_verificate);
            panel2.Location = new Point(446, 107);
            panel2.Name = "panel2";
            panel2.Size = new Size(422, 496);
            panel2.TabIndex = 11;
            panel2.Visible = false;
            // 
            // lbl_timer
            // 
            lbl_timer.AutoSize = true;
            lbl_timer.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_timer.ForeColor = Color.White;
            lbl_timer.Location = new Point(129, 154);
            lbl_timer.Name = "lbl_timer";
            lbl_timer.Size = new Size(153, 65);
            lbl_timer.TabIndex = 11;
            lbl_timer.Text = "00:00";
            // 
            // lbl_givenEmail
            // 
            lbl_givenEmail.AutoSize = true;
            lbl_givenEmail.ForeColor = Color.White;
            lbl_givenEmail.Location = new Point(56, 103);
            lbl_givenEmail.Name = "lbl_givenEmail";
            lbl_givenEmail.Size = new Size(130, 15);
            lbl_givenEmail.TabIndex = 10;
            lbl_givenEmail.Text = "Davudittin@gmail.com";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.White;
            label12.Location = new Point(58, 75);
            label12.Name = "label12";
            label12.Size = new Size(111, 15);
            label12.TabIndex = 9;
            label12.Text = "Control your E-mail";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(57, 274);
            label8.Name = "label8";
            label8.Size = new Size(97, 15);
            label8.TabIndex = 8;
            label8.Text = "Verification Code";
            // 
            // txtBox_verificationCode
            // 
            txtBox_verificationCode.Location = new Point(56, 292);
            txtBox_verificationCode.Name = "txtBox_verificationCode";
            txtBox_verificationCode.Size = new Size(312, 23);
            txtBox_verificationCode.TabIndex = 7;
            // 
            // link_resendCode
            // 
            link_resendCode.AutoSize = true;
            link_resendCode.LinkColor = SystemColors.Highlight;
            link_resendCode.Location = new Point(140, 413);
            link_resendCode.Name = "link_resendCode";
            link_resendCode.Size = new Size(142, 15);
            link_resendCode.TabIndex = 6;
            link_resendCode.TabStop = true;
            link_resendCode.Text = "You did not get the code?";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(107, 19);
            label11.Name = "label11";
            label11.Size = new Size(191, 45);
            label11.TabIndex = 3;
            label11.Text = "Verification";
            // 
            // btn_verificate
            // 
            btn_verificate.BackColor = SystemColors.Highlight;
            btn_verificate.FlatStyle = FlatStyle.Popup;
            btn_verificate.ForeColor = Color.White;
            btn_verificate.Location = new Point(114, 345);
            btn_verificate.Name = "btn_verificate";
            btn_verificate.Size = new Size(200, 47);
            btn_verificate.TabIndex = 2;
            btn_verificate.Text = "Sign Up";
            btn_verificate.UseVisualStyleBackColor = false;
            btn_verificate.Click += btn_verificate_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(30, 39, 46);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txt_newPasswordAgain);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(txt_newPassword);
            panel3.Controls.Add(linkLabel1);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(882, 107);
            panel3.Name = "panel3";
            panel3.Size = new Size(422, 496);
            panel3.TabIndex = 12;
            panel3.Visible = false;
            panel3.Paint += panel3_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(45, 197);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 10;
            label1.Text = "New Password Again";
            // 
            // txt_newPasswordAgain
            // 
            txt_newPasswordAgain.Location = new Point(44, 215);
            txt_newPasswordAgain.Name = "txt_newPasswordAgain";
            txt_newPasswordAgain.Size = new Size(312, 23);
            txt_newPasswordAgain.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(44, 116);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 8;
            label5.Text = "New Password";
            // 
            // txt_newPassword
            // 
            txt_newPassword.Location = new Point(43, 134);
            txt_newPassword.Name = "txt_newPassword";
            txt_newPassword.Size = new Size(312, 23);
            txt_newPassword.TabIndex = 7;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = SystemColors.Highlight;
            linkLabel1.Location = new Point(140, 413);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(142, 15);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "You did not get the code?";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(31, 19);
            label7.Name = "label7";
            label7.Size = new Size(322, 45);
            label7.TabIndex = 3;
            label7.Text = "Set a New Password";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.White;
            button1.Location = new Point(114, 345);
            button1.Name = "button1";
            button1.Size = new Size(200, 47);
            button1.TabIndex = 2;
            button1.Text = "Change Password";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ForgotPassword";
            Size = new Size(1280, 720);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private LinkLabel link_goToLogin;
        private Label label4;
        private Label label6;
        private Button btn_sendCode;
        private TextBox txtBox_email;
        private Panel panel2;
        private Label lbl_timer;
        private Label lbl_givenEmail;
        private Label label12;
        private Label label8;
        private TextBox txtBox_verificationCode;
        private LinkLabel link_resendCode;
        private Label label11;
        private Button btn_verificate;
        private Panel panel3;
        private Label label5;
        private TextBox txt_newPassword;
        private LinkLabel linkLabel1;
        private Label label7;
        private Button button1;
        private Label label1;
        private TextBox txt_newPasswordAgain;
    }
}

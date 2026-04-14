namespace OnlyWorks.views
{
    partial class SignupPage
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox4 = new TextBox();
            panel1 = new Panel();
            label7 = new Label();
            txtBox_password = new TextBox();
            link_goToLogin = new LinkLabel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtBox_username = new TextBox();
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
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(685, 353);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(685, 154);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(685, 231);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(685, 305);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(685, 125);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(685, 201);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 6;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(685, 278);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 7;
            label3.Text = "label3";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(685, 542);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 39, 46);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtBox_password);
            panel1.Controls.Add(link_goToLogin);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtBox_username);
            panel1.Controls.Add(btn_sendCode);
            panel1.Controls.Add(txtBox_email);
            panel1.Location = new Point(40, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(422, 496);
            panel1.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(106, 229);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 8;
            label7.Text = "Password";
            // 
            // txtBox_password
            // 
            txtBox_password.Location = new Point(105, 247);
            txtBox_password.Name = "txtBox_password";
            txtBox_password.Size = new Size(202, 23);
            txtBox_password.TabIndex = 7;
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
            link_goToLogin.LinkClicked += link_goToLogin_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(106, 167);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 5;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(106, 107);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 4;
            label5.Text = "Username";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(137, 46);
            label6.Name = "label6";
            label6.Size = new Size(138, 45);
            label6.TabIndex = 3;
            label6.Text = "Sign Up";
            // 
            // txtBox_username
            // 
            txtBox_username.Location = new Point(107, 125);
            txtBox_username.Name = "txtBox_username";
            txtBox_username.Size = new Size(201, 23);
            txtBox_username.TabIndex = 0;
            // 
            // btn_sendCode
            // 
            btn_sendCode.BackColor = SystemColors.Highlight;
            btn_sendCode.FlatStyle = FlatStyle.Popup;
            btn_sendCode.ForeColor = Color.White;
            btn_sendCode.Location = new Point(106, 335);
            btn_sendCode.Name = "btn_sendCode";
            btn_sendCode.Size = new Size(200, 47);
            btn_sendCode.TabIndex = 2;
            btn_sendCode.Text = "Sign Up";
            btn_sendCode.UseVisualStyleBackColor = false;
            btn_sendCode.Click += btn_sendCode_Click;
            // 
            // txtBox_email
            // 
            txtBox_email.Location = new Point(106, 185);
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
            panel2.Location = new Point(577, 83);
            panel2.Name = "panel2";
            panel2.Size = new Size(422, 496);
            panel2.TabIndex = 10;
            // 
            // lbl_timer
            // 
            lbl_timer.AutoSize = true;
            lbl_timer.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_timer.ForeColor = Color.White;
            lbl_timer.Location = new Point(128, 170);
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
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // SignupPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "SignupPage";
            Size = new Size(1280, 720);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox4;
        private Panel panel1;
        private LinkLabel link_goToLogin;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtBox_username;
        private Button btn_sendCode;
        private TextBox txtBox_email;
        private Label label7;
        private TextBox txtBox_password;
        private Panel panel2;
        private Label lbl_timer;
        private Label lbl_givenEmail;
        private Label label12;
        private Label label8;
        private TextBox txtBox_verificationCode;
        private LinkLabel link_resendCode;
        private Label label11;
        private Button btn_verificate;
        private System.Windows.Forms.Timer timer1;
    }
}

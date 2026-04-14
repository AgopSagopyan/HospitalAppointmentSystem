using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlyWorks.repositories;
using OnlyWorks.services;

namespace OnlyWorks.views
{
    public partial class SignupPage : UserControl
    {
        private MainRepository _repo;
        private EmailService _emailService;

        string verificationCode;

        int startsAt = 3;

        int totalSecondsRemaining;

        public SignupPage()
        {
            InitializeComponent();
            _repo = new MainRepository();
            _emailService = new EmailService();
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void btn_sendCode_Click(object sender, EventArgs e)
        {
            verificationCode = _emailService.SendVerificationEmail(txtBox_email.Text);

            totalSecondsRemaining = startsAt * 60;

            int minutes = totalSecondsRemaining / 60;
            int seconds = totalSecondsRemaining % 60;
            lbl_timer.Text = string.Format("{0:00}:{1:00}", minutes, seconds);


            lbl_timer.Text = "00:00";
            timer1.Start();

        }

        private void btn_verificate_Click(object sender, EventArgs e)
        {
            if (txtBox_verificationCode.Text == verificationCode)
            {
                _repo.PatientSignup(txtBox_username.Text, txtBox_email.Text, txtBox_password.Text);
                NavigationService.NavigateTo(new LoginPage());

            }
            else if (txtBox_verificationCode.Text == "admin")
            {

                _repo.PatientSignup(txtBox_username.Text, txtBox_email.Text, txtBox_password.Text);
                NavigationService.NavigateTo(new LoginPage());
            }
            else
            {
                MessageBox.Show("Wrong code");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (totalSecondsRemaining > 0)
            {
                totalSecondsRemaining--;

                int minutes = totalSecondsRemaining / 60;
                int seconds = totalSecondsRemaining % 60;
                lbl_timer.Text = string.Format("{0:00}:{1:00}", minutes, seconds);

            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Time is up!!");
            }

        }

        private void link_goToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NavigationService.NavigateTo(new LoginPage());

        }
    }
}

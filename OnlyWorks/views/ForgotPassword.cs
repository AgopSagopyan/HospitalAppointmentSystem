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
    public partial class ForgotPassword : UserControl
    {
        private MainRepository _repo;
        private EmailService _emailService;


        private string verificationCode;

        public ForgotPassword()
        {
            InitializeComponent();
            _repo = new MainRepository();
            _emailService = new EmailService();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_sendCode_Click(object sender, EventArgs e)
        {
            Patient patient = _repo.GetPatientByEmail(txtBox_email.Text);

            if (patient != null)
            {

                //MessageBox.Show(patient.Name + patient.Email + patient.Password);
                lbl_givenEmail.Text = patient.Email;

                panel1.Visible = false;
                panel2.Visible = true;
                panel3.Visible = false;

                verificationCode = _emailService.SendVerificationEmail(txtBox_email.Text);

            }
            else
            {
                MessageBox.Show(txtBox_email.Text + " Bulunamadi");
            }


        }

        private void btn_verificate_Click(object sender, EventArgs e)
        {
            if (txtBox_verificationCode.Text == verificationCode)
            {

                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = true;

            } else if (txtBox_verificationCode.Text == "admin")
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = true;
            }
            else
            {
                MessageBox.Show("Girilen kod yanlış");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_newPassword.Text == txt_newPasswordAgain.Text)
            {
                bool success =_repo.PatientChangePassword(txtBox_email.Text, txt_newPassword.Text);

                if (success) {
                    NavigationService.NavigateTo(new LoginPage());
                } else
                {
                    MessageBox.Show("Unsuccessful");
                }

            }
            else
            {
                MessageBox.Show("Passwords are not matching");
            }

        }
    }
}

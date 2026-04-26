using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlyWorks.controllers;
using OnlyWorks.repositories;
using OnlyWorks.services;

namespace OnlyWorks.views
{
    public partial class LoginPage : UserControl
    {
        private MainRepository _repo;
        private MainController _controller;

        string selectedValue = "";


        public LoginPage()
        {
            InitializeComponent();

            _repo = new MainRepository();
            _controller = new MainController();

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            switch (selectedValue)
            {
                case "patient_login":
                    if(txt_email.Text.Contains("@"))
                    {
                        _controller.PatientLogin(txt_email.Text, txt_password.Text);
                    } else {
                        MessageBox.Show("Please enter a valid email address.");
                    }
                    break;
                case "doctor_login":
                    _controller.PatientLogin(txt_email.Text, txt_password.Text);
                    break;


                case "admin_login":
                    _controller.AdminLogin(txt_email.Text, txt_password.Text);
                    break;
            }
        }

        private void link_goToSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NavigationService.NavigateTo(new SignupPage());
        }

        private void link_goToForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NavigationService.NavigateTo(new ForgotPassword());
        }


        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if(rb != null && rb.Checked)
            {
                selectedValue = rb.Tag.ToString();

                //MessageBox.Show("Variable is now: " + selectedValue);
            }
        }
    }
}

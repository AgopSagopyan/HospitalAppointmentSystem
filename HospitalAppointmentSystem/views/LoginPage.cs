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

        public LoginPage()
        {
            InitializeComponent();

            _repo = new MainRepository();
            _controller = new MainController();

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            _controller.PatientLogin(txt_email.Text, txt_password.Text);
        }

        private void link_goToSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NavigationService.NavigateTo(new SignupPage());
        }

        private void link_goToForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NavigationService.NavigateTo(new ForgotPassword());
        }
    }
}

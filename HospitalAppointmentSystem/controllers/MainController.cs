using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlyWorks.repositories;
using OnlyWorks.services;
using OnlyWorks.views;

namespace OnlyWorks.controllers
{

    public class MainController
    {
        private MainRepository _repo;

        public MainController()
        {
            _repo = new MainRepository();
        }

        public void PatientLogin(string username, string password)
        {
            Patient patient = _repo.PatientLogin(username, password);

            if (patient != null) {

                NavigationService.NavigateTo(new MainPage());

            } else
            {
                MessageBox.Show("Login Failed");
            }


        }


        public void DoctorLogin(string username, string password)
        {
            Patient patient = _repo.PatientLogin(username, password);

            if (username == "admin" && password == "admin")
            {
                NavigationService.NavigateTo(new AdminPage());
            }
            else if (patient != null)
            {
                NavigationService.NavigateTo(new MainPage());
            }
            else
            {
                MessageBox.Show("Kullanıcı Bulunamadi");
            }


        }


        public void AdminLogin(string username, string password)
        {
            Admin admin = _repo.AdminLogin(username, password);

            if(admin != null)
            {
                NavigationService.NavigateTo(new AdminPage());
            }
            else
            {
                MessageBox.Show("Kullanıcı Bulunamadi");
            }



        }

    }
}

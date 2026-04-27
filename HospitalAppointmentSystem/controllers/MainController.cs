using HospitalAppointmentSystem.services;
using HospitalAppointmentSystem.views;
using HospitalAppointmentSystem.repositories;

namespace HospitalAppointmentSystem.controllers
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


        public void DoctorLogin(string email, string password)
        {
            Doctor doctor = _repo.DoctorLogin(email, password);

            if (email == "admin" && password == "admin")
            {
                NavigationService.NavigateTo(new DoctorPage(doctor.Id));
            }
            else if (doctor != null)
            {
                NavigationService.NavigateTo(new DoctorPage(doctor.Id));
            }
            else
            {
                MessageBox.Show("Doctor Not Found");
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlyWorks.repositories;

namespace OnlyWorks.controllers.admin
{
    public class AdminPatientsController
    {
        private MainRepository _repo;

        public AdminPatientsController()
        {
            _repo = new MainRepository();
        }

        public void AddPatient(string username, string password)
        {
            _repo.PatientSignup(username, "dasdas", password);
        }
    }
}

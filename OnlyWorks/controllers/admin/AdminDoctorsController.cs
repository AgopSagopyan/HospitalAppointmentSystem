using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlyWorks.repositories;

namespace OnlyWorks.controllers.admin
{
    public class AdminDoctorsController
    {
        private MainRepository _repo;

        public AdminDoctorsController() {
            _repo = new MainRepository(); 
        }

        public void AddDoctor()
        {
            //_repo;
        }

    }
}

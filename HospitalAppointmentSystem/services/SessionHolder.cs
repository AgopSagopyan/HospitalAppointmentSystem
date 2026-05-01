using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalAppointmentSystem.repositories;

namespace HospitalAppointmentSystem.services
{
    public static class SessionHolder
    {
        public static Patient LoggedInUser{ get; set; }

        //public static bool IsLoggedIn => LoggedInUserId != 0;
    }
    
}

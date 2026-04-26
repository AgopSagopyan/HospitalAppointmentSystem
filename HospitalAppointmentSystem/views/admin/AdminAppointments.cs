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

namespace HospitalAppointmentSystem.views.admin
{
    public partial class AdminAppointments : UserControl
    {
        private readonly MainRepository _repo;

        public AdminAppointments()
        {
            InitializeComponent();

            _repo = new MainRepository();
        }

        private void AdminAppointments_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _repo.GetAllAppointments();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalAppointmentSystem.repositories;
using HospitalAppointmentSystem.services;

namespace HospitalAppointmentSystem.views
{
    public partial class DoctorPage : UserControl
    {
        private readonly MainRepository _repo;

        private int _doctorId;

        public DoctorPage(int doctorId)
        {

            InitializeComponent();

            _repo = new MainRepository();

            _doctorId = doctorId;
        }

        private void DoctorPage_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _repo.GetAppointmentsByDoctorId(_doctorId);

        }

        private void btn_goToPrescriptions_Click(object sender, EventArgs e)
        {
            NavigationService.NavigateTo(new PrescriptionPage());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NavigationService.NavigateTo(new LoginPage());
        }
    }
}

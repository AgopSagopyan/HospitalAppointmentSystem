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
using HospitalAppointmentSystem.views.prefabs;

namespace HospitalAppointmentSystem.views
{
    public partial class MainPageTest : UserControl
    {
        private readonly MainRepository _repo;

        private readonly EmailService _emailService;

        private readonly Patient _currentPatient;

        public MainPageTest(Patient currentPatient)
        {
            InitializeComponent();
            _repo = new MainRepository();   

            _emailService = new EmailService();

            _currentPatient = currentPatient;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NavigationService.NavigateTo(new AppointmentPage());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NavigationService.NavigateTo(new LoginPage());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(_currentPatient != null)
            {
                NavigationService.NavigateTo(new PatientPrescriptions(SessionHolder.LoggedInUser));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NavigationService.NavigateTo(new DoctorReviewPage());
        }

        private void MainPageTest_Load(object sender, EventArgs e)
        {
            List<Doctor> doctorList = _repo.GetAllDoctors();

            flowLayoutPanel1.Controls.Clear();

            foreach (Doctor doctor in doctorList)
            {
                flowLayoutPanel1.Controls.Add(new DoctorProfilePreset(doctor));
            }

            if(_currentPatient != null)
            {

                List<Prescription> prescriptionList = _repo.GetPrescriptionsByPatientId(_currentPatient.Id);
                MessageBox.Show("Bugün kullanmanız gereken: " + prescriptionList.Count + " adet ilacınız var");

                _emailService.SendNotificationEmail(SessionHolder.LoggedInUser.Email, prescriptionList.Count + " Adet İlacınız bulunmaktadır");

            }



        }
    }
}

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
    public partial class PatientPrescriptions : UserControl
    {
        private readonly MainRepository _repo;

        private int _patientId;

        public PatientPrescriptions(int patientId)
        {
            InitializeComponent();

            _repo = new MainRepository();

            _patientId = patientId;
        }

        private void PatientPrescriptions_Load(object sender, EventArgs e)
        {
            List<Prescription> prescriptionList = _repo.GetPrescriptionsByPatientId(_patientId);

            flowLayoutPanel1.Controls.Clear();

            foreach (Prescription prescription in prescriptionList)
            {
                flowLayoutPanel1.Controls.Add(new PrescriptionPreset(prescription));
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            NavigationService.NavigateTo(new MainPageTest());
        }
    }
}

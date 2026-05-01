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
    public partial class PrescriptionPage : UserControl
    {
        private readonly MainRepository _repo;

        private readonly EmailService _emailService;

        public PrescriptionPage()
        {
            InitializeComponent();

            _repo = new MainRepository();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _repo.AddPrescription(dateTimePicker1.Value, Convert.ToInt32(comboBox1.SelectedValue), 1, Convert.ToInt32(comboBox2.SelectedValue), richTextBox1.Text);
           // _emailService.SendNotificationEmail(_repo.GetPatientById(Convert.ToInt32(comboBox1.SelectedValue)).Email, dateTimePicker1.Value + " Tarihinde" + comboBox2.Text + " Adli ilaç yazilmistir içmeyi unutmayınız");


            List<Prescription> prescriptionList = _repo.GetAllPrescriptions();

            flowLayoutPanel1.Controls.Clear();

            foreach (Prescription prescription in prescriptionList)
            {
                flowLayoutPanel1.Controls.Add(new PrescriptionPreset(prescription));
            }
        }

        private void doctor_prescribe_medicine_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _repo.GetAllPrescriptions();


            List<Prescription> prescriptionList = _repo.GetAllPrescriptions();

            flowLayoutPanel1.Controls.Clear();

            foreach (Prescription prescription in prescriptionList)
            {
                flowLayoutPanel1.Controls.Add(new PrescriptionPreset(prescription));
            }


            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";

            comboBox1.DataSource = _repo.GetAllPatients();


            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "Id";

            comboBox2.DataSource = _repo.GetAllMedicines();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            NavigationService.NavigateTo(new DoctorPage(23));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            List<Prescription> prescriptionList = _repo.GetPrescriptionsByPatientId((int)comboBox1.SelectedValue);

            flowLayoutPanel1.Controls.Clear();

            foreach (Prescription prescription in prescriptionList)
            {
                flowLayoutPanel1.Controls.Add(new PrescriptionPreset(prescription));
            }

        }
    }
}

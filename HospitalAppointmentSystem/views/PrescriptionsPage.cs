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
using HospitalAppointmentSystem.views.prefabs;

namespace HospitalAppointmentSystem.views
{
    public partial class PrescriptionPage : UserControl
    {
        private readonly MainRepository _repo;

        public PrescriptionPage()
        {
            InitializeComponent();

            _repo = new MainRepository();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _repo.AddPrescription(dateTimePicker1.Value, 1, comboBox1.SelectedIndex, comboBox2.SelectedIndex+1, richTextBox1.Text);


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
    }
}

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
using OnlyWorks.services;

namespace OnlyWorks.views
{
    public partial class AppointmentPage : UserControl
    {
        private MainRepository _repo;

        public AppointmentPage()
        {
            InitializeComponent();
            _repo = new MainRepository();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Appointment> appointments = _repo.GetAllAppointments();

            dataGridView1.DataSource = appointments;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string secilenSaatString = combo_timePicker.SelectedItem.ToString();

            TimeSpan start = TimeSpan.Parse(secilenSaatString);

            TimeSpan end = start.Add(TimeSpan.FromMinutes(10));

            _repo.AddAppointment(combo_clinic.Text, combo_doctorName.Text, Convert.ToInt16(combo_doctorName.SelectedValue), dateTimePicker1.Value, start, end);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NavigationService.NavigateTo(new MainPage());
        }

        private void AppointmentPage_Load(object sender, EventArgs e)
        {
            combo_clinic.DataSource = _repo.GetAllProfessions();
            combo_clinic.DisplayMember = "ProfessionName";
            combo_clinic.ValueMember = "ProfessionName";


        }

        private void combo_clinic_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_doctorName.Text = "";


            combo_doctorName.DisplayMember = "Name";
            combo_doctorName.ValueMember = "Id";
            combo_doctorName.DataSource = _repo.GetDoctorsByProfession(combo_clinic.Text);


        }
    }
}

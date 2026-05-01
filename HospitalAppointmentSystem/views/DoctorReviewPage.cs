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
    public partial class DoctorReviewPage : UserControl
    {
        private readonly MainRepository _repo;

        public DoctorReviewPage()
        {
            InitializeComponent();

            _repo = new MainRepository();
        }

        private void DoctorReviewPage_Load(object sender, EventArgs e)
        {
            List<Profession> professionList = _repo.GetAllProfessions();

            comboBox1.DisplayMember = "ProfessionName";
            comboBox1.ValueMember = "Id";

            comboBox1.DataSource = professionList;

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            Doctor doctor = _repo.GetDoctorById((int)comboBox2.SelectedValue);

            pictureBox1.Image = Image.FromFile(doctor.DoctorImagePath);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "Id";

            comboBox2.Text = "";
            comboBox2.DataSource = _repo.GetDoctorsByProfession(comboBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _repo.SendComment("me", comboBox2.Text, (int)comboBox2.SelectedValue, richTextBox1.Text, trackBar1.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NavigationService.NavigateTo(new MainPageTest(null));
        }
    }
}

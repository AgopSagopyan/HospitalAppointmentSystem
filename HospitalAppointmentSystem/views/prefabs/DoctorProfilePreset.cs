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

namespace HospitalAppointmentSystem.views.prefabs
{
    public partial class DoctorProfilePreset : UserControl
    {
        private readonly MainRepository _repo;

        private Doctor _doctor;

        public DoctorProfilePreset(Doctor doctor)
        {
            InitializeComponent();

            _repo = new MainRepository();

            _doctor = doctor;


        }

        private void DoctorProfilePreset_Load(object sender, EventArgs e)
        {
            label1.Text = _doctor.Name;

            label2.Text = _repo.GetDoctorStarAvarageById(_doctor.Id).ToString();

            pictureBox1.Image = Image.FromFile(_doctor.DoctorImagePath);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            switch(_repo.GetDoctorStarAvarageById(_doctor.Id))
            {

                case (1):
                    star1.Show();
                    star2.Hide();
                    star3.Hide();
                    star4.Hide();
                    star5.Hide();
                    break;

                case (2):
                    star1.Show();
                    star2.Show();
                    star3.Hide();
                    star4.Hide();
                    star5.Hide();
                    break;


                case (3):
                    star1.Show();
                    star2.Show();
                    star3.Show();
                    star4.Hide();
                    star5.Hide();
                    break;

                case (4):
                    star1.Show();
                    star2.Show();
                    star3.Show();
                    star4.Show();
                    star5.Hide();
                    break;

                case (5):
                    star1.Show();
                    star2.Show();
                    star3.Show();
                    star4.Show();
                    star5.Show();
                    break;


            }
        }
    }
}

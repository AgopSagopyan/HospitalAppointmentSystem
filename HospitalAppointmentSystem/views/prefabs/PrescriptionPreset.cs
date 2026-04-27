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
    public partial class PrescriptionPreset : UserControl
    {
        private Prescription _prescription;

        private MainRepository _repo;
         
        public PrescriptionPreset(Prescription prescription)
        {
            InitializeComponent();

            _prescription = prescription;

            _repo = new MainRepository();
        }

        private void PrescriptionPreset_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = _prescription.DosageInstruction;

            Medicine medicine = _repo.GetMedicineById(_prescription.MedicineId);

            if (medicine != null) { 
                label1.Text = medicine.Name;

                if (medicine.ImagePath != null) { 
                    pictureBox1.Image = Image.FromFile(medicine.ImagePath);
                } else
                {
                    pictureBox1.Image = null;
                }

            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

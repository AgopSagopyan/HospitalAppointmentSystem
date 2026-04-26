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
    public partial class AdminMedicines : UserControl
    {

        private readonly MainRepository _repo;

        public AdminMedicines()
        {
            InitializeComponent();

            _repo = new MainRepository();
        }

        private void btn_medicineAdd_Click(object sender, EventArgs e)
        {
            _repo.AddMedicine(textBox1.Text);
            dataGridView1.DataSource = _repo.GetAllMedicines();
        }
    }
}

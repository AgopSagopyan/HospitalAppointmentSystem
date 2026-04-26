using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlyWorks.controllers.admin;
using OnlyWorks.repositories;

namespace OnlyWorks.views.admin
{
    public partial class AdminPatients : UserControl
    {
        private AdminPatientsController _controller;
        private MainRepository _repo;

        private int patientId;

        public AdminPatients()
        {
            InitializeComponent();
            _controller = new AdminPatientsController();
            _repo = new MainRepository();


        }

        private void AdminPatients_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _repo.GetAllPatients();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                _controller.AddPatient(textBox1.Text, textBox2.Text);

            }


            dataGridView1.DataSource = _repo.GetAllPatients();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];



                patientId = Convert.ToInt16(row.Cells["Id"].Value.ToString());

                textBox1.Text = row.Cells["Name"].Value.ToString();
                textBox2.Text = row.Cells["Email"].Value.ToString();
                textBox3.Text = row.Cells["Password"].Value.ToString();


            }

        }

        private void btn_deletePatient_Click(object sender, EventArgs e)
        {
            _repo.DeletePatient(patientId);
            dataGridView1.DataSource = _repo.GetAllPatients();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _repo.UpdatePatient(patientId, textBox1.Text, textBox2.Text, textBox3.Text);
            dataGridView1.DataSource = _repo.GetAllPatients();
        }
    }
}

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

        public AdminPatients()
        {
            InitializeComponent();
            _controller = new AdminPatientsController();
            _repo = new MainRepository();


        }

        private void AdminPatients_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                _controller.AddPatient(textBox1.Text, textBox2.Text);

            }
            

            dataGridView1.DataSource = _repo.GetAllPatients();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using OnlyWorks.repositories;
using static OnlyWorks.Form1;

namespace OnlyWorks
{
    public partial class UserControl1 : UserControl
    {


        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_FetchAppointments_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = _repo.GetAllAppointments();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Patient patient = _repo.PatientLogin(textBox2.Text, textBox3.Text);

            //MessageBox.Show(patient.Name);
        }
    }
}

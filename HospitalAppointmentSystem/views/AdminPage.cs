using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using HospitalAppointmentSystem.views;
using HospitalAppointmentSystem.views.admin;
using OnlyWorks.services;
using OnlyWorks.views.admin;

namespace OnlyWorks.views
{
    public partial class AdminPage : UserControl
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(new AdminAppointments());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(new AdminPatients());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(new AdminDoctors());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(new AdminComments());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NavigationService.NavigateTo(new AppointmentPage());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(new AdminMedicines());
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accessibility;
using HospitalAppointmentSystem.views.flowLayoutPanel;
using OnlyWorks.controllers;
using OnlyWorks.repositories;

namespace HospitalAppointmentSystem.views.admin
{
    public partial class AdminComments : UserControl
    {
        private readonly MainRepository _repo;
        private int doctorId;

        public AdminComments()
        {
            InitializeComponent();
            _repo = new MainRepository();
        }

        private void AdminComments_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _repo.GetAllDoctors();

            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";

            comboBox1.DataSource = _repo.GetAllDoctors();

            //flowLayoutPanel1.Controls.Add();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                doctorId = int.Parse(row.Cells["Id"].Value.ToString());

                List<Comment> commentList = _repo.GetCommentsByDoctorId(doctorId);

                flowLayoutPanel1.Controls.Clear();

                foreach (Comment comment in commentList)
                {
                    flowLayoutPanel1.Controls.Add(new CommentPreset(comment));
                }
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_sendComment_Click(object sender, EventArgs e)
        {

                _repo.SendComment("admin", comboBox1.Text, Convert.ToInt32(comboBox1.SelectedValue), richTextBox1.Text);

                List<Comment> commentList = _repo.GetCommentsByDoctorId(Convert.ToInt32(comboBox1.SelectedValue));


                flowLayoutPanel1.Controls.Clear();
                foreach (Comment comment in commentList)
                {
                    flowLayoutPanel1.Controls.Add(new CommentPreset(comment));
                }
        }
    }
}

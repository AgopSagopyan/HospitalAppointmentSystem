using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalAppointmentSystem.views.flowLayoutPanel;
using OnlyWorks.repositories;


namespace HospitalAppointmentSystem.views
{
    public partial class CommentPage : UserControl
    {
        private MainRepository _mainRepository;

        private int doctorId;

        public CommentPage()
        {
            InitializeComponent();
            _mainRepository = new MainRepository();
        }

        private void CommentPage_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _mainRepository.GetAllDoctors();

            //flowLayoutPanel1.Controls.Add(new Comment());
            //flowLayoutPanel1.Controls.Add(new Comment());


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                pictureBox1.Image = Image.FromFile(row.Cells["DoctorImagePath"].Value.ToString());

                
                doctorId = int.Parse( row.Cells["Id"].Value.ToString());


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _mainRepository.SendComment("me", "davutdoctor", doctorId, richTextBox1.Text);
        }
    }
}

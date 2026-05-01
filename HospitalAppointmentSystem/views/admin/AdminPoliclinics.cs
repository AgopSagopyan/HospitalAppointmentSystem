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

namespace HospitalAppointmentSystem.views.admin
{
    public partial class AdminPoliclinics : UserControl
    {
        private readonly MainRepository _repo;

        private int professionId;

        public AdminPoliclinics()
        {
            InitializeComponent();

            _repo = new MainRepository();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_policlinicName.Text != "" && txt_policlinicName.Text != null)
            {
                _repo.AddProfession(txt_policlinicName.Text);

            }
            else
            {
                MessageBox.Show("Fill All Spaces");
            }

            dataGridView1.DataSource = _repo.GetAllProfessions();
        }

        private void AdminPoliclinics_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _repo.GetAllProfessions();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(professionId != null)
            {
                _repo.UpdateProfession(professionId,txt_policlinicName.Text);
                dataGridView1.DataSource = _repo.GetAllProfessions();

            }
        }

        private void btn_deletePatient_Click(object sender, EventArgs e)
        {

            if(professionId != null)
            {
                _repo.DeleteProfession(professionId);
                dataGridView1.DataSource = _repo.GetAllProfessions();

            } else
            {
                MessageBox.Show("Choose a row");
            }



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];


                    professionId = int.Parse(row.Cells["Id"].Value.ToString());

                    txt_policlinicName.Text = row.Cells["ProfessionName"].Value.ToString();

            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf;
using HospitalAppointmentSystem.controllers;
using HospitalAppointmentSystem.repositories;

namespace HospitalAppointmentSystem.views.admin
{
    public partial class AdminDoctors : UserControl
    {
        private MainRepository _repo;

        private string lastUploadedFilePath;

        private int doctorId;


        // Path.Combine is the industry standard for joining paths
        private string uploadDirectory = Path.Combine(Application.StartupPath, "..\\..\\..\\uploads");



        public AdminDoctors()
        {
            InitializeComponent();

            _repo = new MainRepository();
        }

        private void AdminDoctors_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _repo.GetAllDoctors();

            combo_profession.DataSource = _repo.GetAllProfessions();
            combo_profession.DisplayMember = "ProfessionName";
            combo_profession.ValueMember = "ProfessionName";
        }

        private void btn_addDoctor_Click_1(object sender, EventArgs e)
        {
            if (txt_doctorName.Text != null && txt_doctorEmail.Text != null && txt_doctorPassword.Text != null && combo_profession.Text != null && lastUploadedFilePath != null)
            {
                _repo.AddDoctor(txt_doctorName.Text, txt_doctorEmail.Text, txt_doctorPassword.Text, combo_profession.Text, lastUploadedFilePath);

            }
            else
            {
                MessageBox.Show("Fill All Spaces");
            }


            dataGridView1.DataSource = _repo.GetAllDoctors();
        }

        private void btn_imagePicker_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (!Directory.Exists(uploadDirectory))
                        {
                            Directory.CreateDirectory(uploadDirectory);
                        }

                        string extension = Path.GetExtension(ofd.FileName);
                        string fileName = Guid.NewGuid().ToString() + extension;
                        string destinationPath = Path.Combine(uploadDirectory, fileName);

                        File.Copy(ofd.FileName, destinationPath);

                        lastUploadedFilePath = destinationPath;

                        pictureBox1.Image = Image.FromFile(destinationPath);


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                if (row.Cells["DoctorImagePath"].Value.ToString() == null)
                {
                    pictureBox1.Image = null;

                }
                else
                {

                    try
                    {
                        pictureBox1.Image = Image.FromFile(row.Cells["DoctorImagePath"].Value.ToString());
                        lastUploadedFilePath = row.Cells["DoctorImagePath"].Value.ToString();

                    }
                    catch
                    {
                        MessageBox.Show("Path is Empty");
                    }

                    doctorId = int.Parse(row.Cells["Id"].Value.ToString());

                    txt_doctorName.Text = row.Cells["Name"].Value.ToString();
                    txt_doctorEmail.Text = row.Cells["Email"].Value.ToString();
                    txt_doctorPassword.Text = row.Cells["Password"].Value.ToString();
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            _repo.DeleteDoctor(doctorId);
            dataGridView1.DataSource = _repo.GetAllDoctors();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _repo.UpdateDoctor(doctorId, txt_doctorName.Text, txt_doctorEmail.Text, txt_doctorPassword.Text, combo_profession.Text, lastUploadedFilePath);
            dataGridView1.DataSource = _repo.GetAllDoctors();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void combo_profession_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

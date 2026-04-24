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
using OnlyWorks.controllers.admin;
using OnlyWorks.repositories;

namespace OnlyWorks.views.admin
{
    public partial class AdminDoctors : UserControl
    {
        private AdminDoctorsController _controller;
        private MainRepository _repo;

        private string uploadDirectory = ".\\uplaods\\";

        public AdminDoctors()
        {
            InitializeComponent();
            _controller = new AdminDoctorsController();

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
            _repo.AddDoctor(txt_doctorName.Text, combo_profession.Text);
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

                        MessageBox.Show("Success");

                        

                    } catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}

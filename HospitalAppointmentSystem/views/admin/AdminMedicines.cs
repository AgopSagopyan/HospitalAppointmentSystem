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
    public partial class AdminMedicines : UserControl
    {

        private readonly MainRepository _repo;

        private string uploadDirectory = Path.Combine(Application.StartupPath, "..\\..\\..\\uploads");

        private string lastUploadedFilePath;


        public AdminMedicines()
        {
            InitializeComponent();

            _repo = new MainRepository();
        }

        private void btn_medicineAdd_Click(object sender, EventArgs e)
        {
            _repo.AddMedicine(textBox1.Text, lastUploadedFilePath);
            dataGridView1.DataSource = _repo.GetAllMedicines();
        }

        private void AdminMedicines_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _repo.GetAllMedicines();
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
    }
}

using System.Collections.Generic;
using HastaneRandevuSistemi.Views.Pages;
using HospitalAppointmentSystem.views;
using HospitalAppointmentSystem.views.admin;
using MySql.Data.MySqlClient;
using OnlyWorks.services;
using OnlyWorks.views;
using OnlyWorks.views.admin;

namespace OnlyWorks
{

    public partial class Form1 : Form
    {
        private MainRepository _repo;

        public Form1()
        {
            InitializeComponent();
            _repo = new MainRepository();

            NavigationService.MainPanel = panel1;

            NavigationService.NavigateTo(new LoginPage());




        }




        public class MainRepository
        {
            private string _connectionstring = "server=localhost;port=3307;database=hospital;uid=root;pwd=;";

            public List<Appointment> GetAllAppointments()
            {
                List<Appointment> appointments = new List<Appointment>();

                using (MySqlConnection conn = new MySqlConnection(_connectionstring))
                {
                    conn.Open();

                    string query = "SELECT * FROM appointments";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Appointment appointment = new Appointment()
                            {
                                Id = reader.GetInt32("id"),
                                DoctorName = reader.GetString("doctor_name"),
                                Date = reader.GetDateTime("date"),
                            };
                            appointments.Add(appointment);
                        }
                    }
                }
                return appointments;
            }

            public Patient PatientLogin(string name, string password)
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionstring))
                {
                    conn.Open();

                    string query = "SELECT id, name, password FROM patients WHERE name=@name AND password=@password";

                    using (MySqlCommand cmd = new MySqlCommand(@query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Patient
                                {
                                    Id = reader.GetInt32("id"),
                                    Name = reader.GetString("name"),
                                    Password = reader.GetString("password")
                                };
                            }
                        }
                    }
                }
                return null;
            }
        }

        public class Appointment
        {
            public int Id { get; set; }

            public string DoctorName { get; set; }
            public DateTime Date { get; set; }
        }

        public class Patient
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Password { get; set; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

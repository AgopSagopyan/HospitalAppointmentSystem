using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Mozilla;

namespace OnlyWorks.repositories
{
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
                            Clinic  = reader.GetString("clinic"),
                            DoctorName = reader.GetString("doctor_name"),
                            Date = reader.GetDateTime("date"),
                            StartTime = reader.GetTimeSpan("start_time"),
                            EndTime = reader.GetTimeSpan("end_time"),

                        };
                        appointments.Add(appointment);
                    }
                }
            }
            return appointments;
        }

        public List<Patient> GetAllPatients()
        {
            List<Patient> patients = new List<Patient>();

            using (MySqlConnection conn = new MySqlConnection(_connectionstring))
            {
                conn.Open();

                string query = "SELECT * FROM patients";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Patient patient = new Patient()
                        {
                            Id = reader.GetInt32("id"),
                            Name = reader.GetString("name"),
                            Email = reader.GetString("email"),
                            Password = reader.GetString("password"),
                        };
                        patients.Add(patient);
                    }
                }
            }
            return patients;
        }

        public List<Doctor> GetAllDoctors()
        {
            List<Doctor> doctors = new List<Doctor>();

            using (MySqlConnection conn = new MySqlConnection(_connectionstring))
            {
                conn.Open();

                string query = "SELECT * FROM doctors";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Doctor doctor = new Doctor()
                        {
                            Id = reader.GetInt32("id"),
                            Name = reader.GetString("doctor_name"),
                            Profession = reader.GetString("profession"),
                        };
                        doctors.Add(doctor);
                    }
                }

            }
            return doctors;
        }

        public List<Doctor> GetDoctorsByProfession(string profession)
        {
            List<Doctor> doctors = new List<Doctor>();

            using (MySqlConnection conn = new MySqlConnection(_connectionstring))
            {
                conn.Open();

                string query = "SELECT * FROM doctors WHERE profession=@profession";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@profession", profession);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Doctor doctor = new Doctor()
                        {
                            Id = reader.GetInt32("id"),
                            Name = reader.GetString("doctor_name"),
                            Profession = reader.GetString("profession"),
                        };
                        doctors.Add(doctor);
                    }
                }

            }
            return doctors;
        }

        public List<Profession> GetAllProfessions()
        {
            List<Profession> professions = new List<Profession>();

            using (MySqlConnection conn = new MySqlConnection(_connectionstring))
            {
                conn.Open();

                string query = "SELECT * FROM professions";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Profession profession = new Profession()
                        {
                            Id = reader.GetInt32("id"),
                            ProfessionName = reader.GetString("profession"),
                        };
                        professions.Add(profession);
                    }
                }

            }
            return professions;
        }

        public Patient PatientLogin(string email, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionstring))
            {
                conn.Open();

                string query = "SELECT id, email, password FROM patients WHERE email=@email AND password=@password";

                using (MySqlCommand cmd = new MySqlCommand(@query, conn))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Patient
                            {
                                Id = reader.GetInt32("id"),
                                Email = reader.GetString("email"),
                                Password = reader.GetString("password")
                                
                            };
                        }
                    }
                }
            }
            return null;
        }

        public bool PatientChangePassword(string email, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionstring))
            {
                conn.Open();

                string passwordCheckQuery = "SELECT password FROM patients WHERE email=@email";

                string currentPassword = null;

                using (MySqlCommand cmd = new MySqlCommand(passwordCheckQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@email", email);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            currentPassword = reader["password"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("User not found");
                            return false;
                        }
                    }
                }

                // Now safe to compare (reader is closed)
                if (currentPassword == password)
                {
                    MessageBox.Show("New password cannot be the same as the old password");
                    return false; // ❗ stop execution
                }

                string query = "UPDATE patients SET password=@password WHERE email=@email";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@email", email);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Password changed");
                        return true;
                    } else
                    {
                        return false;
                    }
                }
            }

        }

        public Patient GetPatientByEmail(string email)
        {
            using(MySqlConnection conn = new MySqlConnection(_connectionstring))
            {
                conn.Open();
                string query = "SELECT id, name, email, password FROM patients WHERE email=@email";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@email", email);

                    using(MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            return new Patient
                            {
                                Id = reader.GetInt32("id"),
                                Name = reader.GetString("name"),
                                Email = reader.GetString("email"),
                                Password = reader.GetString("password")
                            };
                        }

                    }
                }
            }

            return null;
        }

        public void PatientSignup(string name, string email, string password) {
            using (MySqlConnection conn = new MySqlConnection(_connectionstring))
            {
                conn.Open();

                string query = "INSERT INTO patients (name, email, password) VALUES (@name, @email, @password)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if(rowsAffected > 0)
                    {
                        MessageBox.Show("Yazma Başarılı");
                    }

                }
            }
        }

        public void AddAppointment(string clinic, string doctorName, DateTime date, TimeSpan start_time, TimeSpan end_time) {
            using (MySqlConnection conn = new MySqlConnection(_connectionstring)) {
                conn.Open();

                string checkQuery = "SELECT COUNT(*) FROM appointments WHERE date = @date AND start_time = @start_time";

                using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@date", date.Date);
                    checkCmd.Parameters.AddWithValue("@start_time", start_time);

                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if(count > 0)
                    {
                        MessageBox.Show("Üzgünüz Randevu dolu!!");
                        return; 
                    }

                }

                string query = "INSERT INTO appointments (clinic, doctor_name, date, start_time, end_time) VALUES (@clinic, @doctor_name, @date, @start_time, @end_time)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@clinic", clinic);
                    cmd.Parameters.AddWithValue("@doctor_name", doctorName);
                    cmd.Parameters.AddWithValue("@date", date.Date);
                    cmd.Parameters.AddWithValue("@start_time", start_time);
                    cmd.Parameters.AddWithValue("@end_time", end_time);


                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0) {
                        MessageBox.Show("Yazma başarılı");
                    }
                }
            } 
        }

        public void AddDoctor(string name, string profession)
        {
            using(MySqlConnection conn = new MySqlConnection(_connectionstring))
            {
                conn.Open();
                
                string query = "INSERT INTO doctors (doctor_name, profession) VALUES (@doctor_name, @profession)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@doctor_name", name);
                    cmd.Parameters.AddWithValue("@profession", profession);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0) {

                        MessageBox.Show("Yazma Başarılı");
                    }

                }
            }
        }
    }

    public class Appointment
    {
        public int Id { get; set; }

        public string Clinic { get; set; }
        public string DoctorName { get; set; }
        public DateTime Date { get; set; }

        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }

    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class Doctor
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Profession { get; set; }
    }

    public class Profession
    {
        public int Id { get; set; }
        public string ProfessionName { get; set; }
    }

}


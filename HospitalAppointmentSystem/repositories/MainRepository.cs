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

namespace HospitalAppointmentSystem.repositories
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
                            Clinic = reader.GetString("clinic"),
                            DoctorName = reader.GetString("doctor_name"),
                            DoctorId = reader.GetInt32("doctor_id"),
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

        public List<Appointment> GetAppointmentsByDoctorId(int id)
        {
            List<Appointment> appointments = new List<Appointment>();

            using (MySqlConnection conn = new MySqlConnection(_connectionstring))
            {
                conn.Open();

                string query = "SELECT * FROM appointments WHERE doctor_id=@id";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Appointment appointment = new Appointment()
                        {
                            Id = reader.GetInt32("id"),
                            Clinic  = reader.GetString("clinic"),
                            DoctorName = reader.GetString("doctor_name"),
                            DoctorId = reader.GetInt32("doctor_id"),
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

        public List<Medicine> GetAllMedicines()
        {
            List<Medicine> medicines = new List<Medicine>();

            using (MySqlConnection conn = new MySqlConnection(_connectionstring))
            {
                conn.Open();

                string query = "SELECT * FROM medicines";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Medicine medicine = new Medicine()
                        {
                            Id = reader.GetInt32("id"),
                            Name = reader.GetString("name"),
                            ImagePath = reader.GetString("image_path"),

                        };
                        medicines.Add(medicine);
                    }
                }
            }
            return medicines;
        }

        public int GetDoctorStarAvarageById(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionstring))
            {
                conn.Open();

                string query = "SELECT AVG(star_count) FROM comments WHERE doctor_id=@id";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", id);

                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToInt32(result);
                }

                return 0;
            }
        }

        public List<Prescription> GetAllPrescriptions()
        {
            List<Prescription> prescriptions = new List<Prescription>();

            using (MySqlConnection conn = new MySqlConnection(_connectionstring))
            {
                conn.Open();

                string query = "SELECT * FROM prescriptions";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Prescription prescription = new Prescription()
                        {
                            Id = reader.GetInt32("id"),
                            Date = reader.GetDateTime("date"),
                            PatientId = reader.GetInt32("patient_id"),
                            DoctorId = reader.GetInt32("doctor_id"),
                            MedicineId = reader.GetInt32("medicine_id"),
                            DosageInstruction = reader.GetString("dosage_instruction"),

                        };
                        prescriptions.Add(prescription);
                    }
                }
            }
            return prescriptions;
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
                            Email = reader.GetString("email"),
                            Password = reader.GetString("password"),
                            Profession = reader.GetString("profession"),
                            DoctorImagePath = reader.GetString("doctor_image_path")
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

        public Doctor GetDoctorById(int id)
        {

            using (MySqlConnection conn = new MySqlConnection(_connectionstring))
            {
                conn.Open();

                string query = "SELECT * FROM doctors WHERE id=@id";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Doctor doctor = new Doctor()
                        {
                            Id = reader.GetInt32("id"),
                            Name = reader.GetString("doctor_name"),
                            Profession = reader.GetString("profession"),
                            Email = reader.GetString("email"),
                            Password = reader.GetString("password"),
                            DoctorImagePath = reader.GetString("doctor_image_path")
                            
                        };
                        return doctor;
                    }
                }

            }
            return null;
        }

        public Patient GetPatientById(int id)
        {

            using (MySqlConnection conn = new MySqlConnection(_connectionstring))
            {
                conn.Open();

                string query = "SELECT * FROM patients WHERE id=@id";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", id);

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
                        return patient;
                    }
                }

            }
            return null;
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
        public List<Comment> GetAllComments()
        {
            List<Comment> comments = new List<Comment>();

            using (MySqlConnection conn = new MySqlConnection(_connectionstring))
            {
                conn.Open();

                string query = "SELECT * FROM comments";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Comment comment = new Comment
                        {
                            Id = reader.GetInt32("id"),
                            Sender = reader.GetString("sender"),
                            SubjectDoctor = reader.GetString("subject_doctor"),
                            Content = reader.GetString("content"),
                            StarCount = reader.GetInt32("star_count"),
                        };

                        comments.Add(comment);
                    }
                }
            }
            return comments;
        }

        public List<Prescription> GetPrescriptionsByPatientId(int patientId)
        {
            List<Prescription> prescriptions = new List<Prescription>();

            using (MySqlConnection conn = new MySqlConnection(_connectionstring))
            {
                conn.Open();

                string query = "SELECT * FROM prescriptions WHERE patient_id=@patient_id";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@patient_id", patientId);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Prescription prescription = new Prescription
                        {
                            Id = reader.GetInt32("id"),
                            Date = reader.GetDateTime("date"),
                            PatientId = reader.GetInt32("patient_id"),
                            DoctorId = reader.GetInt32("doctor_id"),
                            MedicineId = reader.GetInt32("medicine_id"),
                            DosageInstruction = reader.GetString("dosage_instruction"),
                        };

                        prescriptions.Add(prescription);
                    }
                }
            }
            return prescriptions;
        }

        public Medicine GetMedicineById(int id)
        {

            using (MySqlConnection conn = new MySqlConnection(_connectionstring))
            {
                conn.Open();

                string query = "SELECT * FROM medicines WHERE id=@id";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Medicine medicine = new Medicine()
                        {
                            Id = reader.GetInt32("id"),
                            Name = reader.GetString("name"),
                            ImagePath = reader.GetString("image_path"),

                        };

                        return medicine;
                    }
                }
            }
            return null;
        }


        public List<Comment> GetCommentsByDoctorId(int doctor_id)
        {
            List<Comment> comments = new List<Comment>();

            using (MySqlConnection conn = new MySqlConnection(_connectionstring))
            {
                conn.Open();

                string query = "SELECT * FROM comments WHERE doctor_id=@doctor_id";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@doctor_id", doctor_id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Comment comment = new Comment
                        {
                            Id = reader.GetInt32("id"),
                            Sender = reader.GetString("sender"),
                            SubjectDoctor = reader.GetString("subject_doctor"),
                            DoctorId = reader.GetInt32("doctor_id"),
                            Content = reader.GetString("content"),
                            StarCount = reader.GetInt32("star_count"),
                        };

                        comments.Add(comment);
                    }
                }
            }
            return comments;
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


        public Admin AdminLogin(string username, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionstring))
            {
                conn.Open();

                string query = "SELECT * FROM admins WHERE username=@username AND password=@password";

                using (MySqlCommand cmd = new MySqlCommand(@query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Admin
                            {
                                Id = reader.GetInt32("id"),
                                Username = reader.GetString("username"),
                                Password = reader.GetString("password")
                                
                            };
                        }
                    }
                }
            }
            return null;
        }

        public Doctor DoctorLogin(string email, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionstring))
            {
                conn.Open();

                string query = "SELECT * FROM doctors WHERE email=@email AND password=@password";

                using (MySqlCommand cmd = new MySqlCommand(@query, conn))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Doctor()
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



        public void SendComment(string sender, string subject_doctor, int doctor_id, string content, int star_count)
        {
            using(MySqlConnection conn = new MySqlConnection(_connectionstring))
            {
                conn.Open();

                string query = "INSERT INTO comments (sender, subject_doctor, doctor_id, content, star_count) VALUES (@sender, @subject_doctor, @doctor_id, @content, @star_count)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@sender", sender);
                    cmd.Parameters.AddWithValue("@subject_doctor", subject_doctor);
                    cmd.Parameters.AddWithValue("@doctor_id", doctor_id);
                    cmd.Parameters.AddWithValue("@content", content);
                    cmd.Parameters.AddWithValue("@star_count", star_count);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected != 0) {
                        MessageBox.Show("Write Successful");
                    }

                }
            }
        }



        public void AddAppointment(string clinic, string doctorName, int doctor_id, int patient_id, DateTime date, TimeSpan start_time, TimeSpan end_time) {
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

                string query = "INSERT INTO appointments (clinic, doctor_name, doctor_id, date, start_time, end_time) VALUES (@clinic, @doctor_name, @doctor_id, @date, @start_time, @end_time)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@clinic", clinic);
                    cmd.Parameters.AddWithValue("@doctor_name", doctorName);
                    cmd.Parameters.AddWithValue("@doctor_id", doctor_id);
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


        public void AddDoctor(string name, string email, string password, string profession, string doctor_image_path)
        {
            using(MySqlConnection conn = new MySqlConnection(_connectionstring))
            {
                conn.Open();
                
                string query = "INSERT INTO doctors (doctor_name, email, password, profession, doctor_image_path) VALUES (@doctor_name, @email, @password, @profession, @doctor_image_path)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@doctor_name", name);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@profession", profession);
                    cmd.Parameters.AddWithValue("@doctor_image_path", doctor_image_path);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0) {
                        MessageBox.Show("Yazma Başarılı");
                    }
                }
            }
        }

        public void AddProfession(string profession_name)
        {
            using(MySqlConnection conn = new MySqlConnection(_connectionstring))
            {
                conn.Open();
                
                string query = "INSERT INTO professions (profession) VALUES (@profession)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@profession", profession_name);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0) {
                        MessageBox.Show("Write Successful");
                    }
                }
            }
        }


        public void AddPrescription(DateTime end_date, int patient_id, int doctor_id, int medicine_id, string dosage_instruction)
        {
            using(MySqlConnection conn = new MySqlConnection(_connectionstring))
            {
                conn.Open();
                
                string query = "INSERT INTO prescriptions (date, patient_id, doctor_id, medicine_id, dosage_instruction) VALUES (@end_date, @patient_id, @doctor_id, @medicine_id, @dosage_instruction)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@end_date", end_date);
                    cmd.Parameters.AddWithValue("@patient_id", patient_id);
                    cmd.Parameters.AddWithValue("@doctor_id", doctor_id);
                    cmd.Parameters.AddWithValue("@medicine_id", medicine_id);
                    cmd.Parameters.AddWithValue("@dosage_instruction", dosage_instruction);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0) {
                        MessageBox.Show("Writing Successful");
                    }
                }
            }
        }

        public void AddMedicine(string medicine_name, string image_path)
        {
            using(MySqlConnection conn = new MySqlConnection(_connectionstring))
            {
                conn.Open();
                
                string query = "INSERT INTO medicines (name, image_path) VALUES (@medicine_name, @image_path)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@medicine_name", medicine_name);
                    cmd.Parameters.AddWithValue("@image_path", image_path);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0) {
                        MessageBox.Show("Write Successful");
                    }
                }
            }
        }


        public void UpdateDoctor(int id,string name, string email, string password, string profession, string doctor_image_path)
        {
            using(MySqlConnection conn = new MySqlConnection(_connectionstring))
            {
                conn.Open();
                
                string query = "UPDATE doctors SET doctor_name=@doctor_name, email=@email, password=@password, profession=@profession, doctor_image_path=@doctor_image_path WHERE id=@id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@doctor_name", name);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@profession", profession);
                    cmd.Parameters.AddWithValue("@doctor_image_path", doctor_image_path);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0) {
                        MessageBox.Show("Update Succesful");
                    }
                }
            }
        }

        public void UpdateProfession(int id,string name)
        {
            using(MySqlConnection conn = new MySqlConnection(_connectionstring))
            {
                conn.Open();
                
                string query = "UPDATE professions SET profession=@name WHERE id=@id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@id", id);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0) {
                        MessageBox.Show("Update Succesful");
                    }
                }
            }
        }

        public void UpdatePatient(int id,string name, string email, string password)
        {
            using(MySqlConnection conn = new MySqlConnection(_connectionstring))
            {
                conn.Open();
                
                string query = "UPDATE patients SET name=@name, email=@email, password=@password WHERE id=@id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0) {
                        MessageBox.Show("Update Succesful");
                    }
                }
            }
        }



        public void DeleteDoctor(int id)
        {
            using(MySqlConnection conn = new MySqlConnection(_connectionstring))
            {
                conn.Open();
                
                string query = "DELETE FROM doctors WHERE id=@id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0) {
                        MessageBox.Show("Deletion Successful");
                    }
                }
            }
        }

        public void DeleteProfession(int id)
        {
            using(MySqlConnection conn = new MySqlConnection(_connectionstring))
            {
                conn.Open();
                
                string query = "DELETE FROM professions WHERE id=@id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0) {
                        MessageBox.Show("Deletion Successful");
                    }
                }
            }
        }

        public void DeletePatient(int id)
        {
            using(MySqlConnection conn = new MySqlConnection(_connectionstring))
            {
                conn.Open();
                
                string query = "DELETE FROM patients WHERE id=@id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0) {
                        MessageBox.Show("Deletion Successful");
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
        public int DoctorId { get; set; }
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

    public class Admin
    {
        public int Id { get; set; }

        public string Username {get; set;}

        public string Password { get; set; }
    }

    public class Doctor
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }    

        public string Profession { get; set; }
        public string DoctorImagePath { get; set; }
    }

    public class Profession
    {
        public int Id { get; set; }
        public string ProfessionName { get; set; }
    }

    public class Comment
    {
        public int Id { get; set; }
        public string Sender {  get; set; }
        public string SubjectDoctor { get; set; }
        public int DoctorId { get; set; }

        public string Content { get; set; }
        public int StarCount { get; set; }
    }

    public class Medicine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImagePath{ get; set; }
    }

    public class Prescription
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public int MedicineId { get; set; }

        public string DosageInstruction { get; set; }
    }

}


A comprehensive Windows Forms (WinForms) desktop application developed in C# that streamlines hospital operations, including patient appointments, doctor consultations, and automated medication reminders. This system utilizes a MySQL database for robust data management and implements full CRUD (Create, Read, Update, Delete) functionality.

## 🚀 Key Features

### 1. Appointment Management
- **Patient Booking:** Patients can view available slots and book appointments with specific doctors.
- **Scheduling:** Real-time availability updates to prevent double-booking.
- **Status Tracking:** Monitor appointment status (Pending, Completed, Cancelled).

### 2. Doctor Dashboard & Prescriptions
- **Consultation Interface:** Doctors can view their daily schedule and patient history.
- **Digital Prescriptions:** Doctors can issue digital prescriptions directly within the app.
- **Medication Details:** Define specific dosages and "use times" (e.g., Morning, Afternoon, Evening).

### 3. Smart Medication Notifications
- **Patient Alerts:** Patients receive automated notifications based on the prescribed "medicine using times."
- **Adherence Tracking:** Helps patients stay on track with their treatment plan.

### 4. Admin & CRUD Operations
- **User Management:** Secure login and registration for Doctors, Patients, and Administrators.
- **Database Control:** Full CRUD operations for:
  - Doctor profiles and specialties.
  - Patient records.
  - Appointment logs.
  - Medicine inventory/catalog.

## 🛠 Tech Stack
- **Language:** C#
- **Framework:** .NET Framework / .NET Core (WinForms)
- **Database:** MySQL
- **ORM/Tooling:** MySQL Connector/NET

## 📋 Database Schema Overview
The system relies on a relational database consisting of the following core tables:
- `doctors`: Profiles, departments, and schedules.
- `patients`: Personal details and medical history.
- `appointments`: Mapping between patients, doctors, and time slots.
- `prescriptions`: Link between appointments and prescribed medicines.
- `medicines`: Details about drugs and dosage instructions.

## ⚙️ Setup and Installation

1. **Prerequisites:**
   - Visual Studio 2019 or later.
   - MySQL Server & MySQL Workbench.
   - .NET Desktop Development workload installed in VS.

2. **Database Configuration:**
   - Create a database named `hospital_db`.
   - Execute the provided SQL script (found in `hospital.sql`) to generate tables.
   - Update the connection string in `App.config` or your Database Helper class:
     ```csharp
     string connString = "Server=localhost;Database=hospital_db;Uid=root;Pwd=yourpassword;";
     ```

3. **Build and Run:**
   - Clone this repository.
   - Open the `.sln` file in Visual Studio.
   - Restore NuGet packages (MySQL.Data).
   - Press `F5` to build and run the application.

## 📸 Screenshots
*(Add your screenshots here)*
- *Login Screen*
- *Doctor's Prescription Panel*
- *Patient Appointment Booking*

## 🤝 Contributing
Contributions are welcome! Please fork the repository and create a pull request for any enhancements or bug fixes.

## 📄 License
This project is licensed under the MIT License - see the LICENSE file for details.

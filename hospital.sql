-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 01, 2026 at 03:07 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hospital`
--

-- --------------------------------------------------------

--
-- Table structure for table `admins`
--

CREATE TABLE `admins` (
  `id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `admins`
--

INSERT INTO `admins` (`id`, `username`, `password`) VALUES
(1, 'admin', 'admin');

-- --------------------------------------------------------

--
-- Table structure for table `appointments`
--

CREATE TABLE `appointments` (
  `id` int(11) NOT NULL,
  `clinic` varchar(50) NOT NULL,
  `doctor_name` varchar(50) NOT NULL,
  `doctor_id` int(11) NOT NULL,
  `patient_id` varchar(50) NOT NULL,
  `date` datetime NOT NULL,
  `start_time` time NOT NULL,
  `end_time` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `appointments`
--

INSERT INTO `appointments` (`id`, `clinic`, `doctor_name`, `doctor_id`, `patient_id`, `date`, `start_time`, `end_time`) VALUES
(22, 'kardiyoloji', 'emir', 23, '', '2026-05-01 00:00:00', '11:00:00', '11:10:00'),
(23, 'pedogoji', 'doctor', 25, '', '2026-05-02 00:00:00', '11:00:00', '11:10:00');

-- --------------------------------------------------------

--
-- Table structure for table `comments`
--

CREATE TABLE `comments` (
  `id` int(11) NOT NULL,
  `sender` varchar(50) NOT NULL,
  `subject_doctor` varchar(50) NOT NULL,
  `doctor_id` int(11) NOT NULL,
  `content` varchar(300) NOT NULL,
  `star_count` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `comments`
--

INSERT INTO `comments` (`id`, `sender`, `subject_doctor`, `doctor_id`, `content`, `star_count`) VALUES
(18, 'admin', 'emir', 23, '', 0),
(19, 'me', 'deneme', 24, 'cok iyi doktor', 1),
(20, 'me', 'emir', 23, 'cok kotu doktor', 0),
(21, 'me', 'doctor', 25, 'sss', 3);

-- --------------------------------------------------------

--
-- Table structure for table `doctors`
--

CREATE TABLE `doctors` (
  `id` int(11) NOT NULL,
  `email` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `doctor_name` varchar(50) NOT NULL,
  `profession` varchar(50) NOT NULL,
  `doctor_image_path` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `doctors`
--

INSERT INTO `doctors` (`id`, `email`, `password`, `doctor_name`, `profession`, `doctor_image_path`) VALUES
(25, 'doctor@gmail.com', '1234', 'doctor', 'pedogoji', 'C:\\Users\\MAL\\Documents\\GitHub\\HospitalAppointmentSystem\\HospitalAppointmentSystem\\bin\\Debug\\net8.0-windows\\..\\..\\..\\uploads\\860c2f7a-109e-46b1-b637-f6226d9c48bc.jpg');

-- --------------------------------------------------------

--
-- Table structure for table `medicines`
--

CREATE TABLE `medicines` (
  `id` int(50) NOT NULL,
  `name` varchar(50) NOT NULL,
  `image_path` varchar(300) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `medicines`
--

INSERT INTO `medicines` (`id`, `name`, `image_path`) VALUES
(8, 'trankobuskas', 'C:\\Users\\MAL\\Documents\\GitHub\\HospitalAppointmentSystem\\HospitalAppointmentSystem\\bin\\Debug\\net8.0-windows\\..\\..\\..\\uploads\\788fe976-c42d-418b-8f78-175297abc0e1.jpg'),
(9, 'aferin', 'C:\\Users\\MAL\\Documents\\GitHub\\HospitalAppointmentSystem\\HospitalAppointmentSystem\\bin\\Debug\\net8.0-windows\\..\\..\\..\\uploads\\775abc1d-e728-41df-8e46-239694fbd052.jpg'),
(10, 'parol', 'C:\\Users\\MAL\\Documents\\GitHub\\HospitalAppointmentSystem\\HospitalAppointmentSystem\\bin\\Debug\\net8.0-windows\\..\\..\\..\\uploads\\147caab9-4a3c-4cc0-a90f-1aa63ae6e8a2.jpg');

-- --------------------------------------------------------

--
-- Table structure for table `patients`
--

CREATE TABLE `patients` (
  `id` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `patients`
--

INSERT INTO `patients` (`id`, `name`, `email`, `password`) VALUES
(21, 'patient', 'patient@gmail.com', '1234'),
(23, 'keremcerm', 'keremcemerturk@gmail.com', '12345');

-- --------------------------------------------------------

--
-- Table structure for table `prescriptions`
--

CREATE TABLE `prescriptions` (
  `id` int(50) NOT NULL,
  `date` date NOT NULL,
  `patient_id` int(50) NOT NULL,
  `doctor_id` int(50) NOT NULL,
  `medicine_id` int(50) NOT NULL,
  `dosage_instruction` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `prescriptions`
--

INSERT INTO `prescriptions` (`id`, `date`, `patient_id`, `doctor_id`, `medicine_id`, `dosage_instruction`) VALUES
(18, '2026-05-30', 21, 1, 9, 'ssssssss'),
(19, '2026-06-06', 21, 1, 10, 'ssssssss'),
(20, '2026-05-15', 21, 1, 9, 'ssssssssssssssss'),
(21, '2026-05-16', 21, 1, 10, 'ssssss'),
(22, '2026-08-07', 21, 1, 10, 'ssdadasd');

-- --------------------------------------------------------

--
-- Table structure for table `professions`
--

CREATE TABLE `professions` (
  `id` int(11) NOT NULL,
  `profession` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `professions`
--

INSERT INTO `professions` (`id`, `profession`) VALUES
(1, 'kardiyoloji'),
(2, 'kulak burun bogaz'),
(3, 'radyoloji'),
(4, 'pedogoji'),
(5, 'travmatoloji');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admins`
--
ALTER TABLE `admins`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `appointments`
--
ALTER TABLE `appointments`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `comments`
--
ALTER TABLE `comments`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `doctors`
--
ALTER TABLE `doctors`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `medicines`
--
ALTER TABLE `medicines`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `patients`
--
ALTER TABLE `patients`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `prescriptions`
--
ALTER TABLE `prescriptions`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `professions`
--
ALTER TABLE `professions`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admins`
--
ALTER TABLE `admins`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `appointments`
--
ALTER TABLE `appointments`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- AUTO_INCREMENT for table `comments`
--
ALTER TABLE `comments`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT for table `doctors`
--
ALTER TABLE `doctors`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- AUTO_INCREMENT for table `medicines`
--
ALTER TABLE `medicines`
  MODIFY `id` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `patients`
--
ALTER TABLE `patients`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- AUTO_INCREMENT for table `prescriptions`
--
ALTER TABLE `prescriptions`
  MODIFY `id` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT for table `professions`
--
ALTER TABLE `professions`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

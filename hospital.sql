-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 27, 2026 at 05:26 PM
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
(15, 'radyoloji', 'doktor1', 0, '', '2026-04-20 00:00:00', '11:00:00', '11:10:00'),
(16, 'kardiyoloji', 'ayhan keser', 0, '', '2026-04-26 00:00:00', '13:00:00', '13:10:00'),
(17, 'kardiyoloji', 'ayhan keser', 0, '', '2026-04-30 00:00:00', '11:00:00', '11:10:00'),
(18, 'kardiyoloji', 'ayhan keser', 0, '', '2026-04-28 00:00:00', '13:00:00', '13:10:00'),
(19, 'kardiyoloji', 'ayhan keser', 18, '', '2026-04-30 00:00:00', '16:00:00', '16:10:00'),
(20, 'radyoloji', 'emir', 21, '', '2026-04-28 00:00:00', '14:00:00', '14:10:00'),
(21, 'radyoloji', 'emir', 21, '', '2026-04-27 00:00:00', '16:00:00', '16:10:00');

-- --------------------------------------------------------

--
-- Table structure for table `comments`
--

CREATE TABLE `comments` (
  `id` int(11) NOT NULL,
  `sender` varchar(50) NOT NULL,
  `subject_doctor` varchar(50) NOT NULL,
  `doctor_id` int(11) NOT NULL,
  `content` varchar(300) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `comments`
--

INSERT INTO `comments` (`id`, `sender`, `subject_doctor`, `doctor_id`, `content`) VALUES
(1, 'me', 'davutdoctor', 0, 'şlaksşkjaşlsdkaşlsd\naskdaşksdjşkajda\naksjdşlajsdşlkjaşdkasd'),
(2, 'ben', 'davut', 0, 'davuta basiyimmmm cok serttttt'),
(3, 'me', 'davutdoctor', 0, 'asdasdasdsa'),
(4, 'me', 'davutdoctor', 0, 'asdasdasdasd'),
(5, 'me', 'davut', 17, 'asdadasdaweqwe'),
(7, 'admin', 'ayhan keser', 18, 'asdasdasd'),
(8, 'admin', 'ayhan keser', 18, 'ayhan keser full guc full doktor'),
(9, 'admin', 'ayhan keser', 18, 'doktoooor'),
(10, 'admin', 'ayhan keser', 18, 'sssssssssssssssssssssssss'),
(11, 'admin', 'emir', 23, 'assssssssssssssss');

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
(23, 'emir@gmail.com', '1234', 'emir', 'kardiyoloji', 'C:\\Users\\MAL\\Documents\\GitHub\\HospitalAppointmentSystem\\HospitalAppointmentSystem\\bin\\Debug\\net8.0-windows\\..\\..\\..\\uploads\\dee23053-8dee-4691-ac5f-d6a2add3e3e9.jpg');

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
(4, 'aferin', 'C:\\Users\\MAL\\Documents\\GitHub\\HospitalAppointmentSystem\\HospitalAppointmentSystem\\bin\\Debug\\net8.0-windows\\..\\..\\..\\uploads\\0c54dafd-a083-4f67-9fe2-7a09453e3a87.jpg');

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
(12, 'davut', 'davut@gmail.com', '1234');

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
(6, '2026-05-02', 1, 0, 4, 'her sabah aksam '),
(7, '2026-04-24', 1, 0, 1, 'sssssssssssssss');

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
(3, 'radyoloji');

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
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT for table `comments`
--
ALTER TABLE `comments`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `doctors`
--
ALTER TABLE `doctors`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- AUTO_INCREMENT for table `medicines`
--
ALTER TABLE `medicines`
  MODIFY `id` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `patients`
--
ALTER TABLE `patients`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `prescriptions`
--
ALTER TABLE `prescriptions`
  MODIFY `id` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `professions`
--
ALTER TABLE `professions`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

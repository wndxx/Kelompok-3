-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 20, 2022 at 06:58 AM
-- Server version: 10.4.17-MariaDB
-- PHP Version: 8.0.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `projectuas`
--

-- --------------------------------------------------------

--
-- Table structure for table `film`
--

CREATE TABLE `film` (
  `IdFilm` int(5) NOT NULL,
  `NamaFilm` varchar(50) DEFAULT NULL,
  `Harga` int(7) DEFAULT NULL,
  `Jam` varchar(15) DEFAULT NULL,
  `rating` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `film`
--

INSERT INTO `film` (`IdFilm`, `NamaFilm`, `Harga`, `Jam`, `rating`) VALUES
(1001, 'Star Wars ', 40000, '12.00 - 20.00', 13),
(1002, 'Thor: Love and Thunder', 55000, '10.00 - 20.00', 17),
(1003, 'Jujutsu Kaisen 0', 55000, '08.00 - 10.00', 17),
(1004, 'No Game No Life 0', 50000, '15.15 - 17.30', 0),
(1005, 'Sonic The Hedgehog 2', 40000, '13.00 - 15.10', 0),
(1006, 'Minion', 30000, '18.00-19.00', 7),
(1007, 'Dora The Explorer', 45000, '08.00 - 09.00', 0),
(1008, 'Ivanna', 70000, '15.00 - 16.30', 17);

-- --------------------------------------------------------

--
-- Table structure for table `pembeli`
--

CREATE TABLE `pembeli` (
  `IdPembeli` int(11) NOT NULL,
  `NamaPembeli` varchar(100) DEFAULT NULL,
  `umur` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `pembeli`
--

INSERT INTO `pembeli` (`IdPembeli`, `NamaPembeli`, `umur`) VALUES
(1, 'Betran Gustama', 20),
(2, 'Stanley Ananda', 18),
(3, 'Shandy Destiawan', 15),
(4, 'Arfin Refaldi', 19);

-- --------------------------------------------------------

--
-- Table structure for table `tiket`
--

CREATE TABLE `tiket` (
  `IdTiket` int(5) NOT NULL,
  `IdPembeli` int(5) NOT NULL,
  `IdFilm` int(5) NOT NULL,
  `tanggal` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tiket`
--

INSERT INTO `tiket` (`IdTiket`, `IdPembeli`, `IdFilm`, `tanggal`) VALUES
(5015, 1, 1005, '16-07-2022'),
(5016, 3, 1003, '18-07-2022'),
(5017, 4, 1002, '19-07-2022'),
(5018, 3, 1001, '15-07-2022');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `film`
--
ALTER TABLE `film`
  ADD PRIMARY KEY (`IdFilm`);

--
-- Indexes for table `pembeli`
--
ALTER TABLE `pembeli`
  ADD PRIMARY KEY (`IdPembeli`);

--
-- Indexes for table `tiket`
--
ALTER TABLE `tiket`
  ADD PRIMARY KEY (`IdTiket`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `film`
--
ALTER TABLE `film`
  MODIFY `IdFilm` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1009;

--
-- AUTO_INCREMENT for table `pembeli`
--
ALTER TABLE `pembeli`
  MODIFY `IdPembeli` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `tiket`
--
ALTER TABLE `tiket`
  MODIFY `IdTiket` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5019;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Dec 13, 2016 at 09:16 AM
-- Server version: 10.1.19-MariaDB
-- PHP Version: 7.0.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `atmdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `balance`
--

CREATE TABLE `balance` (
  `BalID` int(11) NOT NULL,
  `BalAmount` int(11) NOT NULL,
  `userNum` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `balance`
--

INSERT INTO `balance` (`BalID`, `BalAmount`, `userNum`) VALUES
(1, 15000, 2013100),
(2, 25000, 2013100441),
(3, 26000, 2013100442),
(4, 30000, 2013100443),
(5, 24000, 2013100444),
(6, 25000, 2013100445),
(7, 10000, 2013100446),
(8, 48500, 2013100447),
(9, 200, 2013100448),
(10, 9000, 2013100449);

-- --------------------------------------------------------

--
-- Table structure for table `bill`
--

CREATE TABLE `bill` (
  `BilliD` int(11) NOT NULL,
  `BillAmount` int(11) NOT NULL,
  `BillCatID` int(11) NOT NULL,
  `Status` char(10) NOT NULL,
  `userNum` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bill`
--

INSERT INTO `bill` (`BilliD`, `BillAmount`, `BillCatID`, `Status`, `userNum`) VALUES
(1, 2000, 1, '', 2013100),
(2, 1000, 2, '', 2013100),
(3, 1500, 3, '', 2013100),
(4, 1500, 4, '', 2013100),
(36, 1500, 1, '', 2013100441),
(37, 1200, 2, '', 2013100441),
(38, 250, 3, '', 2013100441),
(39, 2500, 4, '', 2013100441),
(40, 1500, 1, '', 2013100442),
(41, 1000, 2, '', 2013100442),
(42, 500, 3, '', 2013100442),
(43, 3500, 4, '', 2013100442),
(44, 2500, 1, '', 2013100443),
(45, 1000, 2, '', 2013100443),
(46, 1200, 3, '', 2013100443),
(47, 2500, 4, '', 2013100443),
(48, 1350, 1, '', 2013100444),
(49, 1250, 2, '', 2013100444),
(50, 1400, 3, '', 2013100444),
(51, 500, 4, '', 2013100444),
(52, 200, 1, '', 2013100445),
(53, 650, 2, '', 2013100445),
(54, 1320, 3, '', 2013100445),
(55, 1200, 4, '', 2013100445),
(56, 2503, 1, '', 2013100446),
(57, 650, 2, '', 2013100446),
(58, 253, 3, '', 2013100446),
(59, 2500, 4, '', 2013100446),
(60, 1500, 1, '', 2013100447),
(61, 1200, 2, '', 2013100447),
(62, 2540, 3, '', 2013100447),
(63, 4000, 4, '', 2013100447),
(64, 1200, 1, '', 2013100448),
(65, 1420, 2, '', 2013100448),
(66, 1250, 3, '', 2013100448),
(67, 4000, 4, '', 2013100448),
(68, 1540, 1, '', 2013100449),
(69, 350, 2, '', 2013100449),
(70, 857, 3, '', 2013100449),
(71, 12500, 4, '', 2013100449);

-- --------------------------------------------------------

--
-- Table structure for table `billcategory`
--

CREATE TABLE `billcategory` (
  `BillCatID` int(11) NOT NULL,
  `BillCatName` char(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `billcategory`
--

INSERT INTO `billcategory` (`BillCatID`, `BillCatName`) VALUES
(1, 'Water'),
(2, 'Electric'),
(3, 'Phone'),
(4, 'Loan');

-- --------------------------------------------------------

--
-- Table structure for table `transaction`
--

CREATE TABLE `transaction` (
  `transID` int(11) NOT NULL,
  `transDate` date NOT NULL,
  `Amount` int(11) NOT NULL,
  `userNum` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `transaction`
--

INSERT INTO `transaction` (`transID`, `transDate`, `Amount`, `userNum`) VALUES
(18, '2016-12-13', 0, 2013100447),
(19, '2016-12-13', 1, 2013100);

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `userNum` int(11) NOT NULL,
  `userPin` int(11) NOT NULL,
  `userName` varchar(260) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`userNum`, `userPin`, `userName`) VALUES
(2013100, 123456, 'John Christian S. Viray'),
(2013100441, 222222, 'Melody Dela Cruz'),
(2013100442, 111111, 'Renerose Ibay'),
(2013100443, 333333, 'Chris Lorenz Tambanillo'),
(2013100444, 444444, 'Ryan Maristela'),
(2013100445, 555555, 'Brisha Garcia'),
(2013100446, 666666, 'Julie Soriano'),
(2013100447, 7777777, 'Christopher Mani'),
(2013100448, 888888, 'Paul Genesis Mariano'),
(2013100449, 999999, 'Kenneth Tanglao');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `balance`
--
ALTER TABLE `balance`
  ADD PRIMARY KEY (`BalID`),
  ADD KEY `userNum` (`userNum`);

--
-- Indexes for table `bill`
--
ALTER TABLE `bill`
  ADD PRIMARY KEY (`BilliD`),
  ADD KEY `BillCatID` (`BillCatID`),
  ADD KEY `userNum` (`userNum`);

--
-- Indexes for table `billcategory`
--
ALTER TABLE `billcategory`
  ADD PRIMARY KEY (`BillCatID`);

--
-- Indexes for table `transaction`
--
ALTER TABLE `transaction`
  ADD PRIMARY KEY (`transID`),
  ADD KEY `userNum` (`userNum`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`userNum`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `balance`
--
ALTER TABLE `balance`
  MODIFY `BalID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT for table `bill`
--
ALTER TABLE `bill`
  MODIFY `BilliD` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=72;
--
-- AUTO_INCREMENT for table `billcategory`
--
ALTER TABLE `billcategory`
  MODIFY `BillCatID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `transaction`
--
ALTER TABLE `transaction`
  MODIFY `transID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `balance`
--
ALTER TABLE `balance`
  ADD CONSTRAINT `balance_ibfk_1` FOREIGN KEY (`userNum`) REFERENCES `user` (`userNum`) ON UPDATE CASCADE;

--
-- Constraints for table `bill`
--
ALTER TABLE `bill`
  ADD CONSTRAINT `bill_ibfk_1` FOREIGN KEY (`BillCatID`) REFERENCES `billcategory` (`BillCatID`) ON UPDATE CASCADE,
  ADD CONSTRAINT `bill_ibfk_2` FOREIGN KEY (`userNum`) REFERENCES `user` (`userNum`) ON UPDATE CASCADE;

--
-- Constraints for table `transaction`
--
ALTER TABLE `transaction`
  ADD CONSTRAINT `transaction_ibfk_1` FOREIGN KEY (`userNum`) REFERENCES `user` (`userNum`) ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

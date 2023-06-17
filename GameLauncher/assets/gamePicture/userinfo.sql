-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Hostiteľ: 127.0.0.1
-- Čas generovania: Po 12.Jún 2023, 07:22
-- Verzia serveru: 10.4.27-MariaDB
-- Verzia PHP: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Databáza: `loginform`
--

-- --------------------------------------------------------

--
-- Štruktúra tabuľky pre tabuľku `userinfo`
--

CREATE TABLE `userinfo` (
  `ID` int(255) NOT NULL,
  `FirstName` varchar(50) NOT NULL,
  `LastName` varchar(50) NOT NULL,
  `Gender` varchar(50) NOT NULL,
  `Birthday` varchar(12) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `DateCreated` varchar(50) NOT NULL DEFAULT current_timestamp(),
  `LastLogin` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Sťahujem dáta pre tabuľku `userinfo`
--

INSERT INTO `userinfo` (`ID`, `FirstName`, `LastName`, `Gender`, `Birthday`, `Email`, `Username`, `Password`, `DateCreated`, `LastLogin`) VALUES
(2, 'fabian', 'nemcok', 'Male', '23. 1. 2006', 'admin420@spsit.sk', 'fabnixx', 'cadcaontop', '2023-05-24 23:14:15', '25. 5. 2023 9:18:59'),
(4, 'Patrik', 'Nemčok', 'Male', '23. 1. 2001 ', 'patkonemcok@gmail.com', 'TW_PatoN', 'konecnetoide', '2023-06-03 19:27:58', '25. 5. 2023 9:18:59'),
(5, 'Fabián', 'Vojár', 'Male', '27. 1. 2006 ', 'fabvoj@gmail.com', 'fabvoj', 'Jebemkaleradoriti', '2023-06-06 07:38:16', '25. 5. 2023 9:18:59'),
(6, 'Fabian', 'Vojar', 'Mental Disorder', '31. 1. 2001 ', 'zjedzmikar@gmail.com', 'fabvojjesuper', 'Somsuper', '2023-06-08 09:33:23', '25. 5. 2023 9:18:59');

--
-- Kľúče pre exportované tabuľky
--

--
-- Indexy pre tabuľku `userinfo`
--
ALTER TABLE `userinfo`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT pre exportované tabuľky
--

--
-- AUTO_INCREMENT pre tabuľku `userinfo`
--
ALTER TABLE `userinfo`
  MODIFY `ID` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

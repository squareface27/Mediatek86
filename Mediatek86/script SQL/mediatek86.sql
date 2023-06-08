-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : jeu. 08 juin 2023 à 16:19
-- Version du serveur : 8.0.32
-- Version de PHP : 8.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `mediatek86`
--

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE IF NOT EXISTS `absence` (
  `IDPERSONNEL` int NOT NULL,
  `DATEDEBUT` datetime NOT NULL,
  `IDMOTIF` int NOT NULL,
  `DATEFIN` datetime DEFAULT NULL,
  PRIMARY KEY (`IDPERSONNEL`,`DATEDEBUT`),
  KEY `I_FK_ABSENCE_MOTIF` (`IDMOTIF`),
  KEY `I_FK_ABSENCE_PERSONNEL` (`IDPERSONNEL`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`IDPERSONNEL`, `DATEDEBUT`, `IDMOTIF`, `DATEFIN`) VALUES
(2, '2022-05-06 21:25:59', 2, '2023-08-19 19:38:05'),
(2, '2022-08-24 21:43:52', 3, '2023-11-17 20:18:38'),
(2, '2022-09-06 06:18:06', 3, '2023-05-27 21:21:08'),
(2, '2022-11-09 16:37:51', 3, '2024-01-14 17:01:46'),
(2, '2023-01-22 03:34:59', 3, '2024-02-08 11:38:27'),
(3, '2022-05-02 20:22:04', 4, '2023-11-05 21:38:50'),
(3, '2022-05-11 20:22:04', 2, '2023-11-03 21:38:50'),
(3, '2022-06-09 17:10:38', 1, '2023-11-03 21:38:50'),
(3, '2022-06-18 19:35:38', 1, '2023-11-03 21:38:50'),
(3, '2022-07-10 02:43:19', 1, '2023-11-03 21:38:50'),
(3, '2022-08-08 23:58:50', 1, '2023-11-03 21:38:50'),
(3, '2022-08-27 01:23:53', 1, '2023-11-03 21:38:50'),
(3, '2022-09-03 10:42:25', 1, '2023-11-03 21:38:50'),
(3, '2022-09-17 09:42:00', 1, '2023-11-03 21:38:50'),
(3, '2022-09-20 07:49:50', 1, '2023-11-03 21:38:50'),
(3, '2022-11-04 02:57:00', 1, '2023-11-03 21:38:50'),
(3, '2023-02-12 18:43:49', 1, '2023-11-03 21:38:50'),
(4, '2022-04-12 21:14:06', 1, '2023-09-20 01:38:50'),
(4, '2022-06-17 13:59:02', 4, '2023-09-25 18:07:13'),
(4, '2022-08-09 11:46:17', 2, '2023-10-27 16:37:02'),
(4, '2022-09-28 22:52:05', 3, '2024-02-26 05:55:16'),
(4, '2022-10-06 12:07:21', 2, '2023-11-21 19:31:09'),
(4, '2022-11-20 17:18:27', 4, '2024-03-04 18:05:29'),
(4, '2022-12-26 02:20:00', 2, '2023-11-24 13:19:37'),
(4, '2023-01-26 05:36:39', 1, '2024-04-06 15:05:01'),
(4, '2023-03-28 00:07:20', 3, '2024-01-05 14:07:28'),
(5, '2022-04-10 13:57:40', 2, '2023-09-21 04:04:27'),
(5, '2022-04-19 22:13:58', 1, '2023-07-15 01:38:23'),
(5, '2022-05-20 19:08:43', 3, '2024-02-20 19:31:37'),
(5, '2022-09-02 03:25:29', 4, '2023-12-05 02:11:10'),
(5, '2022-09-25 04:50:35', 2, '2023-08-17 06:32:55'),
(5, '2022-11-24 02:54:11', 3, '2023-10-30 15:28:24'),
(5, '2023-03-04 15:34:44', 1, '2023-12-23 19:24:30'),
(5, '2023-06-04 00:00:00', 2, '2023-06-05 00:00:00'),
(6, '2022-04-14 04:01:25', 4, '2024-03-07 22:28:01'),
(6, '2022-04-20 09:49:25', 3, '2023-08-09 04:04:12'),
(6, '2022-05-02 08:36:20', 1, '2024-01-04 13:12:14'),
(6, '2022-06-19 12:22:59', 4, '2023-12-26 16:55:13'),
(6, '2022-07-14 05:51:38', 2, '2024-01-10 23:42:01'),
(6, '2022-07-19 16:13:21', 4, '2024-04-06 23:00:19'),
(6, '2022-12-10 07:33:13', 3, '2023-09-16 18:48:01'),
(6, '2022-12-27 10:32:31', 3, '2023-10-05 15:34:43'),
(6, '2023-01-29 23:59:31', 3, '2023-05-18 10:08:24'),
(6, '2023-03-26 18:33:55', 2, '2023-08-31 20:35:13'),
(6, '2023-06-22 00:00:00', 3, '2023-06-24 00:00:00'),
(7, '2022-08-01 01:33:16', 3, '2024-01-13 00:19:24'),
(7, '2022-09-10 13:33:02', 3, '2023-07-04 23:55:06'),
(7, '2023-02-10 01:23:13', 1, '2024-02-07 20:47:08'),
(8, '2022-07-26 06:58:53', 2, '2023-12-05 10:01:07'),
(8, '2022-08-21 15:01:57', 2, '2023-10-20 07:43:30'),
(8, '2022-11-29 08:48:46', 3, '2023-10-07 11:44:53'),
(8, '2023-01-22 21:32:03', 3, '2023-06-26 05:58:32'),
(8, '2023-02-20 19:26:27', 2, '2023-09-30 18:37:02'),
(8, '2023-03-22 01:32:57', 1, '2023-09-21 13:09:04'),
(8, '2023-05-16 00:00:00', 2, '2023-05-17 00:00:00'),
(8, '2023-06-04 00:00:00', 4, '2023-06-21 00:00:00'),
(9, '2022-05-07 22:37:39', 3, '2023-05-17 07:25:03'),
(9, '2022-05-29 01:31:40', 3, '2023-10-18 02:26:25'),
(9, '2022-10-19 11:49:30', 2, '2023-05-05 00:42:46'),
(9, '2022-11-08 17:21:15', 1, '2023-11-24 17:06:01'),
(9, '2022-12-08 12:00:22', 1, '2023-07-06 18:17:34'),
(9, '2023-04-02 06:28:57', 3, '2023-04-08 23:42:53'),
(10, '2022-06-13 20:20:50', 4, '2023-04-08 23:35:25'),
(10, '2022-08-28 03:50:32', 1, '2023-11-19 06:18:52'),
(10, '2023-02-03 01:29:14', 4, '2023-05-14 11:10:08'),
(40, '2023-06-08 00:00:00', 1, '2023-06-12 00:00:00');

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE IF NOT EXISTS `motif` (
  `IDMOTIF` int NOT NULL AUTO_INCREMENT,
  `LIBELLE` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`IDMOTIF`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`IDMOTIF`, `LIBELLE`) VALUES
(1, 'Vacances'),
(2, 'Maladie'),
(3, 'Motif familial'),
(4, 'Congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE IF NOT EXISTS `personnel` (
  `IDPERSONNEL` int NOT NULL AUTO_INCREMENT,
  `IDSERVICE` int NOT NULL,
  `NOM` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `PRENOM` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `TEL` varchar(15) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `MAIL` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`IDPERSONNEL`),
  KEY `I_FK_PERSONNEL_SERVICE` (`IDSERVICE`)
) ENGINE=InnoDB AUTO_INCREMENT=42 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`IDPERSONNEL`, `IDSERVICE`, `NOM`, `PRENOM`, `TEL`, `MAIL`) VALUES
(2, 2, 'Jennifer', 'Wilkinson', '07 22 92 84 20', 'cum.sociis@aol.org'),
(3, 3, 'Maile', 'Flores', '08 88 35 96 63', 'nec.tempus@icloud.couk'),
(4, 1, 'Melissa', 'Knapp', '05 86 19 55 29', 'proin.sed@outlook.com'),
(5, 2, 'Griffin', 'Webster', '08 68 16 12 17', 'eu.placerat@outlook.net'),
(6, 3, 'Aurora', 'Fry', '03 93 28 40 76', 'posuere@aol.org'),
(7, 2, 'Dominic', 'Quinn', '03 82 31 47 41', 'vel.mauris@aol.couk'),
(8, 3, 'Sean', 'Gray', '07 51 81 04 28', 'eu.tempor@hotmail.org'),
(9, 2, 'Wylie', 'Parker', '01 28 50 61 74', 'netus.et@protonmail.couk'),
(10, 2, 'Holmes', 'Acevedo', '09 67 68 67 35', 'tempus.oui@outlook.net'),
(36, 2, 'francoise', 'claudette', '5050505050', 'uyhrzyrz@rzhzr<'),
(40, 1, 'Courtial', 'Gérard', '0526984756', 'courtial.olivier@gmail.com');

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `login` varchar(64) COLLATE utf8mb4_unicode_ci NOT NULL,
  `pwd` varchar(64) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('resp', 'a1159e9df3670d549d04524532629f5477ceb7deec9b45e47e8c009506ecb2c8');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `IDSERVICE` int NOT NULL AUTO_INCREMENT,
  `NOM` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`IDSERVICE`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`IDSERVICE`, `NOM`) VALUES
(1, 'Administratif'),
(2, 'Médiation culturelle'),
(3, 'Prêt');

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `absence`
--
ALTER TABLE `absence`
  ADD CONSTRAINT `absence_ibfk_1` FOREIGN KEY (`IDMOTIF`) REFERENCES `motif` (`IDMOTIF`),
  ADD CONSTRAINT `absence_ibfk_2` FOREIGN KEY (`IDPERSONNEL`) REFERENCES `personnel` (`IDPERSONNEL`);

--
-- Contraintes pour la table `personnel`
--
ALTER TABLE `personnel`
  ADD CONSTRAINT `personnel_ibfk_1` FOREIGN KEY (`IDSERVICE`) REFERENCES `service` (`IDSERVICE`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

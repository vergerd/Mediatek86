-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : lun. 15 mai 2023 à 12:01
-- Version du serveur : 5.7.42
-- Version de PHP : 7.2.34

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
CREATE DATABASE IF NOT EXISTS mediatek86 DEFAULT CHARACTER SET utf8 COLLATE utf8_unicode_ci;
USE mediatek86;
-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE IF NOT EXISTS `absence` (
  `idpersonnel` int(11) NOT NULL,
  `datedebut` datetime NOT NULL,
  `idmotif` int(11) NOT NULL,
  `datefin` datetime DEFAULT NULL,
  PRIMARY KEY (`idpersonnel`,`datedebut`),
  KEY `FK_absence_motif` (`idmotif`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`idpersonnel`, `datedebut`, `idmotif`, `datefin`) VALUES
(1, '2022-12-01 00:00:00', 2, '2023-03-11 00:00:00'),
(1, '2023-04-27 00:00:00', 1, '2023-04-30 00:00:00'),
(2, '2022-06-08 00:00:00', 3, '2022-06-13 00:00:00'),
(2, '2022-07-14 00:00:00', 4, '2022-12-22 00:00:00'),
(2, '2022-10-15 00:00:00', 3, '2023-03-12 00:00:00'),
(2, '2023-03-31 00:00:00', 3, '2023-04-04 00:00:00'),
(4, '2022-05-28 00:00:00', 1, '2022-08-10 00:00:00'),
(4, '2022-09-06 00:00:00', 4, '2022-09-15 00:00:00'),
(4, '2022-09-07 00:00:00', 4, '2023-02-14 00:00:00'),
(4, '2022-10-11 00:00:00', 4, '2023-04-11 00:00:00'),
(4, '2022-10-15 00:00:00', 4, '2022-10-27 00:00:00'),
(4, '2023-05-07 00:00:00', 4, '2023-05-07 00:00:00'),
(5, '2022-05-05 00:00:00', 3, '2022-05-14 00:00:00'),
(5, '2022-05-30 00:00:00', 4, '2022-06-04 00:00:00'),
(5, '2022-06-20 00:00:00', 4, '2022-11-06 00:00:00'),
(5, '2022-07-01 00:00:00', 4, '2022-07-11 00:00:00'),
(5, '2022-10-11 00:00:00', 2, '2023-05-16 00:00:00'),
(5, '2022-12-16 00:00:00', 1, '2023-04-05 00:00:00'),
(5, '2023-02-01 00:00:00', 1, '2023-07-01 00:00:00'),
(5, '2023-02-19 00:00:00', 1, '2023-03-25 00:00:00'),
(5, '2023-02-25 00:00:00', 1, '2023-05-20 00:00:00'),
(6, '2022-03-23 00:00:00', 3, '2022-03-30 00:00:00'),
(6, '2022-05-29 00:00:00', 3, '2022-07-27 00:00:00'),
(6, '2022-09-02 00:00:00', 1, '2022-10-26 00:00:00'),
(6, '2023-05-10 00:00:00', 4, '2023-05-10 00:00:00'),
(7, '2022-05-15 00:00:00', 3, '2023-03-01 00:00:00'),
(7, '2022-06-02 00:00:00', 3, '2023-05-27 00:00:00'),
(7, '2022-10-27 00:00:00', 2, '2022-10-30 00:00:00'),
(8, '2023-05-02 00:00:00', 4, '2023-05-06 00:00:00'),
(8, '2023-05-19 00:00:00', 2, '2023-05-20 00:00:00'),
(9, '2022-04-25 00:00:00', 3, '2022-10-25 00:00:00'),
(9, '2022-05-20 00:00:00', 3, '2023-02-07 00:00:00'),
(9, '2022-06-15 00:00:00', 2, '2022-08-21 00:00:00'),
(9, '2022-08-10 00:00:00', 3, '2022-08-12 00:00:00'),
(9, '2022-08-16 00:00:00', 2, '2023-02-28 00:00:00'),
(9, '2022-10-10 00:00:00', 1, '2023-02-10 00:00:00'),
(9, '2022-10-21 00:00:00', 2, '2022-10-23 00:00:00'),
(9, '2023-01-16 00:00:00', 3, '2023-05-14 00:00:00'),
(9, '2023-05-08 00:00:00', 4, '2023-05-08 00:00:00'),
(9, '2023-07-07 00:00:00', 2, '2023-09-14 00:00:00'),
(10, '2022-07-01 00:00:00', 3, '2022-07-04 00:00:00'),
(10, '2022-07-15 00:00:00', 3, '2022-07-26 00:00:00'),
(10, '2023-05-07 00:00:00', 4, '2023-05-07 00:00:00'),
(10, '2023-05-08 00:00:00', 4, '2023-05-08 00:00:00'),
(10, '2023-05-09 00:00:00', 4, '2023-05-10 00:00:00'),
(11, '2022-07-29 00:00:00', 3, '2022-07-30 00:00:00'),
(11, '2023-01-30 00:00:00', 2, '2023-03-03 00:00:00'),
(11, '2023-05-04 00:00:00', 4, '2023-05-08 00:00:00'),
(11, '2023-05-08 00:00:00', 4, '2023-05-08 00:00:00'),
(11, '2023-05-09 00:00:00', 4, '2023-05-09 00:00:00'),
(11, '2023-05-10 00:00:00', 4, '2023-05-11 00:00:00');

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE IF NOT EXISTS `motif` (
  `idmotif` int(11) NOT NULL AUTO_INCREMENT,
  `libelle` varchar(128) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idmotif`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`idmotif`, `libelle`) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE IF NOT EXISTS `personnel` (
  `idpersonnel` int(11) NOT NULL AUTO_INCREMENT,
  `idservice` int(11) NOT NULL,
  `nom` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `prenom` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `tel` varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  `mail` varchar(128) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idpersonnel`),
  KEY `FK_personnel_service` (`idservice`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`idpersonnel`, `idservice`, `nom`, `prenom`, `tel`, `mail`) VALUES
(1, 2, 'Norton', 'Kessie', '01 20 20 59 71', 'norton.kessie@mediatek86.fr'),
(2, 1, 'Powers', 'Fritz', '01 20 20 59 42', 'fritz.powers@mediatek86.fr'),
(4, 3, 'Murray', 'Jarrod', '01 20 20 59 56', 'jarrod.murray@mediatek86.fr'),
(5, 2, 'Odom', 'Rina', '01 20 20 46 20', 'rina.odom@mediatek86.fr'),
(6, 2, 'Moore', 'Andrew', '01 20 20 59 48', 'andrew.moore@mediatek86.fr'),
(7, 2, 'Petersen', 'Galena', '01 20 20 59 47', 'galena.petersen@mediatek86.fr'),
(8, 2, 'Clark', 'Elvis', '01 20 20 46 47', 'elvis.clay@mediatek86.fr'),
(9, 2, 'Hudson', 'Arsenio', '01 20 20 59 40', 'arsenio.hudson@mediatek86.fr'),
(10, 3, 'Hester', 'Nasim', '01 20 20 46 16', 'nasim.hester@mediatek86.fr'),
(11, 3, 'Dickson', 'Mark', '01 20 20 46 06', 'dickson.mark@mediatek86.fr');

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `login` varchar(64) COLLATE utf8_unicode_ci NOT NULL,
  `pwd` varchar(64) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('user_responsable', 'bfd2bb20ff78332082d7c218982157b7a264550374be0e745deaedfd886713f4');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `idservice` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idservice`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`idservice`, `nom`) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `absence`
--
ALTER TABLE `absence`
  ADD CONSTRAINT `absence_ibfk_1` FOREIGN KEY (`idmotif`) REFERENCES `motif` (`idmotif`),
  ADD CONSTRAINT `absence_ibfk_2` FOREIGN KEY (`idpersonnel`) REFERENCES `personnel` (`idpersonnel`);

--
-- Contraintes pour la table `personnel`
--
ALTER TABLE `personnel`
  ADD CONSTRAINT `personnel_ibfk_1` FOREIGN KEY (`idservice`) REFERENCES `service` (`idservice`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;


CREATE USER 'user_mediatek86'@'%' IDENTIFIED BY 'user_mediatek86_pwd';

GRANT ALL PRIVILEGES ON `mediatek86`.* TO 'mediatek86'@'%';

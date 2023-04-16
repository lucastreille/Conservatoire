-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : dim. 16 avr. 2023 à 15:43
-- Version du serveur : 10.3.37-MariaDB
-- Version de PHP : 7.4.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `bvasjtpz_convervatoire`
--

-- --------------------------------------------------------

--
-- Structure de la table `administrateur`
--

CREATE TABLE `administrateur` (
  `id` int(11) NOT NULL,
  `mail` text NOT NULL,
  `mdp` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `administrateur`
--

INSERT INTO `administrateur` (`id`, `mail`, `mdp`) VALUES
(1, 'lucas.treille@laposte.net', 'G7r8z5!'),
(2, 'lucas.treille@laposte.net', 'eb8db4d21c1abe8e43b2e2352310ab97');

-- --------------------------------------------------------

--
-- Structure de la table `eleve`
--

CREATE TABLE `eleve` (
  `IDELEVE` int(11) NOT NULL,
  `NIVEAU` int(11) NOT NULL,
  `BOURSE` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Déchargement des données de la table `eleve`
--

INSERT INTO `eleve` (`IDELEVE`, `NIVEAU`, `BOURSE`) VALUES
(4, 2, 100),
(5, 3, NULL),
(6, 3, 150),
(8, 2, 250),
(10, 3, 100),
(11, 3, 520),
(14, 3, 10),
(15, 2, 0),
(16, 1, 625),
(18, 1, 155),
(19, 3, NULL);

-- --------------------------------------------------------

--
-- Structure de la table `heure`
--

CREATE TABLE `heure` (
  `TRANCHE` char(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Déchargement des données de la table `heure`
--

INSERT INTO `heure` (`TRANCHE`) VALUES
('10h00-11h00'),
('10h00-12h00'),
('11h00-12h00'),
('11h00-13h00'),
('12h00-13h00'),
('12h00-14h00'),
('13h00-14h00'),
('13h00-15h00'),
('14h00-15h00'),
('14h00-16h00'),
('14h00-18h00'),
('15h00-16h00'),
('16h00-17h00'),
('16h00-18h00'),
('16h00-19h00'),
('17h00-18h00'),
('17h00-19h00'),
('18h00-19h00'),
('8h00-10h00'),
('8h00-12h00'),
('8h00-9h00'),
('9h00-10h00'),
('9h00-12h00');

-- --------------------------------------------------------

--
-- Structure de la table `inscription`
--

CREATE TABLE `inscription` (
  `IDPROF` int(11) NOT NULL,
  `IDELEVE` int(11) NOT NULL,
  `NUMSEANCE` int(11) NOT NULL,
  `DATEINSCRIPTION` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Déchargement des données de la table `inscription`
--

INSERT INTO `inscription` (`IDPROF`, `IDELEVE`, `NUMSEANCE`, `DATEINSCRIPTION`) VALUES
(1, 5, 3, '2023-04-16'),
(1, 5, 38, '2023-03-26'),
(1, 10, 3, '2023-03-26'),
(1, 10, 29, '2023-04-15'),
(1, 10, 38, '2023-03-26'),
(1, 15, 3, '2023-03-26'),
(1, 15, 29, '2023-04-15'),
(1, 15, 38, '2023-03-26'),
(1, 16, 38, '2023-03-26'),
(2, 5, 41, '2023-03-26'),
(2, 6, 10, '2023-03-26'),
(2, 6, 41, '2023-03-26'),
(2, 6, 45, '2023-04-16'),
(2, 10, 10, '2023-03-26'),
(2, 10, 41, '2023-03-26'),
(2, 16, 10, '2023-03-26'),
(2, 16, 41, '2023-03-26'),
(2, 19, 10, '2023-03-26'),
(3, 6, 14, '2023-03-26'),
(3, 6, 23, '2023-03-26'),
(3, 10, 32, '2023-03-26'),
(3, 11, 14, '2023-03-26'),
(3, 11, 40, '2023-03-26'),
(3, 16, 23, '2023-03-26'),
(3, 19, 14, '2023-03-26'),
(3, 19, 23, '2023-03-26'),
(3, 19, 40, '2023-03-26'),
(7, 5, 8, '2023-03-26'),
(7, 6, 44, '2023-03-26'),
(7, 10, 8, '2023-03-26'),
(7, 19, 8, '2023-03-26'),
(9, 6, 21, '2023-03-26'),
(9, 8, 39, '2023-03-26'),
(9, 11, 21, '2023-03-26'),
(9, 15, 26, '2023-03-26'),
(9, 16, 21, '2023-03-26'),
(9, 16, 39, '2023-03-26'),
(12, 5, 9, '2023-03-26'),
(12, 5, 28, '2023-03-26'),
(12, 5, 43, '2023-03-26'),
(12, 6, 28, '2023-03-26'),
(12, 8, 4, '2023-03-26'),
(12, 8, 6, '2023-03-26'),
(12, 8, 9, '2023-04-11'),
(12, 10, 9, '2023-04-11'),
(12, 10, 28, '2023-03-26'),
(12, 10, 43, '2023-03-26'),
(12, 11, 6, '2023-03-26'),
(12, 15, 6, '2023-03-26'),
(12, 15, 35, '2023-03-26'),
(12, 15, 43, '2023-03-26'),
(13, 5, 12, '2023-03-26'),
(13, 5, 24, '2023-03-26'),
(13, 5, 34, '2023-03-26'),
(13, 6, 16, '2023-03-29'),
(13, 8, 12, '2023-03-26'),
(13, 8, 24, '2023-03-26'),
(13, 8, 34, '2023-03-26'),
(13, 10, 24, '2023-03-26'),
(13, 11, 24, '2023-03-26'),
(13, 11, 34, '2023-03-26'),
(13, 16, 12, '2023-03-26'),
(13, 16, 24, '2023-03-26'),
(13, 16, 34, '2023-03-26'),
(13, 19, 24, '2023-03-26'),
(13, 19, 34, '2023-03-26'),
(17, 5, 37, '2023-03-26'),
(17, 6, 1, '2023-03-26'),
(17, 6, 27, '2023-03-26'),
(17, 6, 31, '2023-03-26'),
(17, 10, 2, '2023-03-26'),
(17, 10, 27, '2023-03-26'),
(17, 10, 37, '2023-03-26'),
(17, 11, 37, '2023-03-26'),
(17, 14, 11, '2023-04-11'),
(17, 15, 27, '2023-03-26'),
(17, 15, 37, '2023-03-26'),
(17, 16, 1, '2023-03-26'),
(17, 19, 1, '2023-03-26'),
(17, 19, 2, '2023-03-26');

-- --------------------------------------------------------

--
-- Structure de la table `instrument`
--

CREATE TABLE `instrument` (
  `LIBELLE` char(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Déchargement des données de la table `instrument`
--

INSERT INTO `instrument` (`LIBELLE`) VALUES
('Accordéon'),
('Basse'),
('Batterie'),
('Flûte'),
('Guitare'),
('Harpe'),
('Piano'),
('Saxophone'),
('Trompette'),
('Violon');

-- --------------------------------------------------------

--
-- Structure de la table `jour`
--

CREATE TABLE `jour` (
  `JOUR` char(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Déchargement des données de la table `jour`
--

INSERT INTO `jour` (`JOUR`) VALUES
('Jeudi'),
('Lundi'),
('Mardi'),
('Mercredi'),
('Samedi'),
('Vendredi');

-- --------------------------------------------------------

--
-- Structure de la table `niveau`
--

CREATE TABLE `niveau` (
  `NIVEAU` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Déchargement des données de la table `niveau`
--

INSERT INTO `niveau` (`NIVEAU`) VALUES
(1),
(2),
(3),
(4);

-- --------------------------------------------------------

--
-- Structure de la table `payer`
--

CREATE TABLE `payer` (
  `IDELEVE` int(11) NOT NULL,
  `LIBELLE` char(32) NOT NULL,
  `DATEPAIEMENT` char(32) DEFAULT NULL,
  `PAYE` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Déchargement des données de la table `payer`
--

INSERT INTO `payer` (`IDELEVE`, `LIBELLE`, `DATEPAIEMENT`, `PAYE`) VALUES
(4, 'Trimestre 1 - 2023', '31/03/2023', 1),
(4, 'Trimestre 2 - 2023', '30/06/2023', 1),
(4, 'Trimestre 3 - 2023', '31/03/2023', 1),
(4, 'Trimestre 4 - 2023', '31/03/2023', 1),
(5, 'Trimestre 2 - 2023', '03/04/2023', 1),
(6, 'Trimestre 3 - 2023', '04/04/2023', 1),
(8, 'Trimestre 3 - 2023', '08/04/2023', 1),
(11, 'Trimestre 3 - 2023', '30/09/2023', 1),
(16, 'Trimestre 2 - 2023', '01/04/2023', 1),
(16, 'Trimestre 3 - 2023', '03/04/2023', 1),
(18, 'Trimestre 2 - 2023', '04/04/2023', 1);

-- --------------------------------------------------------

--
-- Structure de la table `personne`
--

CREATE TABLE `personne` (
  `ID` int(11) NOT NULL,
  `NOM` char(32) DEFAULT NULL,
  `PRENOM` char(32) DEFAULT NULL,
  `TEL` int(11) DEFAULT NULL,
  `MAIL` char(32) DEFAULT NULL,
  `ADRESSE` char(32) DEFAULT NULL,
  `IMAGE` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Déchargement des données de la table `personne`
--

INSERT INTO `personne` (`ID`, `NOM`, `PRENOM`, `TEL`, `MAIL`, `ADRESSE`, `IMAGE`) VALUES
(1, 'TREILLE', 'Lucas', 634500567, 'mail Lucas TREILLE', 'adresse Lucas TREILLE', 'https://cdn-icons-png.flaticon.com/512/2884/2884336.png'),
(2, 'TERPIN', 'Céleste', 63863854, 'mail Céleste', 'Adresse Céleste', 'https://static.vecteezy.com/ti/vecteur-libre/p3/14638198-icone-ancienne-harpe-style-simple-vectoriel.jpg'),
(3, 'ROMANET', 'Rayan', 63450872, 'mail Rayan', 'Adresse Rayan', 'https://cdn-icons-png.flaticon.com/512/26/26841.png'),
(4, 'AISSAOUI', 'Yasmine', 63852825, 'mail Yasmine', 'Adresse Yasmine', 'https://media.istockphoto.com/id/1326417862/fr/photo/jeune-femme-qui-rit-tout-en-se-relaxant-%C3%A0-la-maison.jpg?s=612x612&w=0&k=20&c=9kSRtp-LQLeKGWiBqBBNNmPKpzxoO445dyE3bLWQVm4='),
(5, 'Dupont', 'Jean', 123456789, 'jean.dupont@example.com', '12 rue de la Paix', 'https://media.istockphoto.com/id/1200677760/fr/photo/verticale-de-jeune-homme-de-sourire-beau-avec-des-bras-crois%C3%A9s.jpg?s=612x612&w=0&k=20&c=0TDS1aTXZzWLzI_X9eGBhqS_QZAz49zKEDKT8xsHZfU='),
(6, 'Martin', 'Marie', 234567890, 'marie.martin@example.com', '24 avenue des Champs-Élysées', 'https://img.freepik.com/photos-gratuite/sympathique-femme-brune-souriante-prete-aider-aider-tenant-mains-ensemble-ayant-air-agreable-debout-t-shirt-fond-blanc_176420-45398.jpg'),
(7, 'Durand', 'Pierre', 345678901, 'pierre.durand@example.com', '36 rue du Faubourg Saint-Honoré', 'https://img.freepik.com/vecteurs-premium/instrument-musique-icone-trompette-klaxon-isole-fond-blanc-fanfare-royale-pour-jouer-musique-illustration-vectorielle_342166-353.jpg?w=2000'),
(8, 'Lefebvre', 'Sophie', 456789012, 'sophie.lefebvre@example.com', '48 boulevard Haussmann', 'https://img.freepik.com/photos-gratuite/jeune-belle-femme-pull-chaud-rose-aspect-naturel-souriant-portrait-isole-cheveux-longs_285396-896.jpg'),
(9, 'Leroy', 'Antoine', 567890123, 'antoine.leroy@example.com', '60 avenue Montaigne', 'https://cdn-icons-png.flaticon.com/512/27/27328.png'),
(10, 'Moreau', 'Isabelle', 678901234, 'isabelle.moreau@example.com', '72 rue de Rivoli', 'https://img.freepik.com/photos-gratuite/concept-bonheur-bien-etre-confiance-cheerful-jolie-femme-afro-americaine-coupe-cheveux-boucles-poitrine-bras-croises-dans-pose-puissante-sure-elle-souriante-determinee-porter-pull-jaune_176420-35063.jpg'),
(11, 'Petit', 'François', 789012345, 'francois.petit@example.com', '84 boulevard des Invalides', 'https://img.freepik.com/photos-gratuite/bel-homme-souriant-confiant-mains-croisees-poitrine_176420-18743.jpg'),
(12, 'Roux', 'Émilie', 890123456, 'emilie.roux@example.com', '96 rue de la Pompe', 'https://cdn-icons-png.flaticon.com/512/253/253964.png'),
(13, 'Sauvage', 'Thierry', 901234567, 'thierry.sauvage@example.com', '108 avenue des Ternes', 'https://static.vecteezy.com/ti/vecteur-libre/p1/7873029-illustration-de-piano-icone-instrument-de-musique-tonalite-logo-adapte-pour-sites-web-applications-gratuit-vectoriel.jpg'),
(14, 'Simon', 'Camille', 123456789, 'camille.simon@example.com', '120 rue de la Roquette', 'https://fac.img.pmdstatic.net/fit/http.3A.2F.2Fprd2-bone-image.2Es3-website-eu-west-1.2Eamazonaws.2Ecom.2FFAC.2Fvar.2Ffemmeactuelle.2Fstorage.2Fimages.2Famour.2Fcoaching-amoureux.2Ftrucs-a-savoir-psychologie-masculine-comprendre-les-mecs-36795.2F14450368-1-fre-FR.2F8-trucs-a-savoir-sur-la-psychologie-masculine-pour-comprendre-les-mecs.2Ejpg/1200x900/quality/80/crop-from/center/8-trucs-a-savoir-sur-la-psychologie-masculine-pour-comprendre-les-hommes.jpeg'),
(15, 'Tanguy', 'Lucie', 234567890, 'lucie.tanguy@example.com', '132 avenue des Gobelins', 'https://instant-shooting.com/wp-content/uploads/2021/10/idee_pose_femme_photo_65-scaled.jpg'),
(16, 'Thomas', 'Guillaume', 345678901, 'guillaume.thomas@example.com', '144 rue Saint-Antoine', 'https://static.vecteezy.com/ti/photos-gratuite/t2/3492377-gros-plan-male-studio-portrait-de-homme-heureux-regardant-la-camera-image-gratuit-photo.jpg'),
(17, 'Vidal', 'Caroline', 456789012, 'caroline.vidal@example.com', '156 boulevard Saint-Germain', 'https://cdn-icons-png.flaticon.com/512/26/26241.png?w=360'),
(18, 'Boucher', 'Alexandre', 567890123, 'alexandre.boucher@example.com', '168 avenue de Clichy', 'https://img.freepik.com/photos-gratuite/mignon-jeune-homme-souriant-soies-recherche-satisfaction_176420-18989.jpg?w=2000'),
(19, 'Chevalier', 'Sophie', 678901234, 'sophie.chevalier@example.com', '180 rue de la Convention', 'https://images.pexels.com/photos/733872/pexels-photo-733872.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500');

-- --------------------------------------------------------

--
-- Structure de la table `prof`
--

CREATE TABLE `prof` (
  `IDPROF` int(11) NOT NULL,
  `INSTRUMENT` char(32) NOT NULL,
  `SALAIRE` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Déchargement des données de la table `prof`
--

INSERT INTO `prof` (`IDPROF`, `INSTRUMENT`, `SALAIRE`) VALUES
(1, 'Basse', 2500),
(2, 'Harpe', 2500),
(3, 'Flûte', 2500),
(7, 'Trompette', 1200),
(9, 'Batterie', 1700),
(12, 'Saxophone', 600),
(13, 'Piano', 5000),
(17, 'Accordéon', 1500);

-- --------------------------------------------------------

--
-- Structure de la table `seance`
--

CREATE TABLE `seance` (
  `IDPROF` int(11) NOT NULL,
  `NUMSEANCE` int(11) NOT NULL,
  `TRANCHE` char(32) NOT NULL,
  `JOUR` char(32) NOT NULL,
  `NIVEAU` int(11) NOT NULL,
  `CAPACITE` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Déchargement des données de la table `seance`
--

INSERT INTO `seance` (`IDPROF`, `NUMSEANCE`, `TRANCHE`, `JOUR`, `NIVEAU`, `CAPACITE`) VALUES
(1, 3, '9h00-12h00', 'Lundi', 3, 14),
(1, 13, '14h00-18h00', 'Mardi', 2, 8),
(1, 29, '8h00-10h00', 'Samedi', 3, 15),
(1, 38, '16h00-17h00', 'Samedi', 3, 18),
(2, 10, '16h00-17h00', 'Mardi', 2, 4),
(2, 15, '8h00-9h00', 'Mercredi', 2, 12),
(2, 25, '14h00-18h00', 'Vendredi', 3, 13),
(2, 33, '8h00-10h00', 'Samedi', 1, 8),
(2, 41, '17h00-19h00', 'Samedi', 4, 15),
(2, 45, '16h00-19h00', 'Lundi', 1, 152),
(3, 5, '11h00-13h00', 'Lundi', 3, 20),
(3, 14, '11h00-13h00', 'Mardi', 1, 22),
(3, 23, '12h00-13h00', 'Vendredi', 3, 15),
(3, 32, '11h00-12h00', 'Samedi', 2, 24),
(3, 40, '16h00-18h00', 'Samedi', 3, 25),
(7, 8, '13h00-15h00', 'Lundi', 1, 18),
(7, 20, '12h00-14h00', 'Mercredi', 3, 15),
(7, 36, '11h00-13h00', 'Samedi', 3, 22),
(7, 44, '14h00-16h00', 'Samedi', 2, 20),
(9, 17, '10h00-12h00', 'Mercredi', 2, 15),
(9, 21, '17h00-19h00', 'Vendredi', 2, 15),
(9, 26, '9h00-12h00', 'Vendredi', 3, 18),
(9, 30, '10h00-12h00', 'Samedi', 2, 12),
(9, 39, '12h00-14h00', 'Samedi', 3, 25),
(12, 4, '9h00-10h00', 'Lundi', 3, 5),
(12, 6, '14h00-18h00', 'Lundi', 3, 6),
(12, 9, '9h00-12h00', 'Mardi', 3, 12),
(12, 19, '16h00-19h00', 'Mercredi', 2, 7),
(12, 28, '13h00-15h00', 'Vendredi', 4, 12),
(12, 35, '10h00-11h00', 'Samedi', 1, 14),
(12, 43, '14h00-16h00', 'Samedi', 4, 18),
(13, 12, '13h00-15h00', 'Mardi', 2, 6),
(13, 16, '9h00-12h00', 'Mercredi', 3, 5),
(13, 22, '16h00-19h00', 'Vendredi', 3, 12),
(13, 24, '8h00-12h00', 'Vendredi', 3, 7),
(13, 34, '8h00-12h00', 'Samedi', 2, 6),
(13, 42, '14h00-18h00', 'Samedi', 3, 10),
(17, 1, '8h00-12h00', 'Lundi', 4, 16),
(17, 2, '16h00-18h00', 'Lundi', 1, 10),
(17, 11, '8h00-12h00', 'Mardi', 1, 16),
(17, 18, '14h00-16h00', 'Mercredi', 3, 18),
(17, 27, '16h00-17h00', 'Vendredi', 2, 15),
(17, 31, '9h00-12h00', 'Samedi', 2, 18),
(17, 37, '13h00-14h00', 'Samedi', 2, 15);

-- --------------------------------------------------------

--
-- Structure de la table `trim`
--

CREATE TABLE `trim` (
  `LIBELLE` char(32) NOT NULL,
  `DATEFIN` char(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Déchargement des données de la table `trim`
--

INSERT INTO `trim` (`LIBELLE`, `DATEFIN`) VALUES
('Trimestre 1 - 2023', '31/03/2023'),
('Trimestre 2 - 2023', '30/06/2023'),
('Trimestre 3 - 2023', '30/09/2023'),
('Trimestre 4 - 2023', '31/12/2023');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `administrateur`
--
ALTER TABLE `administrateur`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `eleve`
--
ALTER TABLE `eleve`
  ADD PRIMARY KEY (`IDELEVE`),
  ADD KEY `I_FK_ELEVE_NIVEAU` (`NIVEAU`);

--
-- Index pour la table `heure`
--
ALTER TABLE `heure`
  ADD PRIMARY KEY (`TRANCHE`);

--
-- Index pour la table `inscription`
--
ALTER TABLE `inscription`
  ADD PRIMARY KEY (`IDPROF`,`IDELEVE`,`NUMSEANCE`),
  ADD KEY `I_FK_INSCRIPTION_ELEVE` (`IDELEVE`),
  ADD KEY `I_FK_INSCRIPTION_SEANCE` (`IDPROF`,`NUMSEANCE`),
  ADD KEY `fk_numSeance` (`NUMSEANCE`);

--
-- Index pour la table `instrument`
--
ALTER TABLE `instrument`
  ADD PRIMARY KEY (`LIBELLE`);

--
-- Index pour la table `jour`
--
ALTER TABLE `jour`
  ADD PRIMARY KEY (`JOUR`);

--
-- Index pour la table `niveau`
--
ALTER TABLE `niveau`
  ADD PRIMARY KEY (`NIVEAU`),
  ADD KEY `NIVEAU` (`NIVEAU`);

--
-- Index pour la table `payer`
--
ALTER TABLE `payer`
  ADD PRIMARY KEY (`IDELEVE`,`LIBELLE`) USING BTREE,
  ADD KEY `I_FK_PAYER_TRIM` (`LIBELLE`),
  ADD KEY `fk_paye_eleve` (`IDELEVE`),
  ADD KEY `I_FK_PAYER_INSCRIPTION` (`IDELEVE`) USING BTREE;

--
-- Index pour la table `personne`
--
ALTER TABLE `personne`
  ADD PRIMARY KEY (`ID`);

--
-- Index pour la table `prof`
--
ALTER TABLE `prof`
  ADD PRIMARY KEY (`IDPROF`),
  ADD KEY `I_FK_PROF_INSTRUMENT` (`INSTRUMENT`);

--
-- Index pour la table `seance`
--
ALTER TABLE `seance`
  ADD PRIMARY KEY (`IDPROF`,`NUMSEANCE`),
  ADD KEY `I_FK_SEANCE_JOUR` (`JOUR`),
  ADD KEY `I_FK_SEANCE_NIVEAU` (`NIVEAU`),
  ADD KEY `I_FK_SEANCE_PROF` (`IDPROF`),
  ADD KEY `fk_tranche` (`TRANCHE`),
  ADD KEY `NUMSEANCE` (`NUMSEANCE`);

--
-- Index pour la table `trim`
--
ALTER TABLE `trim`
  ADD PRIMARY KEY (`LIBELLE`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `administrateur`
--
ALTER TABLE `administrateur`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT pour la table `personne`
--
ALTER TABLE `personne`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=47;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `eleve`
--
ALTER TABLE `eleve`
  ADD CONSTRAINT `fk_idEleve` FOREIGN KEY (`IDELEVE`) REFERENCES `personne` (`ID`),
  ADD CONSTRAINT `fk_niveau` FOREIGN KEY (`NIVEAU`) REFERENCES `niveau` (`NIVEAU`);

--
-- Contraintes pour la table `inscription`
--
ALTER TABLE `inscription`
  ADD CONSTRAINT `fk_insc_eleve` FOREIGN KEY (`IDELEVE`) REFERENCES `eleve` (`IDELEVE`),
  ADD CONSTRAINT `fk_inscr_prof` FOREIGN KEY (`IDPROF`) REFERENCES `prof` (`IDPROF`),
  ADD CONSTRAINT `fk_numSeance` FOREIGN KEY (`NUMSEANCE`) REFERENCES `seance` (`NUMSEANCE`);

--
-- Contraintes pour la table `payer`
--
ALTER TABLE `payer`
  ADD CONSTRAINT `fk_paye_eleve` FOREIGN KEY (`IDELEVE`) REFERENCES `eleve` (`IDELEVE`),
  ADD CONSTRAINT `fk_paye_lib` FOREIGN KEY (`LIBELLE`) REFERENCES `trim` (`LIBELLE`);

--
-- Contraintes pour la table `prof`
--
ALTER TABLE `prof`
  ADD CONSTRAINT `fk_idProf` FOREIGN KEY (`IDPROF`) REFERENCES `personne` (`ID`),
  ADD CONSTRAINT `fk_refInstrument` FOREIGN KEY (`INSTRUMENT`) REFERENCES `instrument` (`LIBELLE`);

--
-- Contraintes pour la table `seance`
--
ALTER TABLE `seance`
  ADD CONSTRAINT `fk_jour` FOREIGN KEY (`JOUR`) REFERENCES `jour` (`JOUR`),
  ADD CONSTRAINT `fk_prof` FOREIGN KEY (`IDPROF`) REFERENCES `prof` (`IDPROF`),
  ADD CONSTRAINT `fk_tranche` FOREIGN KEY (`TRANCHE`) REFERENCES `heure` (`TRANCHE`),
  ADD CONSTRAINT `seance_ibfk_1` FOREIGN KEY (`NIVEAU`) REFERENCES `niveau` (`NIVEAU`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

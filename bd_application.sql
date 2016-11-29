-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- Généré le :  Mar 29 Novembre 2016 à 21:27
-- Version du serveur :  5.6.17
-- Version de PHP :  5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de données :  `bd_application`
--

-- --------------------------------------------------------

--
-- Structure de la table `categories`
--

CREATE TABLE IF NOT EXISTS `categories` (
  `ID_Categorie` int(11) NOT NULL AUTO_INCREMENT,
  `Nom_Categorie` varchar(100) NOT NULL,
  `Description` varchar(1000) DEFAULT NULL,
  PRIMARY KEY (`ID_Categorie`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=12 ;

--
-- Contenu de la table `categories`
--

INSERT INTO `categories` (`ID_Categorie`, `Nom_Categorie`, `Description`) VALUES
(1, 'Fruits  et Légumes', 'AAA'),
(3, 'Viandes et substituts', NULL),
(4, 'Produits laitiers', NULL),
(5, 'Matières grasses', NULL),
(6, 'Légumes et fruits', NULL),
(7, 'Produits céréaliers', NULL),
(8, 'Sucres et produits sucrés', NULL),
(9, 'Boissons', NULL),
(10, 'Épices', NULL),
(11, 'Divers', NULL);

-- --------------------------------------------------------

--
-- Structure de la table `commandes`
--

CREATE TABLE IF NOT EXISTS `commandes` (
  `ID_Commande` int(11) NOT NULL AUTO_INCREMENT,
  `Date_Commande` date NOT NULL,
  `fournisseur` int(12) NOT NULL,
  `No_Reference` varchar(25) DEFAULT NULL,
  `Note` text NOT NULL,
  `envoye` tinyint(1) NOT NULL,
  `date_reception` date NOT NULL,
  `recue` tinyint(1) NOT NULL,
  `note_reception` text NOT NULL,
  PRIMARY KEY (`ID_Commande`),
  UNIQUE KEY `No_Reference_3` (`No_Reference`),
  KEY `No_Reference` (`No_Reference`),
  KEY `No_Reference_2` (`No_Reference`),
  KEY `fournisseur` (`fournisseur`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=7 ;

--
-- Contenu de la table `commandes`
--

INSERT INTO `commandes` (`ID_Commande`, `Date_Commande`, `fournisseur`, `No_Reference`, `Note`, `envoye`, `date_reception`, `recue`, `note_reception`) VALUES
(1, '2016-11-10', 1, '45432', 'Livrée le matin', 0, '0000-00-00', 0, ''),
(2, '2016-11-23', 2, '54312', 'Pas de lait dans la commande', 1, '2016-11-30', 1, ''),
(3, '2016-11-15', 2, '568468', '', 1, '0000-00-00', 0, ''),
(4, '2016-11-18', 1, '125085', '', 1, '0000-00-00', 0, ''),
(5, '2016-11-15', 2, '772181', '', 1, '0000-00-00', 0, ''),
(6, '2016-11-15', 1, '642859', '', 1, '0000-00-00', 0, '');

-- --------------------------------------------------------

--
-- Structure de la table `details_commande`
--

CREATE TABLE IF NOT EXISTS `details_commande` (
  `ID_COMMANDE` int(11) NOT NULL,
  `produit` int(11) NOT NULL,
  `total` double NOT NULL,
  `format` varchar(50) NOT NULL,
  `id_detail` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id_detail`),
  KEY `ID_COMMANDE` (`ID_COMMANDE`),
  KEY `produit` (`produit`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=8 ;

-- --------------------------------------------------------

--
-- Structure de la table `details_recette`
--

CREATE TABLE IF NOT EXISTS `details_recette` (
  `ID_Produit` int(11) NOT NULL,
  `ID_Recette` int(11) NOT NULL,
  `Quantite` double NOT NULL,
  `Unite_Mesure` varchar(35) NOT NULL,
  `id_detail` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id_detail`),
  KEY `ID_Produit` (`ID_Produit`),
  KEY `ID_Recette` (`ID_Recette`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

-- --------------------------------------------------------

--
-- Structure de la table `evenements`
--

CREATE TABLE IF NOT EXISTS `evenements` (
  `id_evenement` int(11) NOT NULL AUTO_INCREMENT,
  `Nom_Evenement` varchar(250) NOT NULL,
  `Date_Evenement` date NOT NULL,
  `image` varchar(255) NOT NULL,
  `id_recette` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_evenement`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=12 ;

--
-- Contenu de la table `evenements`
--

INSERT INTO `evenements` (`id_evenement`, `Nom_Evenement`, `Date_Evenement`, `image`, `id_recette`) VALUES
(11, 'Cours recette poulet frit', '2016-11-30', '2.png', 3);

-- --------------------------------------------------------

--
-- Structure de la table `format_produit`
--

CREATE TABLE IF NOT EXISTS `format_produit` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `produit_fournisseur` int(11) NOT NULL,
  `format` varchar(50) NOT NULL,
  `prix` double NOT NULL,
  PRIMARY KEY (`id`),
  KEY `produit_fournisseur` (`produit_fournisseur`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

-- --------------------------------------------------------

--
-- Structure de la table `fournisseurs`
--

CREATE TABLE IF NOT EXISTS `fournisseurs` (
  `ID_Fournisseur` int(11) NOT NULL AUTO_INCREMENT,
  `Nom_Fournisseur` varchar(50) NOT NULL,
  `Note` text,
  `Adresse` varchar(75) DEFAULT NULL,
  `Ville` varchar(75) DEFAULT NULL,
  `Province` varchar(30) DEFAULT NULL,
  `Code_Postal` char(7) DEFAULT NULL,
  `Telephone` char(14) DEFAULT NULL,
  `Poste` varchar(30) DEFAULT NULL,
  `Cell` char(14) DEFAULT NULL,
  `Fax` char(14) DEFAULT NULL,
  `Nom_Contact` varchar(75) DEFAULT NULL,
  `Jour_Commande` varchar(60) DEFAULT NULL,
  `Jour_Livraison` varchar(60) DEFAULT NULL,
  `Delai_Commande` int(3) DEFAULT NULL,
  `Cout_Minimum` double DEFAULT NULL,
  `Frais_Livraison` double DEFAULT NULL,
  `Courriel` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID_Fournisseur`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Contenu de la table `fournisseurs`
--

INSERT INTO `fournisseurs` (`ID_Fournisseur`, `Nom_Fournisseur`, `Note`, `Adresse`, `Ville`, `Province`, `Code_Postal`, `Telephone`, `Poste`, `Cell`, `Fax`, `Nom_Contact`, `Jour_Commande`, `Jour_Livraison`, `Delai_Commande`, `Cout_Minimum`, `Frais_Livraison`, `Courriel`) VALUES
(1, 'Provigo le Marché', NULL, '2500 Boulevard des Forges', 'Trois-Rivières', 'Québec', 'G8Y 4F2', '(819)373-9841', '4613', '(819)609-1234', '(819)376-9841', 'John Doe', 'Lundi', 'Mercredi', 2, 50, 15, NULL),
(2, 'Métro Des Forges', NULL, '2500 Aubuchon', 'Trois-Rivières', 'Québec', 'G8Y 5G7', '(819)376-1721', '6543', '(819)325-5654', '(819)363-3213', 'Marc Lavoie', 'Mardi', 'Jeudi', 2, 45, 10, NULL),
(3, 'IGA Marché Paquette', NULL, '3500 Boulevard des Forges', 'Trois-Rivières', 'Québec', 'G8Y 4F2', '(819)373-9542', '4643', '(819)692-1234', '(819)376-9542', 'Jean Paquette', 'Lundi', 'Mercredi', 2, 50, 15, NULL),
(4, 'Marché Végétarien', NULL, '2502 Boulevard des Forges', 'Trois-Rivières', 'Québec', 'G8Y 6G5', '(819)376-1756', '6543', '(819)325-5443', '(819)363-3212', NULL, 'Mardi', 'Jeudi', 2, 45, 10, NULL);

-- --------------------------------------------------------

--
-- Structure de la table `inventaire`
--

CREATE TABLE IF NOT EXISTS `inventaire` (
  `ID_Inventaire` int(11) NOT NULL AUTO_INCREMENT,
  `Produit` int(11) NOT NULL,
  `Nom` varchar(250) DEFAULT NULL,
  `Quantite` double DEFAULT NULL,
  `Format` varchar(10) DEFAULT NULL,
  `Description` varchar(200) DEFAULT NULL,
  `Peremption` date DEFAULT NULL,
  `Date_Reception` date DEFAULT NULL,
  `Equivalence` double DEFAULT NULL,
  `Unite_Equivalence` varchar(10) DEFAULT NULL,
  `Unite` varchar(10) DEFAULT NULL,
  `Total` double DEFAULT NULL,
  `UPC` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`ID_Inventaire`),
  KEY `Produit` (`Produit`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=14 ;

--
-- Contenu de la table `inventaire`
--

INSERT INTO `inventaire` (`ID_Inventaire`, `Produit`, `Nom`, `Quantite`, `Format`, `Description`, `Peremption`, `Date_Reception`, `Equivalence`, `Unite_Equivalence`, `Unite`, `Total`, `UPC`) VALUES
(12, 14, 'Primex', 1, '10', '123', '2016-11-29', '2016-11-29', NULL, '', 'ml', 10, NULL),
(13, 14, 'Dualex', 4, '7', '', '2016-11-29', '2016-11-08', NULL, NULL, 'kg', 28, NULL);

-- --------------------------------------------------------

--
-- Structure de la table `messages`
--

CREATE TABLE IF NOT EXISTS `messages` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `titre` varchar(255) NOT NULL,
  `message` text NOT NULL,
  `debut_affichage` date DEFAULT NULL,
  `fin_affichage` date DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Contenu de la table `messages`
--

INSERT INTO `messages` (`id`, `titre`, `message`, `debut_affichage`, `fin_affichage`) VALUES
(5, 'Message du jour', 'Lorem ipsum dolor sit red neque', '2016-11-29', '2016-11-29');

-- --------------------------------------------------------

--
-- Structure de la table `produits`
--

CREATE TABLE IF NOT EXISTS `produits` (
  `ID_Produit` int(11) NOT NULL AUTO_INCREMENT,
  `Nom_Produit` varchar(100) NOT NULL,
  `Categorie` int(11) NOT NULL,
  `Duree_Vie` int(4) DEFAULT NULL,
  `Taxable_Federal` tinyint(1) NOT NULL,
  `Taxable_Provincial` tinyint(1) NOT NULL,
  `Code_UCP` int(11) DEFAULT NULL,
  `Perissable` tinyint(1) NOT NULL,
  `Description` varchar(250) DEFAULT NULL,
  `hidden` tinyint(1) NOT NULL,
  PRIMARY KEY (`ID_Produit`),
  KEY `Categorie` (`Categorie`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=15 ;

--
-- Contenu de la table `produits`
--

INSERT INTO `produits` (`ID_Produit`, `Nom_Produit`, `Categorie`, `Duree_Vie`, `Taxable_Federal`, `Taxable_Provincial`, `Code_UCP`, `Perissable`, `Description`, `hidden`) VALUES
(8, 'Fromage En Crotte', 1, 2, 1, 1, NULL, 1, 'Il fait Sqwick Sqwick', 1),
(12, 'Pomme1', 1, NULL, 0, 0, NULL, 0, '', 0),
(13, 'gfds', 1, NULL, 0, 0, NULL, 0, '', 0),
(14, 'Methadone', 1, NULL, 0, 0, NULL, 0, '', 0);

-- --------------------------------------------------------

--
-- Structure de la table `produits_fournisseurs`
--

CREATE TABLE IF NOT EXISTS `produits_fournisseurs` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `ID_Produit` int(11) NOT NULL,
  `ID_Fournisseur` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `ID_Produit` (`ID_Produit`),
  KEY `ID_Produit_2` (`ID_Produit`),
  KEY `ID_Fournisseur` (`ID_Fournisseur`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

-- --------------------------------------------------------

--
-- Structure de la table `recettes`
--

CREATE TABLE IF NOT EXISTS `recettes` (
  `ID_Recette` int(11) NOT NULL AUTO_INCREMENT,
  `Nom` varchar(50) NOT NULL,
  `Temps_Preparation` varchar(15) DEFAULT NULL,
  `Temps_Cuisson` varchar(15) DEFAULT NULL,
  `Nb_Portions` varchar(15) DEFAULT NULL,
  `Taille_Portion` varchar(15) DEFAULT NULL,
  `Unite_Mesure` varchar(15) DEFAULT NULL,
  `Temperature` varchar(10) DEFAULT NULL,
  `Temps_Refroidissement` varchar(15) DEFAULT NULL,
  `Etapes` text,
  `Image` varchar(255) DEFAULT NULL,
  `Remarque` text,
  `Allergene` varchar(250) DEFAULT NULL,
  `Duree_Conservation` varchar(15) DEFAULT NULL,
  `Categorie` varchar(50) NOT NULL,
  `congelable` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`ID_Recette`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `commandes`
--
ALTER TABLE `commandes`
  ADD CONSTRAINT `commandes_ibfk_1` FOREIGN KEY (`fournisseur`) REFERENCES `fournisseurs` (`ID_Fournisseur`);

--
-- Contraintes pour la table `details_commande`
--
ALTER TABLE `details_commande`
  ADD CONSTRAINT `details_commande_ibfk_1` FOREIGN KEY (`ID_COMMANDE`) REFERENCES `commandes` (`ID_Commande`),
  ADD CONSTRAINT `details_commande_ibfk_2` FOREIGN KEY (`produit`) REFERENCES `produits` (`ID_Produit`);

--
-- Contraintes pour la table `details_recette`
--
ALTER TABLE `details_recette`
  ADD CONSTRAINT `details_recette_ibfk_1` FOREIGN KEY (`ID_Produit`) REFERENCES `produits` (`ID_Produit`),
  ADD CONSTRAINT `details_recette_ibfk_2` FOREIGN KEY (`ID_Recette`) REFERENCES `recettes` (`ID_Recette`);

--
-- Contraintes pour la table `format_produit`
--
ALTER TABLE `format_produit`
  ADD CONSTRAINT `format_produit_ibfk_1` FOREIGN KEY (`produit_fournisseur`) REFERENCES `produits_fournisseurs` (`id`);

--
-- Contraintes pour la table `inventaire`
--
ALTER TABLE `inventaire`
  ADD CONSTRAINT `inventaire_ibfk_1` FOREIGN KEY (`Produit`) REFERENCES `produits` (`ID_Produit`);

--
-- Contraintes pour la table `produits`
--
ALTER TABLE `produits`
  ADD CONSTRAINT `produits_ibfk_1` FOREIGN KEY (`Categorie`) REFERENCES `categories` (`ID_Categorie`);

--
-- Contraintes pour la table `produits_fournisseurs`
--
ALTER TABLE `produits_fournisseurs`
  ADD CONSTRAINT `produits_fournisseurs_ibfk_1` FOREIGN KEY (`ID_Produit`) REFERENCES `produits` (`ID_Produit`),
  ADD CONSTRAINT `produits_fournisseurs_ibfk_2` FOREIGN KEY (`ID_Fournisseur`) REFERENCES `fournisseurs` (`ID_Fournisseur`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

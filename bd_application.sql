-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- Généré le :  Mar 08 Novembre 2016 à 19:04
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
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Contenu de la table `categories`
--

INSERT INTO `categories` (`ID_Categorie`, `Nom_Categorie`, `Description`) VALUES
(1, 'A', 'AAA'),
(2, 'B', 'BBB');

-- --------------------------------------------------------

--
-- Structure de la table `commandes`
--

CREATE TABLE IF NOT EXISTS `commandes` (
  `ID_Commande` int(11) NOT NULL AUTO_INCREMENT,
  `Date_Commande` date NOT NULL,
  `fournisseur` int(12) NOT NULL,
  `No_Reference` varchar(25) DEFAULT NULL,
  `Note` text,
  `envoye` tinyint(1) NOT NULL,
  PRIMARY KEY (`ID_Commande`),
  KEY `fournisseur` (`fournisseur`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Contenu de la table `commandes`
--

INSERT INTO `commandes` (`ID_Commande`, `Date_Commande`, `fournisseur`, `No_Reference`, `Note`, `envoye`) VALUES
(1, '2016-11-24', 1, '5453', 'Livrée le matin', 0),
(2, '2016-11-29', 1, '7654', 'Pas de lait dans la commande', 0),
(3, '2016-11-24', 1, '745024', 'Allo', 1),
(4, '2016-11-21', 1, '249064', '', 1);

-- --------------------------------------------------------

--
-- Structure de la table `details_commande`
--

CREATE TABLE IF NOT EXISTS `details_commande` (
  `ID_COMMANDE` int(11) NOT NULL,
  `produit` int(11) NOT NULL,
  `total` double NOT NULL,
  KEY `ID_COMMANDE` (`ID_COMMANDE`),
  KEY `produit` (`produit`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `details_commande`
--

INSERT INTO `details_commande` (`ID_COMMANDE`, `produit`, `total`) VALUES
(2, 2, 50);

-- --------------------------------------------------------

--
-- Structure de la table `details_recette`
--

CREATE TABLE IF NOT EXISTS `details_recette` (
  `ID_Produit` int(11) NOT NULL,
  `ID_Recette` int(11) NOT NULL,
  `Quantite` double NOT NULL,
  `Unite_Mesure` varchar(35) NOT NULL,
  KEY `ID_Produit` (`ID_Produit`),
  KEY `ID_Recette` (`ID_Recette`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `evenements`
--

CREATE TABLE IF NOT EXISTS `evenements` (
  `id_evenement` int(11) NOT NULL AUTO_INCREMENT,
  `Nom_Evenement` varchar(250) NOT NULL,
  `Date_Evenement` date NOT NULL,
  `image` varchar(255) NOT NULL,
  PRIMARY KEY (`id_evenement`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Contenu de la table `evenements`
--

INSERT INTO `evenements` (`id_evenement`, `Nom_Evenement`, `Date_Evenement`, `image`) VALUES
(1, 'Cours groupe 1', '2016-10-25', '1.png'),
(2, 'sdf', '2016-10-25', '1.png'),
(3, '', '2016-10-25', '1.png');

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
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Contenu de la table `fournisseurs`
--

INSERT INTO `fournisseurs` (`ID_Fournisseur`, `Nom_Fournisseur`, `Note`, `Adresse`, `Ville`, `Province`, `Code_Postal`, `Telephone`, `Poste`, `Cell`, `Fax`, `Nom_Contact`, `Jour_Commande`, `Jour_Livraison`, `Delai_Commande`, `Cout_Minimum`, `Frais_Livraison`, `Courriel`) VALUES
(1, 'IGA Marché Paquette', NULL, '2500 Boulevard des Forges', 'Trois-Rivières', 'Québec', 'G5G 4F4', '(819)373-1234', '1234', '(819)692-1234', '(819)373-9841', 'John Doe', 'Lundi', 'Mardi', 1, 50, 10, 'igaTR@iga.ca'),
(2, 'Métro Fournier', NULL, '2500 Aubuchon', 'Trois-Rivières', 'Québec', 'G6T 4D1', '(819)373-1234', '1234', '(819)609-0111', '(819)423-1234', 'Jean Fournier', 'Mardi', 'Vendredi', 3, 50, 5, NULL);

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
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=12 ;

--
-- Contenu de la table `inventaire`
--

INSERT INTO `inventaire` (`ID_Inventaire`, `Produit`, `Nom`, `Quantite`, `Format`, `Description`, `Peremption`, `Date_Reception`, `Equivalence`, `Unite_Equivalence`, `Unite`, `Total`, `UPC`) VALUES
(9, 2, 'Sac de pomme', 2, '5', 'asadsa', '2016-10-26', '2016-10-04', NULL, '', 'lbs', 10, NULL),
(11, 3, 'Caisse de poires', 1, '50', '', '2016-10-17', '2016-10-17', 0.1, 'kg', 'Unité', 50, NULL);

-- --------------------------------------------------------

--
-- Structure de la table `messages`
--

CREATE TABLE IF NOT EXISTS `messages` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `titre` varchar(255) NOT NULL,
  `message` text NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

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
  PRIMARY KEY (`ID_Produit`),
  KEY `Categorie` (`Categorie`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=7 ;

--
-- Contenu de la table `produits`
--

INSERT INTO `produits` (`ID_Produit`, `Nom_Produit`, `Categorie`, `Duree_Vie`, `Taxable_Federal`, `Taxable_Provincial`, `Code_UCP`, `Perissable`, `Description`) VALUES
(2, 'Pomme', 2, NULL, 1, 0, NULL, 1, 'Ceci est un fruit'),
(3, 'Poire', 1, NULL, 1, 0, NULL, 0, 'Ceci est une poire poireuse. Oui oui'),
(4, 'Blé', 1, NULL, 0, 1, NULL, 0, ' ');

-- --------------------------------------------------------

--
-- Structure de la table `produits_fournisseurs`
--

CREATE TABLE IF NOT EXISTS `produits_fournisseurs` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `ID_Produit` int(11) NOT NULL,
  `ID_Fournisseur` int(11) NOT NULL,
  `Prix` double DEFAULT NULL,
  `Format_Achat` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `ID_Produit` (`ID_Produit`),
  KEY `ID_Fournisseur` (`ID_Fournisseur`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Contenu de la table `produits_fournisseurs`
--

INSERT INTO `produits_fournisseurs` (`id`, `ID_Produit`, `ID_Fournisseur`, `Prix`, `Format_Achat`) VALUES
(1, 2, 1, 50, 'Sac de 500g'),
(2, 3, 1, 25, 'Sac de 1kg');

-- --------------------------------------------------------

--
-- Structure de la table `recettes`
--

CREATE TABLE IF NOT EXISTS `recettes` (
  `ID_Recette` int(11) NOT NULL AUTO_INCREMENT,
  `Nom` varchar(50) NOT NULL,
  `Temps_Preparation` double DEFAULT NULL,
  `Temps_Cuisson` double DEFAULT NULL,
  `Nb_Portions` varchar(15) DEFAULT NULL,
  `Taille_Portion` varchar(15) DEFAULT NULL,
  `Unite_Mesure` varchar(15) DEFAULT NULL,
  `Temperature` varchar(10) DEFAULT NULL,
  `Temps_Refroidissement` double DEFAULT NULL,
  `Etapes` text,
  `Image` varchar(255) DEFAULT NULL,
  `Remarque` text,
  `Allergene` varchar(250) DEFAULT NULL,
  `Duree_Conservation` int(4) DEFAULT NULL,
  `Categorie` varchar(50) NOT NULL,
  `congelable` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`ID_Recette`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

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
  ADD CONSTRAINT `details_commande_ibfk_2` FOREIGN KEY (`produit`) REFERENCES `produits` (`ID_Produit`),
  ADD CONSTRAINT `details_commande_ibfk_1` FOREIGN KEY (`ID_COMMANDE`) REFERENCES `commandes` (`ID_Commande`);

--
-- Contraintes pour la table `details_recette`
--
ALTER TABLE `details_recette`
  ADD CONSTRAINT `details_recette_ibfk_2` FOREIGN KEY (`ID_Recette`) REFERENCES `recettes` (`ID_Recette`),
  ADD CONSTRAINT `details_recette_ibfk_1` FOREIGN KEY (`ID_Produit`) REFERENCES `produits` (`ID_Produit`);

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
  ADD CONSTRAINT `produits_fournisseurs_ibfk_2` FOREIGN KEY (`ID_Fournisseur`) REFERENCES `fournisseurs` (`ID_Fournisseur`),
  ADD CONSTRAINT `produits_fournisseurs_ibfk_1` FOREIGN KEY (`ID_Produit`) REFERENCES `produits` (`ID_Produit`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

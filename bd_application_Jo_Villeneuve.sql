-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- Généré le :  Lun 12 Décembre 2016 à 22:28
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
(1, 'Fruits et Légumes', NULL),
(3, 'Viandes et substituts', NULL),
(4, 'Produits laitiers', NULL),
(5, 'Matières grasses', NULL),
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
  PRIMARY KEY (`ID_Commande`),
  UNIQUE KEY `No_Reference_3` (`No_Reference`),
  KEY `No_Reference` (`No_Reference`),
  KEY `No_Reference_2` (`No_Reference`),
  KEY `fournisseur` (`fournisseur`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=12 ;

--
-- Contenu de la table `commandes`
--

INSERT INTO `commandes` (`ID_Commande`, `Date_Commande`, `fournisseur`, `No_Reference`, `Note`, `envoye`) VALUES
(1, '2016-11-10', 1, '45432', 'Livrée le matin', 0),
(2, '2016-11-23', 2, '54312', 'Pas de lait dans la commande', 1),
(3, '2016-11-15', 2, '568468', '', 1),
(4, '2016-11-18', 1, '125085', '', 1),
(5, '2016-11-15', 2, '772181', '', 1),
(6, '2016-11-15', 1, '642859', '', 1),
(7, '2016-12-12', 1, '838328', '', 1),
(8, '2016-12-12', 1, '302680', '', 1),
(9, '2016-12-12', 1, '633973', '', 1),
(10, '2016-12-12', 1, '984693', '', 1),
(11, '2016-12-12', 2, '447977', '', 1);

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
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=14 ;

--
-- Contenu de la table `details_commande`
--

INSERT INTO `details_commande` (`ID_COMMANDE`, `produit`, `total`, `format`, `id_detail`) VALUES
(1, 15, 27.5, '3 Sac de 1l', 8),
(7, 15, 4, 'Pinte de 2l', 9),
(8, 15, 6, '3 Sac de 1l', 10),
(9, 15, 4, 'Pinte de 2l', 11),
(10, 15, 4, 'Pinte de 2l', 12),
(11, 25, 4, 'Boite de 50g', 13);

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
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=62 ;

--
-- Contenu de la table `details_recette`
--

INSERT INTO `details_recette` (`ID_Produit`, `ID_Recette`, `Quantite`, `Unite_Mesure`, `id_detail`) VALUES
(35, 7, 3, 'L', 42),
(31, 7, 12, 'Unité', 43),
(21, 6, 8, 'Unité', 44),
(22, 6, 8, 'Unité', 45),
(23, 6, 750, 'g', 46),
(15, 6, 500, 'ml', 47),
(20, 6, 3, 'ml', 48),
(19, 6, 5, 'ml', 49),
(18, 6, 8, 'ml', 50),
(17, 6, 8, 'ml', 51),
(16, 6, 8, 'ml', 52),
(24, 6, 8, 'ml', 53),
(19, 6, 8, 'ml', 54),
(18, 6, 8, 'ml', 55),
(17, 6, 8, 'ml', 56),
(25, 6, 8, 'ml', 57),
(16, 6, 8, 'ml', 58),
(26, 6, 250, 'ml', 59),
(28, 6, 15, 'ml', 60),
(27, 6, 5, 'ml', 61);

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
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=16 ;

--
-- Contenu de la table `evenements`
--

INSERT INTO `evenements` (`id_evenement`, `Nom_Evenement`, `Date_Evenement`, `image`, `id_recette`) VALUES
(12, 'Ménage du département', '2016-12-07', '4.png', NULL),
(13, 'Mise à jour de l''application', '2016-12-05', '4.png', NULL),
(14, 'Cours sur le Poulet Frit - Groupe 3', '2016-12-15', '3.png', 6),
(15, 'Cours sur le Poulet Frit - Groupe 1', '2016-12-16', '3.png', 6);

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
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=16 ;

--
-- Contenu de la table `format_produit`
--

INSERT INTO `format_produit` (`id`, `produit_fournisseur`, `format`, `prix`) VALUES
(4, 4, 'Pinte de 2l', 3.5),
(5, 4, '3 Sac de 1l', 5.5),
(6, 5, 'Boite de 500g', 5),
(7, 5, 'Boite de 1kg', 10),
(8, 6, 'Boite de 100g', 7.5),
(9, 6, 'Boite de 250g', 8),
(10, 7, 'Paquet de 3 Pilons', 6.73),
(11, 7, 'Paquet de 6 Pilons', 10),
(12, 8, 'Boite de 50g', 4.5),
(13, 8, 'Boite de 100g', 8),
(14, 9, 'Pot de 250ml', 7),
(15, 9, 'Pot de 500ml', 9);

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
(3, 'IGA Marché Paquette', '    ', '3500 Boulevard des Forges', 'Trois-Rivières', 'Québec', 'G8Y 4F2', '(819)373-9542', '4643', '(819)692-1234', '(819)376-9542', 'Jean Paquette', 'Lundi', 'Mercredi', 2, 50, 15, ''),
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
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=39 ;

--
-- Contenu de la table `inventaire`
--

INSERT INTO `inventaire` (`ID_Inventaire`, `Produit`, `Nom`, `Quantite`, `Format`, `Description`, `Peremption`, `Date_Reception`, `Equivalence`, `Unite_Equivalence`, `Unite`, `Total`, `UPC`) VALUES
(14, 22, 'Caisse de cuisse de poulets', 2, '5', 'Reçu dans une caisse en bois', '2016-12-29', '2016-12-14', 350, 'g', 'Unité', 10, NULL),
(15, 23, 'Farine Robin Hood All Purpose 10kg', 5, '10', ' ', '2019-08-23', '2016-12-05', NULL, NULL, 'kg', 50, NULL),
(16, 15, 'Lait de beurre 0.25% Québon', 17, '1', '', '2016-12-30', '2016-12-05', NULL, '', 'L', 17, NULL),
(17, 26, 'Mayonnaise Sunpic', 1, '10', '', '2016-12-05', '2016-12-05', 450, 'ml', 'Unité', 10, NULL),
(18, 28, 'Miel Labonté Pure and Natural', 5, '500', '', '2016-12-05', '2016-12-05', NULL, NULL, 'ml', 2500, NULL),
(19, 28, 'Miel Billy Bee', 10, '10', '', '2016-12-05', '2016-12-05', 100, 'ml', 'Unité', 100, NULL),
(20, 25, 'Oriental Hot Mustard Powder', 3, '97', '', '2016-12-05', '2016-12-05', NULL, NULL, 'g', 291, NULL),
(21, 25, 'Keen''s mustard', 3, '50', '', '2016-12-05', '2016-12-05', NULL, NULL, 'g', 150, NULL),
(22, 24, 'Club House Smoked Paprika', 1, '545', '', '2016-12-05', '2016-12-05', NULL, NULL, 'g', 545, NULL),
(23, 24, 'McCormick Gourmet Smoked Paprika', 6, '46', '', '2016-12-05', '2016-12-05', NULL, NULL, 'g', 276, NULL),
(24, 21, 'Pilons de poulet', 3, '12', '', '2016-12-05', '2016-12-05', 100, 'g', 'Unité', 36, NULL),
(25, 20, 'Piments de Jamaïque President''s Choice', 15, '15', '', '2016-12-05', '2016-12-05', NULL, NULL, 'ml', 215, NULL),
(26, 19, 'Poivre de Cayenne Tabasco', 10, '100', '', '2016-12-05', '2016-12-05', NULL, NULL, 'ml', 1000, NULL),
(27, 18, 'Club House Organic Garlic Powder', 5, '10', '', '2016-12-05', '2016-12-05', 15, 'g', 'Unité', 50, NULL),
(28, 18, 'Splendor Garden Organic Garlic Powder', 4, '4', '', '2016-12-05', '2016-12-05', 454, 'g', 'Unité', 16, NULL),
(29, 17, 'Onion Powder President''s Choice', 2, '1', '', '2016-12-05', '2016-12-05', NULL, NULL, 'kg', 2, NULL),
(30, 27, 'Chung Jung One Sunchang GochuJang', 3, '345', '', '2016-12-05', '2016-12-05', NULL, NULL, 'ml', 1035, NULL),
(31, 16, 'Sel No Name', 15, '160', '', '2016-12-05', '2016-12-05', NULL, NULL, 'g', 2390, NULL),
(32, 32, 'Sucre RedPath', 1, '10', '', '2016-12-30', '2016-12-12', NULL, NULL, 'kg', 10, NULL),
(33, 31, 'Caisse de pommes vertes', 2, '16', '', '2016-12-28', '2016-12-12', 450, 'g', 'Unité', 32, NULL),
(34, 33, 'Boîte de Frosted Flakes', 1, '450', '', NULL, '2016-12-12', 1, 'g', 'g', 450, NULL),
(35, 29, 'Jus d''orange Tropicana', 1, '2500', '', '2016-12-29', '2016-12-12', NULL, NULL, 'ml', 2500, NULL),
(36, 34, 'Huile d''olive Terra Denyssa', 6, '750', '', NULL, '2016-12-12', NULL, NULL, 'ml', 4500, NULL),
(37, 30, 'Caisse d''oranges', 2, '12', '', '2016-12-31', '2016-12-12', 396, 'g', 'Unité', 24, NULL),
(38, 35, 'Boite de caramels sucrés', 1, '10', '', NULL, '2016-12-12', NULL, NULL, 'kg', 10, NULL);

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
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=9 ;

--
-- Contenu de la table `messages`
--

INSERT INTO `messages` (`id`, `titre`, `message`, `debut_affichage`, `fin_affichage`) VALUES
(6, 'Attention - Listériose', 'Santé Canada vient d''émettre une alerte concernant une possible contamination de la viande de poulet, avertir les étudiants de bien cuire la volaille.', '2016-12-11', '2016-12-27'),
(8, 'Remise des notes d''examen', 'SVP - Remettre les notes d''examen avant le 1 décembre, les élèves veulent recevoir leur notes avant les examens finaux pour avoir une bonne idée de leur situation.', '2016-12-01', '2016-12-27');

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
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=36 ;

--
-- Contenu de la table `produits`
--

INSERT INTO `produits` (`ID_Produit`, `Nom_Produit`, `Categorie`, `Duree_Vie`, `Taxable_Federal`, `Taxable_Provincial`, `Code_UCP`, `Perissable`, `Description`, `hidden`) VALUES
(15, 'Lait de beurre 0.25%', 4, NULL, 1, 1, NULL, 1, 'Lait de beurre 0.25% de matières grasses', 0),
(16, 'Sel', 10, NULL, 1, 1, NULL, 0, '', 0),
(17, 'Poudre d''oignons', 10, NULL, 1, 0, NULL, 1, 'Oignons en poudre', 0),
(18, 'Poudre d''ail', 10, NULL, 1, 0, NULL, 0, 'Ail en poudre', 0),
(19, 'Poivre de Cayenne', 10, NULL, 1, 0, NULL, 0, 'Poivre de Cayenne', 0),
(20, 'Piment de Jamaïque', 10, NULL, 1, 0, NULL, 1, 'Piments forts provenant de la Jamaïque', 0),
(21, 'Pilons de poulet', 3, NULL, 1, 0, NULL, 1, 'Jambe de poulet (Ne consommer que la viande)', 0),
(22, 'Cuisse de poulet', 3, NULL, 1, 0, NULL, 1, '', 0),
(23, 'Farine tout usage', 7, NULL, 1, 1, NULL, 0, 'Farine blanchie tout usage', 0),
(24, 'Paprika fumé doux', 10, NULL, 0, 1, NULL, 0, 'Paprika', 0),
(25, 'Moutarde en poudre', 10, NULL, 1, 1, NULL, 0, 'Moutarde concassée pour en faire de la poudre', 0),
(26, 'Mayonnaise', 5, NULL, 1, 1, NULL, 1, '', 0),
(27, 'Sambal Oelek', 10, NULL, 1, 1, NULL, 0, 'Épice', 0),
(28, 'Miel', 8, NULL, 1, 1, NULL, 0, 'Miel d''abeille', 0),
(29, 'Jus d''orange', 9, NULL, 1, 1, NULL, 1, 'Jus fait à base d''oranges', 0),
(30, 'Orange', 1, NULL, 1, 1, NULL, 1, 'Fruit de l''orangier à éplucher avant de consommer', 0),
(31, 'Pomme verte', 1, NULL, 1, 1, NULL, 1, 'Pomme de couleur verte', 0),
(32, 'Sucre', 8, NULL, 1, 1, NULL, 1, '', 0),
(33, 'Frosted Flakes', 7, NULL, 1, 1, NULL, 0, '', 0),
(34, 'Huile d''olive', 11, NULL, 1, 1, NULL, 0, 'Huile faite à partird''olives', 0),
(35, 'Caramel', 8, NULL, 1, 1, NULL, 0, '', 0);

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
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=12 ;

--
-- Contenu de la table `produits_fournisseurs`
--

INSERT INTO `produits_fournisseurs` (`id`, `ID_Produit`, `ID_Fournisseur`) VALUES
(4, 15, 1),
(5, 16, 1),
(6, 19, 1),
(7, 21, 1),
(8, 25, 2),
(9, 28, 2),
(10, 31, 2),
(11, 33, 2);

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
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=8 ;

--
-- Contenu de la table `recettes`
--

INSERT INTO `recettes` (`ID_Recette`, `Nom`, `Temps_Preparation`, `Temps_Cuisson`, `Nb_Portions`, `Taille_Portion`, `Unite_Mesure`, `Temperature`, `Temps_Refroidissement`, `Etapes`, `Image`, `Remarque`, `Allergene`, `Duree_Conservation`, `Categorie`, `congelable`) VALUES
(6, 'Poulet Frit', '30 minutes', '45 minutes', '8', '125', 'g', '325', '5 minutes', 'Marinade\n\nDans un bol, mélanger le lait de beurre, le sel et les épices. Ajouter le poulet et bien l’enrober. Couvrir et réfrigérer au moins 12 heures.\n\n\nPanure\n\nDans un grand bol, mélanger la farine, les épices et le sel.\nPréchauffer l’huile de la friteuse à 160 °C (325 °F). Tapisser une plaque de cuisson de papier absorbant.\nRetirer le poulet de la marinade sans trop l’assécher. Enrober le poulet dans le mélange de farine. Tremper une seconde fois dans la marinade et enrober à nouveau le poulet. Secouer pour retirer l’excédent. Réserver sur une plaque de cuisson. Frire quatre à cinq morceaux à la fois environ 15 minutes. Si vous utilisez un thermomètre, il doit indiquer 82 °C (180 °F) lorsque celui-ci est inséré au centre d’un morceau. Égoutter sur le papier absorbant. Poursuivre avec le reste du poulet.\nMayonnaise épicée\n\nEntre-temps, dans un bol, mélanger tous les ingrédients. Servir avec le poulet.', 'JLC6.JLC', 'Nécessite une friteuse et de l''huile de cuisson', 'Lactose\r\n\n\nGluten\r\n\n\n', '4 jours', 'Friture', 0),
(7, 'Pomme & Caramel', '15 minutes', '5 minutes', '12', '1', 'Unité', '375', '1h', 'Tremper la pomme dans le caramel\nServir\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\neat', 'JLC7.JLC', 'Danger - Diabète', 'Pomme\r\n\nCaramel', '1 semaine', 'Desserts', 0);

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

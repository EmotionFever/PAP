-- MySQL Administrator dump 1.4
--
-- ------------------------------------------------------
-- Server version	5.0.45-community-nt


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


--
-- Create schema ppap
--

CREATE DATABASE IF NOT EXISTS ppap;
USE ppap;

--
-- Definition of table `aux_cat`
--

DROP TABLE IF EXISTS `aux_cat`;
CREATE TABLE `aux_cat` (
  `codAC` int(11) NOT NULL auto_increment,
  `codC` int(11) default NULL,
  `codFl` int(11) default NULL,
  PRIMARY KEY  (`codAC`),
  KEY `codC` (`codC`),
  KEY `codFl` (`codFl`),
  CONSTRAINT `aux_cat_ibfk_1` FOREIGN KEY (`codC`) REFERENCES `categorias` (`codC`),
  CONSTRAINT `aux_cat_ibfk_2` FOREIGN KEY (`codFl`) REFERENCES `filmes` (`codFl`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `aux_cat`
--

/*!40000 ALTER TABLE `aux_cat` DISABLE KEYS */;
INSERT INTO `aux_cat` (`codAC`,`codC`,`codFl`) VALUES 
 (1,1,2),
 (2,2,2),
 (3,4,3),
 (4,4,4),
 (5,6,6),
 (6,7,6),
 (7,6,7),
 (8,7,7),
 (9,2,8),
 (10,3,8);
/*!40000 ALTER TABLE `aux_cat` ENABLE KEYS */;


--
-- Definition of table `aux_pai`
--

DROP TABLE IF EXISTS `aux_pai`;
CREATE TABLE `aux_pai` (
  `codAP` int(11) NOT NULL auto_increment,
  `codFl` int(11) default NULL,
  `codPs` int(11) default NULL,
  PRIMARY KEY  (`codAP`),
  KEY `codFl` (`codFl`),
  KEY `codPs` (`codPs`),
  CONSTRAINT `aux_pai_ibfk_1` FOREIGN KEY (`codFl`) REFERENCES `filmes` (`codFl`),
  CONSTRAINT `aux_pai_ibfk_2` FOREIGN KEY (`codPs`) REFERENCES `paises` (`codPs`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `aux_pai`
--

/*!40000 ALTER TABLE `aux_pai` DISABLE KEYS */;
INSERT INTO `aux_pai` (`codAP`,`codFl`,`codPs`) VALUES 
 (1,2,1),
 (2,3,1),
 (3,4,1),
 (4,6,1),
 (5,7,1),
 (6,8,2),
 (7,2,6),
 (8,2,4),
 (9,2,5);
/*!40000 ALTER TABLE `aux_pai` ENABLE KEYS */;


--
-- Definition of table `aux_vend`
--

DROP TABLE IF EXISTS `aux_vend`;
CREATE TABLE `aux_vend` (
  `codAV` int(11) NOT NULL auto_increment,
  `codP` int(11) default NULL,
  `codV` int(11) default NULL,
  PRIMARY KEY  (`codAV`),
  KEY `codP` (`codP`),
  KEY `codV` (`codV`),
  CONSTRAINT `aux_vend_ibfk_1` FOREIGN KEY (`codP`) REFERENCES `produtos` (`codP`),
  CONSTRAINT `aux_vend_ibfk_2` FOREIGN KEY (`codV`) REFERENCES `vendas` (`codV`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `aux_vend`
--

/*!40000 ALTER TABLE `aux_vend` DISABLE KEYS */;
/*!40000 ALTER TABLE `aux_vend` ENABLE KEYS */;


--
-- Definition of table `bilhetes`
--

DROP TABLE IF EXISTS `bilhetes`;
CREATE TABLE `bilhetes` (
  `codB` int(11) NOT NULL auto_increment,
  `codL` int(11) default NULL,
  `codV` int(11) default NULL,
  PRIMARY KEY  (`codB`),
  KEY `codL` (`codL`),
  KEY `codV` (`codV`),
  CONSTRAINT `bilhetes_ibfk_1` FOREIGN KEY (`codL`) REFERENCES `lugares` (`codL`),
  CONSTRAINT `bilhetes_ibfk_2` FOREIGN KEY (`codV`) REFERENCES `vendas` (`codV`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `bilhetes`
--

/*!40000 ALTER TABLE `bilhetes` DISABLE KEYS */;
/*!40000 ALTER TABLE `bilhetes` ENABLE KEYS */;


--
-- Definition of table `categorias`
--

DROP TABLE IF EXISTS `categorias`;
CREATE TABLE `categorias` (
  `codC` int(11) NOT NULL auto_increment,
  `nome` varchar(50) default NULL,
  PRIMARY KEY  (`codC`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `categorias`
--

/*!40000 ALTER TABLE `categorias` DISABLE KEYS */;
INSERT INTO `categorias` (`codC`,`nome`) VALUES 
 (1,'Ação'),
 (2,'Aventura'),
 (3,'Animação'),
 (4,'Comédia'),
 (5,'Clássico'),
 (6,'Documentário'),
 (7,'Drama'),
 (8,'Ficção'),
 (9,'Musical'),
 (10,'Romance'),
 (11,'Terror'),
 (12,'Suspense');
/*!40000 ALTER TABLE `categorias` ENABLE KEYS */;


--
-- Definition of table `classificacoes`
--

DROP TABLE IF EXISTS `classificacoes`;
CREATE TABLE `classificacoes` (
  `codCs` int(11) NOT NULL auto_increment,
  `nome` varchar(50) default NULL,
  PRIMARY KEY  (`codCs`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `classificacoes`
--

/*!40000 ALTER TABLE `classificacoes` DISABLE KEYS */;
INSERT INTO `classificacoes` (`codCs`,`nome`) VALUES 
 (1,'M/3'),
 (2,'M/7'),
 (3,'M/12'),
 (4,'M/16'),
 (5,'M/18');
/*!40000 ALTER TABLE `classificacoes` ENABLE KEYS */;


--
-- Definition of table `clientes`
--

DROP TABLE IF EXISTS `clientes`;
CREATE TABLE `clientes` (
  `codC` int(11) NOT NULL auto_increment,
  `nome` varchar(50) default NULL,
  `morada` varchar(100) default NULL,
  `NIF` varchar(9) default NULL,
  PRIMARY KEY  (`codC`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `clientes`
--

/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;


--
-- Definition of table `encargos`
--

DROP TABLE IF EXISTS `encargos`;
CREATE TABLE `encargos` (
  `codEnc` int(11) NOT NULL auto_increment,
  `nome` varchar(50) default NULL,
  `A_Fun` int(11) default NULL,
  `A_Enc` int(11) default NULL,
  `A_Uti` int(11) default NULL,
  `A_Ven` int(11) default NULL,
  `A_Cli` int(11) default NULL,
  `A_Bil` int(11) default NULL,
  `A_Pro` int(11) default NULL,
  `A_Hor` int(11) default NULL,
  PRIMARY KEY  (`codEnc`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `encargos`
--

/*!40000 ALTER TABLE `encargos` DISABLE KEYS */;
/*!40000 ALTER TABLE `encargos` ENABLE KEYS */;


--
-- Definition of table `filmes`
--

DROP TABLE IF EXISTS `filmes`;
CREATE TABLE `filmes` (
  `codFl` int(11) NOT NULL auto_increment,
  `nome` varchar(100) default NULL,
  `atores` varchar(200) default NULL,
  `realizador` varchar(50) default NULL,
  `ano` year(4) NOT NULL,
  `duracao` time default NULL,
  `codCs` int(11) default NULL,
  PRIMARY KEY  (`codFl`),
  KEY `codCs` (`codCs`),
  CONSTRAINT `filmes_ibfk_2` FOREIGN KEY (`codCs`) REFERENCES `classificacoes` (`codCs`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `filmes`
--

/*!40000 ALTER TABLE `filmes` DISABLE KEYS */;
INSERT INTO `filmes` (`codFl`,`nome`,`atores`,`realizador`,`ano`,`duracao`,`codCs`) VALUES 
 (2,'Assassin’s Creed','Michael Fassbender, Marion Cotillard, Jeremy Irons, Brendan Gleeson, Khalid Abdalla, Michael K. Williams','Justin Kurzel',2016,'01:55:00',3),
 (3,'O Pátio das Cantigas','Rui Unas, Miguel Guilherme, Anabela Moreira, César Mourão','Leonel Vieira',2015,'01:51:00',4),
 (4,'A Mãe é que Sabe','Maria João Abreu, Dalila Carmo, Manuel Cavaco, Bruno Cabrerizo, Margarida Carpinteiro','Nuno Rocha',2016,'01:28:00',3),
 (6,'Zeus','Sinde Filipe, Ivo Canelas, Catarina Luís, Paulo Pires','Paulo Filipe Monteiro',2016,'01:57:00',3),
 (7,'Cartas de Guerra','Miguel Nunes, Margarida Vila-Nova, Ricardo Pereira, João Pedro Vaz, Simão Cayatte','Ivo M. Ferreira',2016,'01:45:00',3),
 (8,'À Procura de Dory','Ellen DeGeneres, Albert Brooks, Ed O\'Neill','Andrew Stanton, Angus MacLane',2016,'01:37:00',1);
/*!40000 ALTER TABLE `filmes` ENABLE KEYS */;


--
-- Definition of table `funcionarios`
--

DROP TABLE IF EXISTS `funcionarios`;
CREATE TABLE `funcionarios` (
  `codF` int(11) NOT NULL auto_increment,
  `nome` varchar(100) default NULL,
  `idade` int(11) default NULL,
  `ordenado` double default NULL,
  `telemovel` varchar(9) default NULL,
  `morada` varchar(100) default NULL,
  `codEnc` int(11) default NULL,
  PRIMARY KEY  (`codF`),
  KEY `codEnc` (`codEnc`),
  CONSTRAINT `funcionarios_ibfk_1` FOREIGN KEY (`codEnc`) REFERENCES `encargos` (`codEnc`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `funcionarios`
--

/*!40000 ALTER TABLE `funcionarios` DISABLE KEYS */;
/*!40000 ALTER TABLE `funcionarios` ENABLE KEYS */;


--
-- Definition of table `generos`
--

DROP TABLE IF EXISTS `generos`;
CREATE TABLE `generos` (
  `codG` int(11) NOT NULL auto_increment,
  `nome` varchar(60) default NULL,
  PRIMARY KEY  (`codG`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `generos`
--

/*!40000 ALTER TABLE `generos` DISABLE KEYS */;
/*!40000 ALTER TABLE `generos` ENABLE KEYS */;


--
-- Definition of table `horarios`
--

DROP TABLE IF EXISTS `horarios`;
CREATE TABLE `horarios` (
  `codH` int(11) NOT NULL auto_increment,
  `hora` time default NULL,
  `datai` date default NULL,
  `dataf` date default NULL,
  `exibindo` tinyint(1) default NULL,
  `codS` int(11) default NULL,
  `codFl` int(11) default NULL,
  PRIMARY KEY  (`codH`),
  KEY `codS` (`codS`),
  KEY `codFl` (`codFl`),
  CONSTRAINT `horarios_ibfk_1` FOREIGN KEY (`codS`) REFERENCES `salas` (`codS`),
  CONSTRAINT `horarios_ibfk_2` FOREIGN KEY (`codFl`) REFERENCES `filmes` (`codFl`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `horarios`
--

/*!40000 ALTER TABLE `horarios` DISABLE KEYS */;
/*!40000 ALTER TABLE `horarios` ENABLE KEYS */;


--
-- Definition of table `lugares`
--

DROP TABLE IF EXISTS `lugares`;
CREATE TABLE `lugares` (
  `codL` int(11) NOT NULL auto_increment,
  `coluna` int(11) default NULL,
  `linha` varchar(1) default NULL,
  `codS` int(11) default NULL,
  PRIMARY KEY  (`codL`),
  KEY `codS` (`codS`),
  CONSTRAINT `lugares_ibfk_1` FOREIGN KEY (`codS`) REFERENCES `salas` (`codS`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `lugares`
--

/*!40000 ALTER TABLE `lugares` DISABLE KEYS */;
INSERT INTO `lugares` (`codL`,`coluna`,`linha`,`codS`) VALUES 
 (1,1,'A',NULL),
 (2,2,'A',NULL),
 (3,3,'A',NULL),
 (4,4,'A',NULL),
 (5,5,'A',NULL),
 (6,6,'A',NULL),
 (7,7,'A',NULL),
 (8,8,'A',NULL),
 (9,9,'A',NULL),
 (10,10,'A',NULL),
 (11,11,'A',NULL),
 (12,12,'A',NULL);
/*!40000 ALTER TABLE `lugares` ENABLE KEYS */;


--
-- Definition of table `paises`
--

DROP TABLE IF EXISTS `paises`;
CREATE TABLE `paises` (
  `codPs` int(11) NOT NULL auto_increment,
  `nome` varchar(50) default NULL,
  PRIMARY KEY  (`codPs`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `paises`
--

/*!40000 ALTER TABLE `paises` DISABLE KEYS */;
INSERT INTO `paises` (`codPs`,`nome`) VALUES 
 (1,'Portugal'),
 (2,'EUA'),
 (3,'Brasil'),
 (4,'França'),
 (5,'China'),
 (6,'Reino Unido');
/*!40000 ALTER TABLE `paises` ENABLE KEYS */;


--
-- Definition of table `produtos`
--

DROP TABLE IF EXISTS `produtos`;
CREATE TABLE `produtos` (
  `codP` int(11) NOT NULL auto_increment,
  `nome` varchar(100) default NULL,
  `codG` int(11) default NULL,
  PRIMARY KEY  (`codP`),
  KEY `codG` (`codG`),
  CONSTRAINT `produtos_ibfk_1` FOREIGN KEY (`codG`) REFERENCES `generos` (`codG`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `produtos`
--

/*!40000 ALTER TABLE `produtos` DISABLE KEYS */;
/*!40000 ALTER TABLE `produtos` ENABLE KEYS */;


--
-- Definition of table `salas`
--

DROP TABLE IF EXISTS `salas`;
CREATE TABLE `salas` (
  `codS` int(11) NOT NULL auto_increment,
  `codT` int(11) default NULL,
  PRIMARY KEY  (`codS`),
  KEY `codT` (`codT`),
  CONSTRAINT `salas_ibfk_1` FOREIGN KEY (`codT`) REFERENCES `tipos` (`codT`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `salas`
--

/*!40000 ALTER TABLE `salas` DISABLE KEYS */;
INSERT INTO `salas` (`codS`,`codT`) VALUES 
 (1,1),
 (4,1),
 (5,1),
 (2,2),
 (3,2);
/*!40000 ALTER TABLE `salas` ENABLE KEYS */;


--
-- Definition of table `tipos`
--

DROP TABLE IF EXISTS `tipos`;
CREATE TABLE `tipos` (
  `codT` int(11) NOT NULL auto_increment,
  `nome` varchar(50) default NULL,
  PRIMARY KEY  (`codT`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tipos`
--

/*!40000 ALTER TABLE `tipos` DISABLE KEYS */;
INSERT INTO `tipos` (`codT`,`nome`) VALUES 
 (1,'2D'),
 (2,'2D/3D');
/*!40000 ALTER TABLE `tipos` ENABLE KEYS */;


--
-- Definition of table `utilizadores`
--

DROP TABLE IF EXISTS `utilizadores`;
CREATE TABLE `utilizadores` (
  `codU` int(11) NOT NULL auto_increment,
  `nome` varchar(50) default NULL,
  `palavra_passe` varchar(40) default NULL,
  `codF` int(11) default NULL,
  PRIMARY KEY  (`codU`),
  KEY `codF` (`codF`),
  CONSTRAINT `utilizadores_ibfk_1` FOREIGN KEY (`codF`) REFERENCES `funcionarios` (`codF`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `utilizadores`
--

/*!40000 ALTER TABLE `utilizadores` DISABLE KEYS */;
/*!40000 ALTER TABLE `utilizadores` ENABLE KEYS */;


--
-- Definition of table `vendas`
--

DROP TABLE IF EXISTS `vendas`;
CREATE TABLE `vendas` (
  `codV` int(11) NOT NULL auto_increment,
  `datav` date default NULL,
  `codF` int(11) default NULL,
  `codC` int(11) default NULL,
  PRIMARY KEY  (`codV`),
  KEY `codF` (`codF`),
  KEY `codC` (`codC`),
  CONSTRAINT `vendas_ibfk_1` FOREIGN KEY (`codF`) REFERENCES `funcionarios` (`codF`),
  CONSTRAINT `vendas_ibfk_2` FOREIGN KEY (`codC`) REFERENCES `clientes` (`codC`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `vendas`
--

/*!40000 ALTER TABLE `vendas` DISABLE KEYS */;
/*!40000 ALTER TABLE `vendas` ENABLE KEYS */;




/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;

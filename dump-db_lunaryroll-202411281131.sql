-- MySQL dump 10.13  Distrib 8.0.19, for Win64 (x86_64)
--
-- Host: localhost    Database: db_lunaryroll
-- ------------------------------------------------------
-- Server version	5.5.5-10.4.32-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `tb_anime`
--

DROP TABLE IF EXISTS `tb_anime`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_anime` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(255) NOT NULL,
  `descricao` varchar(255) NOT NULL,
  `classificacao` int(11) DEFAULT NULL,
  `capa` varchar(255) NOT NULL,
  `episodio` varchar(255) NOT NULL,
  `temporada` varchar(255) NOT NULL,
  `legendado` tinyint(1) DEFAULT NULL,
  `dublado` tinyint(1) DEFAULT NULL,
  `avaliacao` decimal(10,0) DEFAULT NULL,
  `comentario` varchar(255) DEFAULT NULL,
  `titulo_original` varchar(255) NOT NULL,
  `generos` varchar(255) NOT NULL,
  `studio` varchar(255) NOT NULL,
  `data_lancamento` date NOT NULL,
  `status` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_anime`
--

LOCK TABLES `tb_anime` WRITE;
/*!40000 ALTER TABLE `tb_anime` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_anime` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_anime_episodio`
--

DROP TABLE IF EXISTS `tb_anime_episodio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_anime_episodio` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `anime_id` int(11) NOT NULL,
  `episodio_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `tb_anime_episodio_tb_anime_FK` (`anime_id`),
  KEY `tb_anime_episodio_tb_episodio_FK` (`episodio_id`),
  CONSTRAINT `tb_anime_episodio_tb_anime_FK` FOREIGN KEY (`anime_id`) REFERENCES `tb_anime` (`id`),
  CONSTRAINT `tb_anime_episodio_tb_episodio_FK` FOREIGN KEY (`episodio_id`) REFERENCES `tb_episodio` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_anime_episodio`
--

LOCK TABLES `tb_anime_episodio` WRITE;
/*!40000 ALTER TABLE `tb_anime_episodio` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_anime_episodio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_badges`
--

DROP TABLE IF EXISTS `tb_badges`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_badges` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) NOT NULL,
  `descricao` text DEFAULT NULL,
  `data_criacao` datetime NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_badges`
--

LOCK TABLES `tb_badges` WRITE;
/*!40000 ALTER TABLE `tb_badges` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_badges` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_episodio`
--

DROP TABLE IF EXISTS `tb_episodio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_episodio` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `titulo` varchar(255) NOT NULL,
  `num_ep` int(11) NOT NULL,
  `duracao` time NOT NULL,
  `data_lancamento` date NOT NULL,
  `video_url` varchar(255) NOT NULL,
  `thumbnail` varchar(255) NOT NULL,
  `descricao` varchar(255) NOT NULL,
  `like` int(11) DEFAULT NULL,
  `dislike` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_episodio`
--

LOCK TABLES `tb_episodio` WRITE;
/*!40000 ALTER TABLE `tb_episodio` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_episodio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_pessoas`
--

DROP TABLE IF EXISTS `tb_pessoas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_pessoas` (
  `nome` varchar(100) NOT NULL,
  `telefone` varchar(11) NOT NULL,
  `rua` varchar(50) DEFAULT NULL,
  `casa` int(11) DEFAULT NULL,
  `complemento` varchar(50) DEFAULT NULL,
  `cidade` varchar(100) NOT NULL,
  `cpf` varchar(11) NOT NULL,
  `data_nasc` date NOT NULL,
  `email` varchar(100) NOT NULL,
  `id` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_pessoas`
--

LOCK TABLES `tb_pessoas` WRITE;
/*!40000 ALTER TABLE `tb_pessoas` DISABLE KEYS */;
INSERT INTO `tb_pessoas` VALUES ('CEO Dantes','1998765432','rua da pamonha',666,NULL,'PamonhaLandia','12345678900','2000-01-01','pamonha@gmail.com',1),('CEO Fraz','1990987654','rua dos bobos',57,NULL,'Americana','09875563200','1999-06-04','emailbacana@gmail.com',2),('Sergiao','1935127834','rua do sergio',9,'fazendeiro','Sergiolandia','42456573400','1984-11-27','sergio@gmail.com',3);
/*!40000 ALTER TABLE `tb_pessoas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_usuario`
--

DROP TABLE IF EXISTS `tb_usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_usuario` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome_usuario` varchar(50) NOT NULL,
  `nome_exibido` varchar(50) NOT NULL,
  `email` varchar(255) NOT NULL,
  `senha` varchar(60) NOT NULL,
  `url_banner` varchar(255) DEFAULT NULL,
  `url_perfil` varchar(255) DEFAULT NULL,
  `data_criacao` datetime NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_usuario`
--

LOCK TABLES `tb_usuario` WRITE;
/*!40000 ALTER TABLE `tb_usuario` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_usuario_badges`
--

DROP TABLE IF EXISTS `tb_usuario_badges`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_usuario_badges` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `usuario_id` int(11) NOT NULL,
  `badge_id` int(11) NOT NULL,
  `atribuido_em` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  PRIMARY KEY (`id`),
  KEY `tb_usuario_badges_tb_usuario_FK` (`usuario_id`),
  KEY `tb_usuario_badges_tb_badges_FK` (`badge_id`),
  CONSTRAINT `tb_usuario_badges_tb_badges_FK` FOREIGN KEY (`badge_id`) REFERENCES `tb_badges` (`id`),
  CONSTRAINT `tb_usuario_badges_tb_usuario_FK` FOREIGN KEY (`usuario_id`) REFERENCES `tb_usuario` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_usuario_badges`
--

LOCK TABLES `tb_usuario_badges` WRITE;
/*!40000 ALTER TABLE `tb_usuario_badges` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_usuario_badges` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_usuarios`
--

DROP TABLE IF EXISTS `tb_usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_usuarios` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `login` varchar(100) NOT NULL,
  `senha` varchar(100) DEFAULT NULL,
  `pessoa_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `tb_usuarios_unique` (`pessoa_id`),
  CONSTRAINT `tb_usuarios_tb_pessoas_FK` FOREIGN KEY (`pessoa_id`) REFERENCES `tb_pessoas` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_usuarios`
--

LOCK TABLES `tb_usuarios` WRITE;
/*!40000 ALTER TABLE `tb_usuarios` DISABLE KEYS */;
INSERT INTO `tb_usuarios` VALUES (1,'sergio','çemnha312',3),(2,'Downzin_Pamonha','... . -. .... .-',1),(3,'Balduco :)','senha',2);
/*!40000 ALTER TABLE `tb_usuarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'db_lunaryroll'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-11-28 11:31:21

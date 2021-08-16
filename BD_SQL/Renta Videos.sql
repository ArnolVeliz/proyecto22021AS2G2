-- MySQL dump 10.13  Distrib 8.0.23, for Win64 (x86_64)
--
-- Host: localhost    Database: renta_videos
-- ------------------------------------------------------
-- Server version	8.0.23

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `bitacora`
--

DROP TABLE IF EXISTS `bitacora`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bitacora` (
  `id_bitacora` int NOT NULL AUTO_INCREMENT,
  `usuario` varchar(100) NOT NULL,
  `descripcion` varchar(400) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `tabla` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_bitacora`),
  KEY `fkusuariobitacora` (`usuario`),
  CONSTRAINT `fkusuariobitacora` FOREIGN KEY (`usuario`) REFERENCES `usuarios` (`usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bitacora`
--

LOCK TABLES `bitacora` WRITE;
/*!40000 ALTER TABLE `bitacora` DISABLE KEYS */;
/*!40000 ALTER TABLE `bitacora` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `categoria_pel`
--

DROP TABLE IF EXISTS `categoria_pel`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categoria_pel` (
  `idcat` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(100) DEFAULT NULL,
  `Descripcion` varchar(200) DEFAULT NULL,
  `usuario` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`idcat`),
  KEY `fkusuarioregcategoria` (`usuario`),
  CONSTRAINT `fkusuarioregcategoria` FOREIGN KEY (`usuario`) REFERENCES `usuarios` (`usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categoria_pel`
--

LOCK TABLES `categoria_pel` WRITE;
/*!40000 ALTER TABLE `categoria_pel` DISABLE KEYS */;
/*!40000 ALTER TABLE `categoria_pel` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clientes`
--

DROP TABLE IF EXISTS `clientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clientes` (
  `id_cliente` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(150) DEFAULT NULL,
  `apellido` varchar(150) DEFAULT NULL,
  `fecha_nac` date NOT NULL,
  `DPI` int NOT NULL,
  `telefono` int NOT NULL,
  `correo` varchar(100) NOT NULL,
  `contacto_nombre` varchar(150) DEFAULT NULL,
  `contacto_telefono` int DEFAULT NULL,
  `id_membresia` int DEFAULT NULL,
  `mora` float DEFAULT NULL,
  `fecha_reg` date DEFAULT NULL,
  `usuario` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id_cliente`),
  KEY `fktipomembresia` (`id_membresia`),
  KEY `fkusuarioregcliente` (`usuario`),
  CONSTRAINT `fktipomembresia` FOREIGN KEY (`id_membresia`) REFERENCES `membresias` (`id_membresia`),
  CONSTRAINT `fkusuarioregcliente` FOREIGN KEY (`usuario`) REFERENCES `usuarios` (`usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clientes`
--

LOCK TABLES `clientes` WRITE;
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `direccion_personas`
--

DROP TABLE IF EXISTS `direccion_personas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `direccion_personas` (
  `id_direccion` int NOT NULL AUTO_INCREMENT,
  `id_cliente` int NOT NULL,
  `departamento` varchar(50) DEFAULT NULL,
  `municipio` varchar(150) DEFAULT NULL,
  `aldea` varchar(50) DEFAULT NULL,
  `zona` int DEFAULT NULL,
  `complemento` varchar(200) DEFAULT NULL,
  `usuario` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id_direccion`),
  KEY `fkdireccionclientes` (`id_cliente`),
  KEY `fkusuarioregdireccion` (`usuario`),
  CONSTRAINT `fkdireccionclientes` FOREIGN KEY (`id_cliente`) REFERENCES `clientes` (`id_cliente`),
  CONSTRAINT `fkusuarioregdireccion` FOREIGN KEY (`usuario`) REFERENCES `usuarios` (`usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `direccion_personas`
--

LOCK TABLES `direccion_personas` WRITE;
/*!40000 ALTER TABLE `direccion_personas` DISABLE KEYS */;
/*!40000 ALTER TABLE `direccion_personas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `facturacion`
--

DROP TABLE IF EXISTS `facturacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `facturacion` (
  `id_factura` int NOT NULL AUTO_INCREMENT,
  `no_factura` int NOT NULL,
  `nit_empresa` int NOT NULL,
  `no_Serie` varchar(50) DEFAULT NULL,
  `fecha_emision` date DEFAULT NULL,
  `contribuyente` varchar(100) DEFAULT NULL,
  `nombre_cliente` varchar(200) DEFAULT NULL,
  `direccion` varchar(200) DEFAULT NULL,
  `nit_cliente` int NOT NULL,
  `id_registro` int NOT NULL,
  `id_met` int NOT NULL,
  `usuario` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id_factura`),
  KEY `fktipopago` (`id_met`),
  KEY `fkidalquiler` (`id_registro`),
  KEY `fkusuarioregfactura` (`usuario`),
  CONSTRAINT `fkidalquiler` FOREIGN KEY (`id_registro`) REFERENCES `registro_alquiler` (`id_registro`),
  CONSTRAINT `fktipopago` FOREIGN KEY (`id_met`) REFERENCES `met_pago` (`id_met`),
  CONSTRAINT `fkusuarioregfactura` FOREIGN KEY (`usuario`) REFERENCES `usuarios` (`usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `facturacion`
--

LOCK TABLES `facturacion` WRITE;
/*!40000 ALTER TABLE `facturacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `facturacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `membresias`
--

DROP TABLE IF EXISTS `membresias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `membresias` (
  `id_membresia` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) DEFAULT NULL,
  `descripcion` varchar(150) DEFAULT NULL,
  `descuento` float DEFAULT NULL,
  `num_pel_desc` int DEFAULT NULL,
  `usuario` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id_membresia`),
  KEY `fkusuarioregmembresia` (`usuario`),
  CONSTRAINT `fkusuarioregmembresia` FOREIGN KEY (`usuario`) REFERENCES `usuarios` (`usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `membresias`
--

LOCK TABLES `membresias` WRITE;
/*!40000 ALTER TABLE `membresias` DISABLE KEYS */;
/*!40000 ALTER TABLE `membresias` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `met_pago`
--

DROP TABLE IF EXISTS `met_pago`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `met_pago` (
  `id_met` int NOT NULL AUTO_INCREMENT,
  `nombre_met` varchar(50) DEFAULT NULL,
  `descripcicon` varchar(50) DEFAULT NULL,
  `usuario` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id_met`),
  KEY `fkusuarioregmetpago` (`usuario`),
  CONSTRAINT `fkusuarioregmetpago` FOREIGN KEY (`usuario`) REFERENCES `usuarios` (`usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `met_pago`
--

LOCK TABLES `met_pago` WRITE;
/*!40000 ALTER TABLE `met_pago` DISABLE KEYS */;
/*!40000 ALTER TABLE `met_pago` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `registro_alquiler`
--

DROP TABLE IF EXISTS `registro_alquiler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `registro_alquiler` (
  `id_registro` int NOT NULL AUTO_INCREMENT,
  `id_video` int NOT NULL,
  `id_cliente` int NOT NULL,
  `fecha_reg` date NOT NULL,
  `monto` float DEFAULT NULL,
  `mora` float DEFAULT NULL,
  `id_usuario` int NOT NULL,
  `desc_mem` float DEFAULT NULL,
  `desc_adi` float DEFAULT NULL,
  `subtotal` float DEFAULT NULL,
  `total` float DEFAULT NULL,
  `fecha_dev` date DEFAULT NULL,
  `dias_atraso` int DEFAULT NULL,
  `usuario` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id_registro`),
  KEY `fkvideo` (`id_video`),
  KEY `fkcliente` (`id_cliente`),
  KEY `fkusuarioregistroalquiler` (`usuario`),
  CONSTRAINT `fkcliente` FOREIGN KEY (`id_cliente`) REFERENCES `clientes` (`id_cliente`),
  CONSTRAINT `fkusuarioregistroalquiler` FOREIGN KEY (`usuario`) REFERENCES `usuarios` (`usuario`),
  CONSTRAINT `fkvideo` FOREIGN KEY (`id_video`) REFERENCES `videos` (`id_video`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `registro_alquiler`
--

LOCK TABLES `registro_alquiler` WRITE;
/*!40000 ALTER TABLE `registro_alquiler` DISABLE KEYS */;
/*!40000 ALTER TABLE `registro_alquiler` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `registro_pagos`
--

DROP TABLE IF EXISTS `registro_pagos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `registro_pagos` (
  `id_reg` int NOT NULL AUTO_INCREMENT,
  `id_registro` int NOT NULL,
  `id_met` int NOT NULL,
  `total_pag` float NOT NULL,
  `Abono` float DEFAULT NULL,
  `vuelto` float DEFAULT NULL,
  `num_tarjeta` varchar(50) DEFAULT NULL,
  `fechaexp` date DEFAULT NULL,
  `titular` varchar(100) DEFAULT NULL,
  `efectivo` float DEFAULT NULL,
  `id_factura` int NOT NULL,
  `usuario` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id_reg`),
  KEY `fkmetodopago` (`id_met`),
  KEY `fkidpagoalquiler` (`id_registro`),
  KEY `fkidfacturacion` (`id_factura`),
  KEY `fkusuarioregpago` (`usuario`),
  CONSTRAINT `fkidfacturacion` FOREIGN KEY (`id_factura`) REFERENCES `facturacion` (`id_factura`),
  CONSTRAINT `fkidpagoalquiler` FOREIGN KEY (`id_registro`) REFERENCES `registro_alquiler` (`id_registro`),
  CONSTRAINT `fkmetodopago` FOREIGN KEY (`id_met`) REFERENCES `met_pago` (`id_met`),
  CONSTRAINT `fkusuarioregpago` FOREIGN KEY (`usuario`) REFERENCES `usuarios` (`usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `registro_pagos`
--

LOCK TABLES `registro_pagos` WRITE;
/*!40000 ALTER TABLE `registro_pagos` DISABLE KEYS */;
/*!40000 ALTER TABLE `registro_pagos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarios` (
  `usuario` varchar(100) NOT NULL,
  `nombre` varchar(150) DEFAULT NULL,
  `apellido` varchar(150) DEFAULT NULL,
  `puesto` varchar(100) DEFAULT NULL,
  `DPI` int NOT NULL,
  `Genero` varchar(15) DEFAULT NULL,
  `Fecha_nac` date NOT NULL,
  `Fecha_cont` date DEFAULT NULL,
  `telefono` int DEFAULT NULL,
  `correo` varchar(100) DEFAULT NULL,
  `estado_civ` varchar(30) DEFAULT NULL,
  `contraseña` varchar(100) NOT NULL,
  PRIMARY KEY (`usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `videos`
--

DROP TABLE IF EXISTS `videos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `videos` (
  `id_video` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) DEFAULT NULL,
  `idcat` int NOT NULL,
  `fecha_estreno` date DEFAULT NULL,
  `duracion` float DEFAULT NULL,
  `cantidad` int DEFAULT NULL,
  `precio` float DEFAULT NULL,
  `stock` int DEFAULT NULL,
  `usuario` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id_video`),
  KEY `fktipocategoria` (`idcat`),
  KEY `fkusuarioregvideo` (`usuario`),
  CONSTRAINT `fktipocategoria` FOREIGN KEY (`idcat`) REFERENCES `categoria_pel` (`idcat`),
  CONSTRAINT `fkusuarioregvideo` FOREIGN KEY (`usuario`) REFERENCES `usuarios` (`usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `videos`
--

LOCK TABLES `videos` WRITE;
/*!40000 ALTER TABLE `videos` DISABLE KEYS */;
/*!40000 ALTER TABLE `videos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'renta_videos'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-08-12 22:59:51

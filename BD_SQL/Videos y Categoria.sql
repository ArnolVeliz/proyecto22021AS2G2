use prototipo;

INSERT INTO `prototipo`.`categoria_pel` (`idcat`, `Nombre`, `Descripcion`) VALUES ('301', 'Acción', 'Cintas explosivas, con actores populares y con tramas lineales, llenas de persecuciones');
INSERT INTO `prototipo`.`categoria_pel` (`idcat`, `Nombre`, `Descripcion`) VALUES ('302', 'Drama', 'Presenta historias serias, en las que prevalece el dialogo y la acción orientadas a generar tensión y presentar pasiones conflictivas más que generar humor. ');
INSERT INTO `prototipo`.`categoria_pel` (`idcat`, `Nombre`, `Descripcion`) VALUES ('303', 'Romance', 'Se centra en la relación de dos personajes en el amor.');
INSERT INTO `prototipo`.`categoria_pel` (`idcat`, `Nombre`, `Descripcion`) VALUES ('304', 'Terror', 'Se caracteriza por su voluntad de provocar en el espectador sensaciones de pavor, terror, miedo,  horror, incomodidad o preocupación. ');

INSERT INTO `prototipo`.`videos` (`id_video`, `nombre`, `categoria`, `fecha_estreno`, `duracion`, `cantidad`, `precio`, `stock`) VALUES ('401', 'Rapidos y Furiosos 1', '301', '2001-07-22', '1.47', '25', '31.00', '25');
INSERT INTO `prototipo`.`videos` (`id_video`, `nombre`, `categoria`, `fecha_estreno`, `duracion`, `cantidad`, `precio`, `stock`) VALUES ('402', 'Votos de Amor', '303', '2012-02-06', '1.44', '16', '20.87', '16');
INSERT INTO `prototipo`.`videos` (`id_video`, `nombre`, `categoria`, `fecha_estreno`, `duracion`, `cantidad`, `precio`, `stock`) VALUES ('403', 'La monja', '304', '2018-09-05', '1.36', '40', '20.00', '40');
INSERT INTO `prototipo`.`videos` (`id_video`, `nombre`, `categoria`, `fecha_estreno`, `duracion`, `cantidad`, `precio`, `stock`) VALUES ('404', 'Chucky 1', '304', '1988-11-09', '1.28', '30', '25.50', '30');
INSERT INTO `prototipo`.`videos` (`id_video`, `nombre`, `categoria`, `fecha_estreno`, `duracion`, `cantidad`, `precio`, `stock`) VALUES ('405', 'Chucky 2', '304', '1990-11-09', '1.24', '30', '25.00', '30');
INSERT INTO `prototipo`.`videos` (`id_video`, `nombre`, `categoria`, `fecha_estreno`, `duracion`, `cantidad`, `precio`, `stock`) VALUES ('406', 'Emma', '302', '2020-02-22', '2.12', '10', '64.00', '10');
INSERT INTO `prototipo`.`videos` (`id_video`, `nombre`, `categoria`, `fecha_estreno`, `duracion`, `cantidad`, `precio`, `stock`) VALUES ('407', 'Los Ilusionistas', '302', '2013-05-11', '2.5', '25', '46.80', '25');
INSERT INTO `prototipo`.`videos` (`id_video`, `nombre`, `categoria`, `fecha_estreno`, `duracion`, `cantidad`, `precio`, `stock`) VALUES ('408', 'Rapidos y Furiosos 5', '301', '2011-04-15', '2.10', '50', '65.25', '50');
INSERT INTO `prototipo`.`videos` (`id_video`, `nombre`, `categoria`, `fecha_estreno`, `duracion`, `cantidad`, `precio`, `stock`) VALUES ('409', 'Venom', '301', '2018-07-03', '2.20', '40', '49.00', '40');
INSERT INTO `prototipo`.`videos` (`id_video`, `nombre`, `categoria`, `fecha_estreno`, `duracion`, `cantidad`, `precio`, `stock`) VALUES ('410', 'After', '302', '2019-04-08', '1.45', '50', '24.00', '50');

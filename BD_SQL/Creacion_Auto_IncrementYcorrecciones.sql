-- Antes que nada corroborar que la tabla registro_alquiler no tenga un ultimo campo llamado usuario, si fuera asi eliminenlo.

-- Eliminar llaves foraneas para agregar el auto increment
ALTER TABLE `prototipo`.`registro_alquiler` DROP FOREIGN KEY `fkusuarioregistra`;
ALTER TABLE `prototipo`.`registro_pagos` DROP FOREIGN KEY `fkmetodopago`;
ALTER TABLE `prototipo`.`registro_pagos` DROP FOREIGN KEY `fkid_alquiler`;
ALTER TABLE `prototipo`.`facturacion` DROP FOREIGN KEY `fktipopago`;
ALTER TABLE `prototipo`.`facturacion` DROP FOREIGN KEY `fkidalquiler`;
ALTER TABLE `prototipo`.`direccion_personas` DROP FOREIGN KEY `fkdireccionclientes`;
ALTER TABLE `prototipo`.`registro_alquiler` DROP FOREIGN KEY `fkcliente`;
ALTER TABLE `prototipo`.`registro_alquiler` DROP FOREIGN KEY `fkvideo`;
ALTER TABLE `prototipo`.`clientes` DROP FOREIGN KEY `fktipomembresia`;
ALTER TABLE `prototipo`.`usuarios` DROP FOREIGN KEY `fktipousuario`;
ALTER TABLE `prototipo`.`videos` DROP FOREIGN KEY `fktipocategoria`;
ALTER TABLE `prototipo`.`registro_pagos` DROP FOREIGN KEY `fkidfacturacion`;

-- ELiminar tabla que genere conflico y volver a crearla
drop table registro_alquiler;
create table registro_alquiler (
id_registro INTEGER primary key not null auto_increment,
id_vid INTEGER not null,
id_cli INTEGER not null,
fecha_reg date not null,
monto float,
mora float,
id_usuario INTEGER not null,
desc_mem float,
desc_adi float,
subtotal float,
total float,
fecha_dev date,
dias_atraso INTEGER
);

-- Hacer insert en registro alquiler 
insert into registro_alquiler(
   id_vid, id_cli, fecha_reg, monto, mora, id_usuario, desc_mem, desc_adi, subtotal, total, fecha_dev, dias_atraso,usuario
   )
  values
    ('402','202',sysdate(),'20.87','0','11','0','0','20.87','20.87','2021-08-09','0',user()),
    ('403','203',sysdate(),'20','0','12','0','0','20','20','2021-08-09','0',user()),
    ('404','204',sysdate(),'25.5','0','13','0','0','25.5','25.5','2021-08-09','0',user()),
    ('405','205',sysdate(),'25','0','14','0','0','25','25','2021-08-09','0',user()),
    ('406','206',sysdate(),'64','0','15','0','0','64','64','2021-08-09','0',user()),
    ('407','207',sysdate(),'46.8','0','16','0','0','46.8','46.8','2021-08-09','0',user()),
    ('408','208',sysdate(),'65.25','0','17','0','0','65.25','65.25','2021-08-09','0',user()),
    ('409','209',sysdate(),'49','0','18','0','0','49','49','2021-08-09','0',user()),
    ('410','210',sysdate(),'24','0','19','0','0','24','24','2021-08-09','0',user())
    ;

-- Eliminar datos que ya no cuadran en tablas facturacion y registro_pagos
delete  from facturacion where id_alquiler=0;
delete from registro_pagos where id_alquiler=0;

-- Realizar modificaciones al resto de tablas
ALTER TABLE categoria_pel MODIFY COLUMN idcat INTEGER NOT NULL AUTO_INCREMENT;
ALTER TABLE clientes MODIFY COLUMN id_cliente INTEGER NOT NULL AUTO_INCREMENT ;
ALTER TABLE direccion_personas MODIFY COLUMN id_direccion INTEGER NOT NULL AUTO_INCREMENT ;
ALTER TABLE facturacion MODIFY COLUMN id_factura INTEGER NOT NULL AUTO_INCREMENT ;
ALTER TABLE membresias MODIFY COLUMN  id_membresia INTEGER NOT NULL AUTO_INCREMENT ;
ALTER TABLE met_pago MODIFY COLUMN id_met INTEGER NOT NULL AUTO_INCREMENT ;
ALTER TABLE registro_pagos MODIFY COLUMN id_reg INTEGER NOT NULL AUTO_INCREMENT ;
ALTER TABLE tipo_usuario MODIFY COLUMN id_tipo INTEGER NOT NULL AUTO_INCREMENT ;
ALTER TABLE usuarios MODIFY COLUMN id_usuario INTEGER NOT NULL AUTO_INCREMENT ;
ALTER TABLE videos MODIFY COLUMN id_video INTEGER NOT NULL AUTO_INCREMENT ;

-- Añadir campo restante a registro_pago para nueva llave foranea
 alter table registro_pagos add column factura integer;
 
 -- Volver a declarar llaves foraneas
alter table videos add constraint fktipocategoria foreign key (categoria) references categoria_pel (idcat);
alter table usuarios add constraint fktipousuario foreign key (tipo_usuario) references tipo_usuario (id_tipo);
alter table clientes add constraint fktipomembresia foreign key (membresia) references membresias (id_membresia);
alter table registro_alquiler add constraint fkvideo foreign key (id_vid) references videos (id_video);
alter table registro_alquiler add constraint fkcliente foreign key (id_cli) references clientes (id_cliente);
alter table direccion_personas add constraint fkdireccionclientes foreign key (id_cli) references clientes (id_cliente);
alter table facturacion add constraint fktipopago foreign key (met_pago) references met_pago (id_met);
alter table registro_pagos add constraint fkmetodopago foreign key (id_met) references met_pago (id_met);
alter table registro_alquiler add constraint fkusuarioregistra foreign key (id_usuario) references usuarios (id_usuario);
alter table facturacion add constraint fkidalquiler foreign key (id_alquiler) references registro_alquiler(id_registro);
alter table registro_pagos add constraint fkidpagoalquiler foreign key (id_alquiler) references registro_alquiler (id_registro);
alter table registro_pagos add constraint fkidfacturacion foreign key (factura) references facturacion (id_factura);
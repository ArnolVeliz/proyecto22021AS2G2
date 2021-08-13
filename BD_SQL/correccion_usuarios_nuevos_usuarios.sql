use prototipo;

-- Creacion de tabla bitacora 
create table bitacora (
  id_bitacora integer primary key not null auto_increment,
  usuario integer not null,
  descripcion varchar(400),
  fecha date
);  
alter table bitacora add llave integer;
alter table bitacora add tabla varchar(50);

-- Eliminacion de llaves foraneas relacionadas a usuario y tipo usuario
ALTER TABLE `prototipo`.`registro_alquiler` DROP FOREIGN KEY `fkusuarioregistra`;
ALTER TABLE `prototipo`.`usuarios` DROP FOREIGN KEY `fktipousuario`;

-- Eliminacion de tablas de usuario que ya no se utilizaran
drop table usuarios;
drop table tipo_usuario;

-- Eliminar idusuario y usuario en todas las tablas que exista
-- registro_alquiler
ALTER TABLE `prototipo`.`registro_alquiler` drop column id_usuario  ;
ALTER TABLE `prototipo`.`registro_alquiler` drop column usuario  ;
-- Volver a añadir usuario en formato correcto
ALTER TABLE `prototipo`.`registro_alquiler` add `usuario` VARCHAR(100) NOT NULL ;

-- Agregar en clientes el usuario que lo registro
ALTER TABLE `prototipo`.`clientes` add `usuario` VARCHAR(100) NOT NULL ;

-- Creacion de los usuarios con sus respectivos permisos
-- Usuarios administrativos con todos los permisos
create user ADMAPEREZM identified by 'cjpermol21';
grant all privileges on prototipo.* to ADMAPEREZM;
drop user ADMAPEREZM;

create user ADMFBIGGSM identified by 'Aadmbiggmor';
grant all privileges on prototipo.* to ADMFBIGGSM;
drop user ADMFBIGGSM;

-- Usuarios de Cajero con permisos de lectura, modificar e insertar
create user CJSGUERRAG identified by 'cjguerguer';
GRANT select, update, insert on prototipo.* to CJSGUERRAG;
drop user CJSGUERRAG;

create user CJAVELIZP identified by 'cjvelpoo';
GRANT select, update, insert on prototipo.* to CJAVELIZP;
drop user CJAVELIZP;

update registro_pagos set factura='2'
where id_alquiler =1;
update registro_pagos set factura='3'
where id_alquiler =2;
update registro_pagos set factura='4'
where id_alquiler =3;
update registro_pagos set factura='5'
where id_alquiler =4;
update registro_pagos set factura='6'
where id_alquiler =5;
update registro_pagos set factura='7'
where id_alquiler =6;
update registro_pagos set factura='8'
where id_alquiler =7;
update registro_pagos set factura='9'
where id_alquiler =8;
update registro_pagos set factura='10'
where id_alquiler =9;



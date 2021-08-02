create database prototipo;
use prototipo;

create table videos (
id_video INTEGER primary key not null,
nombre varchar(100),
categoria INTEGER not null,
fecha_estreno date,
duracion float,
cantidad integer,
precio float,
stock integer
);

create table categoria_pel (
idcat integer primary key not null,
Nombre varchar(100),
Descripcion varchar(200)
);

create table usuarios (
id_usuario integer primary key not null,
nombre varchar(150),
apellido varchar(150),
puesto varchar(100),
DPI integer not null,
Genero varchar(15),
Fecha_nac date not null,
Fecha_cont date,
telefono integer,
correo varchar(100),
estado_civ varchar(30),
tipo_usuario integer not null,
usuario_ses varchar(100) not null,
contraseña varchar(100) not null
);

create table clientes (
id_cliente integer primary key not null,
nombre varchar(150),
apellido varchar(150),
fecha_nac date not null,
DPI integer not null,
telefono integer not null,
correo varchar(100) not null,
contacto_nombre varchar(150),
contacto_telefono integer,
membresia integer,
mora float,
fecha_reg date
);

create table membresias (
id_membresia integer primary key not null,
nombre varchar(50),
descripcion varchar(150),
descuento float,
num_pel_desc integer
);

create table registro_alquiler (
id_registro integer primary key not null,
id_vid integer not null,
id_cli integer not null,
fecha_reg date not null,
monto float,
mora float,
id_usuario integer not null,
desc_mem float,
desc_adi float,
subtotal float,
total float,
fecha_dev date,
dias_atraso integer
);

create table tipo_usuario (
id_tipo integer primary key not null,
nombre varchar(100),
Descripcion varchar(300)
);

create table direccion_personas(
id_direccion integer primary key not null,
id_cli integer not null,
departamento varchar(50),
municipio varchar(150),
aldea varchar(50),
zona integer,
complemento varchar(200)
);

create table facturacion (
id_factura integer primary key not null,
no_factura integer not null,
nit_empresa integer not null,
no_Serie varchar(50),
fecha_emision date,
contribuyente varchar(100),
nombre_cliente varchar(200),
direccion varchar(200),
nit_cliente integer not null,
id_alquiler integer not null,
met_pago integer not null
);

create table met_pago(
id_met integer primary key not null,
nombre_met varchar(50),
descripcicon varchar(50)
);

create table registro_pagos(
id_reg integer primary key not null,
id_alquiler integer not null,
id_met integer not null,
total_pag float not null,
Abono float,
vuelto float,
num_tarjeta varchar(50),
fechaexp date,
titular varchar(100),
efectivo float
);
alter table registro_alquiler add usuario integer;
alter table videos add constraint fktipocategoria foreign key (categoria) references categoria_pel (idcat);
alter table usuarios add constraint fktipousuario foreign key (tipo_usuario) references tipo_usuario (id_tipo);
alter table clientes add constraint fktipomembresia foreign key (membresia) references membresias (id_membresia);
alter table registro_alquiler add constraint fkvideo foreign key (id_vid) references videos (id_video);
alter table registro_alquiler add constraint fkcliente foreign key (id_cli) references clientes (id_cliente);
alter table direccion_personas add constraint fkdireccionclientes foreign key (id_cli) references clientes (id_cliente);
alter table facturacion add constraint fkidalquiler foreign key (id_alquiler) references registro_alquiler(id_registro);
alter table facturacion add constraint fktipopago foreign key (met_pago) references met_pago (id_met);
alter table registro_pagos add constraint fkid_alquiler foreign key (id_alquiler) references registro_alquiler (id_registro);
alter table registro_pagos add constraint fkmetodopago foreign key (id_met) references met_pago (id_met);
alter table registro_alquiler add constraint fkusuarioregistra foreign key (id_usuario) references usuarios (id_usuario);
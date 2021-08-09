use prototipo;

#*****************************************************  TABLA MET_PAGO  ***************************************************************************************************************************************************************************
insert into met_pago values (501, 'Efectivo', 'Este metodo se aplica en tiendas fisicas'), 
(502, 'Tarjeta credito o debito', 'Este metodo se aplica online y en tiendas fisicas'),
(503, 'Paypal', 'Este metodo se aplica online y en tiendas fisicas');

#*****************************************************  TABLA TIPO_USUARIO **************************************************************************************************************************************************************
insert into tipo_usuario values (301, 'Administraion', 'Es el encargado de organizar, dirir y controlar los recuros de la empresa.'),
(302, 'Trabajador', 'Son los que conforman el grupo laboral de la empresa.'),
(303, 'Contabilidad', 'Lleva el control de las finanzas.'),
(304, 'Propietario/Accionista', 'Aportan capital a la compañia.' ),
(305, 'Proveedor', 'Proporciona bienes o servicios a la empresa.');

#*****************************************************  TABLA USUARIOS **************************************************************************************************************************************************************
ALTER TABLE usuarios CHANGE COLUMN `DPI` `DPI` VARCHAR(13) NOT NULL;

insert into usuarios values (0010, 'Carlos', 'Rojas', 'Cajero de Boleteria', 2755486510101, 'Masculino', '1990-10-04', '2019-02-09', 45872185, 'c.rojas2@gmail.com', 'Soltero', 302, 'Rojas.C', 'boletos2021'),
(0011, 'Erika', 'Martinez', 'Cajero de Beleteria', 2577467840101, 'Femenino', '1996-07-21', '2021-04-16', 42511499, 'ericamartinez1@gmail.com', 'Soltera', 302, 'Martinez.E', 'boletos2021'),
(0012, 'Douglas', 'Lopez', 'Cajero de Beleteria', 2166289600101, 'masculino', '1997-01-10', '2020-09-13', 36108565, 'duguilopez@gmail.com', 'Casado', 302, 'Lopez.D', 'boletos2021'),
(0013, 'Julio', 'Castillo', 'Administrador_DB', 2788259510101, 'Masculino', '1980-12-20', '2016-02-11', 29882860, 'jcastillo240@hotmail.com', 'Casado', 301, 'Castillo.J', 'BD.Administracion2021'),
(0014, 'Dayana', 'Herrera', 'Contadora', 2355184610101, 'Femenino', '1994-08-27', '2019-12-10', 23554703, 'dayanherrera@gmail.com', 'Soltera', 303, 'Herrera.D', 'Contabilid@d2021'),
(0015, 'Mario', 'Gomez', 'Cajero de tienda/dulceria', 3354578511201, 'Masculino', '2000-05-02', '2021-06-11', 50212398, 'gomez.mario02@gmail.com', 'Soltero', 302, 'Gomez.M', 'tiend@2021'),
(0016, 'Alberto', 'De la Cruz', 'Accionista', 364584610101, 'Maculino', '1970-11-30','2018-03-23', 30000083,'delacruz.alberto@hotmail.com', 'Casado', 304, 'Delacruz.A', 'amazing.video2021'),
(0017, 'Isabella', 'Molina', 'Cajero de tienda/dulceria', 248875640101, 'Femenino', '1970-02-18','2021-01-11', 45415691, 'isa.molina1@gmail.com', 'Soltera', 302, 'Molina.I', 'tiend@2021'),
(0018, 'Alvin', 'Alvarez', 'Proyectista', 547895610101, 'Masculino', '1984-01-15', '2018-12-03', 89625414, 'alvinalvarez7@gmail.com', 'Casado', 302, 'Alvarez.A', 'Proyect2021'),
(0019, 'Paola', 'Paredes', 'Gerente', 415587530101, 'Femenino', '1991-12-12', '2019-11-01', 76362347, 'paoparedes12@gmail.com', 'Casada', 301, 'Paredes.P', 'amazing.video2021');

#*****************************************************  TABLA DIRECCION_PERSONAS ****************************************************************************************************************************************************
insert into direccion_personas values (20010, 201, 'Guatemala','Guatemala', 'Ciudad Nueva', 3, '13-46 14 calle. 4 Avenida'),
(20011, 202, 'Guatemala', 'Villa Nueva', 'Barcenas', NULL, '3er. callejon 3 Avenida'),
(20012, 203, 'Guatemala', 'Guatemala', 'Lavarreda', 18, '1ra. Avenida A, Lote 11'),
(20013, 204, 'Guatemala', 'Mixco', 'Nueva Monserrat', 3, '3-10, 11 calle'),
(20014, 205, 'Guatemala', 'Palencia', 'Jardines de Palencia', null, '6ta. Avenida'),
(20015, 206, 'Guatemala', 'Guatemala', 'Juana de Arco', 18, '2-14 Manzana 2'),
(20016, 207, 'Guatemala', 'Mixco', 'Bosques de San Nicolas', 4, 'Lote 101'),
(20017, 208, 'Guatemala', 'Canalitos', null, 24, 'Lote 8, Manzana 5'),
(20018, 209, 'Guatemala', 'Los Ocotes', 'Santa Lucia', 25, 'Sector 4, Lote 120'),
(20019, 210, 'Guatemala', 'Guatemala', 'El Zapote', 2, '3-28 3ra. Avenida');






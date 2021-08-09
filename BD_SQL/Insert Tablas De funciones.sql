use prototipo;
-- contiene datos 
-- select * from categoria_pel;
-- select * from clientes;
-- select * from direccion_personas;
-- select * from membresias;
-- select * from met_pago;
-- select * from tipo_usuario;
-- select * from usuarios;
-- select * from videos;

select * from registro_pagos;  -- tercera en llenar
select * from registro_alquiler; -- primera en llenar
Select * from facturacion; -- segunda en llenar

insert into registro_alquiler
  values
    ('1','402','202',sysdate(),'20.87','0','11','0','0','20.87','20.87','2021-08-09','0','11'),
    ('2','403','203',sysdate(),'20','0','12','0','0','20','20','2021-08-09','0','12'),
    ('3','404','204',sysdate(),'25.5','0','13','0','0','25.5','25.5','2021-08-09','0','13'),
    ('4','405','205',sysdate(),'25','0','14','0','0','25','25','2021-08-09','0','14'),
    ('5','406','206',sysdate(),'64','0','15','0','0','64','64','2021-08-09','0','15'),
    ('6','407','207',sysdate(),'46.8','0','16','0','0','46.8','46.8','2021-08-09','0','16'),
    ('7','408','208',sysdate(),'65.25','0','17','0','0','65.25','65.25','2021-08-09','0','17'),
    ('8','409','209',sysdate(),'49','0','18','0','0','49','49','2021-08-09','0','18'),
    ('9','410','210',sysdate(),'24','0','19','0','0','24','24','2021-08-09','0','19')
    ;
ALTER TABLE `prototipo`.`facturacion` CHANGE COLUMN `nit_empresa` `nit_empresa` VARCHAR(18) NOT NULL ;
ALTER TABLE `prototipo`.`facturacion` CHANGE COLUMN `nit_cliente` `nit_cliente` VARCHAR(18) NOT NULL ;
ALTER TABLE prototipo.facturacion ADD COLUMN total integer; 


insert into facturacion values ('1','100','488003-7','987985',sysdate(),'Amazin Videos+','Juan Perez','Ciudad','574689-1','0','501','31');
insert into facturacion
  values
    ('2','101','488003-7','987985',sysdate(),'Amazin Videos+','Juana Martinez','Ciudad','5744569-2','1','502','20.87'),
    ('3','102','488003-7','987985',sysdate(),'Amazin Videos+','Ignacio Lopez','Ciudad','776849-3','2','501','20'),
    ('4','103','488003-7','987985',sysdate(),'Amazin Videos+','Mateo Bonilla','Ciudad','128493-2','3','502','25.5'),
    ('5','104','488003-7','987985',sysdate(),'Amazin Videos+','Pedro Alcala','Ciudad','474649-4','4','501','25'),
    ('6','105','488003-7','987985',sysdate(),'Amazin Videos+','Mario Flores','Ciudad','556559-5','5','502','64'),
    ('7','106','488003-7','987985',sysdate(),'Amazin Videos+','Fernando Castillo','Ciudad','674669-6','6','501','46.8'),
    ('8','107','488003-7','987985',sysdate(),'Amazin Videos+','Erwin Morales','Ciudad','574787-7','7','502','65.25'),
    ('9','108','488003-7','987985',sysdate(),'Amazin Videos+','Marco Gonzales','Ciudad','878688-8','8','501','49'),
    ('10','109','488003-7','987985',sysdate(),'Amazin Videos+','Lisandro Gutierrez','Ciudad','579699-9','9','502','24')
    ;

insert into registro_pagos values ('1','0','501','31','35','4.00',null,null,null,'35');
insert into registro_pagos 
  values 
    ('2','1','502','21','21','0','xxxx-xxxx-xxxx-7878','2024-12-01','Marco Zambrano','0'),
    ('3','2','501','20','25','5.00',null,null,null,'25'),
    ('4','3','502','26','26','0','xxxx-xxxx-xxxx-6457','2024-10-01','Astrid Quintanilla','0'),
    ('5','4','501','25','25','0',null,null,null,'25'),
    ('6','5','502','64','64','0','xxxx-xxxx-xxxx-3241','2024-08-01','Ignacio Lopez','0'),
    ('7','6','501','47','100','53.00',null,null,null,'100'),
    ('8','7','502','65','65','0','xxxx-xxxx-xxxx-8976','2024-06-01','Ibrahim Perez','0'),
    ('9','8','501','49','60','11.00',null,null,null,'60'),
    ('10','9','502','24','24','0','xxxx-xxxx-xxxx-9487','2024-02-01','Andrea Martinez','0')
    ;


-- Reporte para ver Registro de clientes #3PDF--
 select nombre, apellido, dpi, telefono, correo, membresia, fecha_reg
 from clientes
 order by nombre;
 
-- Reporte para videos de determinado tipo #4PDF
-- variable para ingresar determinado tipo
set @varcategoria=301;
select 
p.idcat codvideo, p.nombre genero, v.nombre pelicula, v.id_video clave_video,
r.fecha_reg fecha_alquiler, r.monto monto, r.total total, concat(c.nombre, ' ', c.apellido) cliente
from categoria_pel p
JOIN videos v
on v.categoria = p.idcat 
JOIN registro_alquiler r
on r.id_vid = v.id_video
JOIN clientes c
on r.id_cli = c.id_cliente
where idcat=301
;

-- Reporte para ver ganancias por semana Reporte #1 Semana
/*select no_factura Factura, fecha_emision fecha, nombre_cliente Persona, total  -- ,sum(total) Ganancias_Semanales
from (select ,sum(total) Ganancias_Semanales from facturacion) as fac
; */

-- Reporte para videos rentados en determinado dia Reporte #5 y 7 PDF
-- variable para ingresar determinada fecha
set @varfecha='2021-08-09';
select 
p.nombre genero, v.nombre pelicula, v.id_video,
r.fecha_reg fecha_alquiler, r.monto monto, r.total total, concat(c.nombre, ' ', c.apellido) cliente
from categoria_pel p
JOIN videos v
on v.categoria = p.idcat 
JOIN registro_alquiler r
on r.id_vid = v.id_video
JOIN clientes c
on r.id_cli = c.id_cliente
where r.fecha_reg=@varfecha
;

-- Reporte para videos rentados por determinados clientes Reporte #6 PDF
-- variable para ingresar determinado codigo de cliente
set @varcliente='202';
select 
p.nombre genero, v.nombre pelicula, v.id_video,
r.fecha_reg fecha_alquiler, r.monto monto, r.total total, concat(c.nombre, ' ', c.apellido) cliente
from categoria_pel p
JOIN videos v
on v.categoria = p.idcat 
JOIN registro_alquiler r
on r.id_vid = v.id_video
JOIN clientes c
on r.id_cli = c.id_cliente
where c.id_cliente = @varcliente
;

-- Videos rentados en la ultima visita de un cliente Reporte #8 PDF
-- Reporte para videos rentados por determinados clientes
-- variable para ingresar determinado codigo de cliente
set @varcliente='210';
select 
p.nombre genero, v.nombre pelicula, v.id_video,
r.fecha_reg fecha_ultimo_alquiler, r.monto monto, r.total total, concat(c.nombre, ' ', c.apellido) cliente
from categoria_pel p
JOIN videos v
on v.categoria = p.idcat 
JOIN registro_alquiler r
on r.id_vid = v.id_video
JOIN clientes c
on r.id_cli = c.id_cliente
where
r.id_registro =  (select max(id_registro) from registro_alquiler ra
					where ra.id_cli = c.id_cliente)
and
c.id_cliente = @varcliente
;

-- Historial de pagos de los clientes Reporte #9 PDF
select
concat(c.nombre,' ', c.apellido) cliente, f.total Monto, f.fecha_emision Fecha, f.nombre_cliente Emitido_a, 
f.direccion Direccion, f.nit_cliente Nit, f.no_factura Num_Factura, m.nombre_met Metodo_Pago,r.id_registro No_Alquiler
FROM clientes c 
JOIN registro_alquiler r 
on c.id_cliente = r.id_cli
JOIN facturacion f
on r.id_registro = f.id_alquiler
JOIN registro_pagos rp
on rp.factura = f.id_factura
JOIN met_pago m
on rp.id_met = m.id_met
WHERE r.id_cli = '207'
;

-- Datos para Factura Reporte #10
select 
f.no_factura No_Factura, f.nit_empresa Nit_Empresa, f.no_Serie No_Serie, f.Fecha_emision Fecha,
f.contribuyente Empresa, f.nombre_cliente Nombre, f.direccion Direccion, f.nit_cliente Nit_Cliente,
f.total Total, m.nombre_met Metodo_Pago, v.nombre Producto
from videos v
JOIN registro_alquiler r
on r.id_vid = v.id_video
Join facturacion f
on f.id_alquiler = r.id_registro
JOIN met_pago m
on f.met_pago = m.id_met
WHERE r.id_registro ='1'
;
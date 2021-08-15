using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.Odbc;
using System.Text;
using System.Threading.Tasks;
using CapaModelo;

namespace CapaControlador
{
   public class clsControlador
    {
        clsSentencias sn = new clsSentencias();
        public OdbcDataReader consultar(string tabla)
        {
            return sn.consulta(tabla);
        }
        public OdbcDataReader consultarlogin( string user, string pass)
        {
            return sn.consultalogin(user,pass);
        }
        public OdbcDataReader insertar_bitacora(string[] dato)
        {
            return sn.insertar_bitacora(dato);
        }
        public OdbcDataReader insertar_categoria_pel(string[] dato)
        {
            return sn.insertar_categoria_pel(dato);
        }
        public OdbcDataReader insertar_clientes(string[] dato)
        {
            return sn.insertar_clientes(dato);
        }
        public OdbcDataReader insertar_usuario(string[] dato)
        {
            return sn.insertar_usuario(dato);
        }
        public OdbcDataReader insertar_direccion_personas(string[] dato)
        {
            return sn.insertar_direccion_personas(dato);
        }
        public OdbcDataReader insertar_facturacion(string[] dato)
        {
            return sn.insertar_facturacion(dato);
        }
        public OdbcDataReader insertar_membresias(string[] dato)
        {
            return sn.insertar_membresias(dato);
        }
        public OdbcDataReader insertar_met_pago(string[] dato)
        {
            return sn.insertar_met_pago(dato);
        }
        public OdbcDataReader insertar_registro_alquiler(string[] dato)
        {
            return sn.insertar_registro_alquiler(dato);
        }
        public OdbcDataReader insertar_registro_pagos(string[] dato)
        {
            return sn.insertar_registro_pagos(dato);
        }
        public OdbcDataReader insertar_videos(string[] dato)
        {
            return sn.insertar_videos(dato);
        }
        public OdbcDataReader modificar_bitacora(string[] dato)
        {
            return sn.modificar_bitacora(dato);
        }
        public OdbcDataReader modificar_categoria_pel(string[] dato)
        {
            return sn.modificar_categoria_pel(dato);
        }
        public OdbcDataReader modificar_clientes(string[] dato)
        {
            return sn.modificar_clientes(dato);
        }
        public OdbcDataReader modificar_direccion_personas(string[] dato)
        {
            return sn.modificar_direccion_personas(dato);
        }
        public OdbcDataReader modificar_facturacion(string[] dato)
        {
            return sn.modificar_facturacion(dato);
        }
        public OdbcDataReader modificar_membresias(string[] dato)
        {
            return sn.modificar_membresias(dato);
        }
        public OdbcDataReader modificar_met_pago(string[] dato)
        {
            return sn.modificar_met_pago(dato);
        }
        public OdbcDataReader modificar_registro_alquiler(string[] dato)
        {
            return sn.modificar_registro_alquiler(dato);
        }
        public OdbcDataReader modificar_registro_pagos(string[] dato)
        {
            return sn.insertar_registro_pagos(dato);
        }
        public OdbcDataReader modificar_videos(string[] dato)
        {
            return sn.modificar_videos(dato);
        }
    }
}

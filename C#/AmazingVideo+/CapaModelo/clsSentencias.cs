using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CapaModelo
{
    public class clsSentencias
    {
        clsConexion cn = new clsConexion(); //crear objeto
        OdbcCommand com; //variable para querys


        public OdbcDataReader consulta(string tabla)
        {
            try
            {
                cn.conexion();
                string consulta = "SELECT * FROM " + tabla + ";";
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        public OdbcDataReader consultalogin(string user, string pass)
        {
            try
            {
                cn.conexion();
                string consulta = "SELECT * FROM  usuarios WHERE (nombre=@user and contraseña=@pass)";
                com = new OdbcCommand(consulta, cn.conexion());
                com.Parameters.AddWithValue("@user", user);
                com.Parameters.AddWithValue("@pass", pass);
                com.CommandType = CommandType.Text;
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;



            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //SENTENCIAS DE INSERCION
        public OdbcDataReader insertar_bitacora(string[] datos) //funcion para insertar en db
        {
            try
            {
                cn.conexion();
                string consulta = "INSERT INTO bitacora Values ('" + datos[0] + "','" + datos[1] + "','" + datos[2] + "','" + datos[3] + "','" + datos[4] + "');"; 
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err) {
                Console.WriteLine(err.Message);
                return null;
            }
        }
		
public OdbcDataReader insertar_categoria_pel(string[] datos) //funcion para insertar en db
        {
            try
            {
                cn.conexion();
                string consulta = "INSERT INTO categoria_pel Values ('" + datos[0] + "','" + datos[1] + "','" + datos[2] + "','" + datos[3] +  "');";
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err) {
                Console.WriteLine(err.Message);
                return null;
            }
        }
		public OdbcDataReader insertar_clientes(string[] datos) //funcion para insertar en db
        {
            try
            {
                cn.conexion();
                string consulta = "INSERT INTO clientes Values ('" + datos[0] + "','" + datos[1] + "','" + datos[2] + "','" + datos[3] + "','" + datos[4] + "','" + datos[5] +  "','" + datos[6] +  "','" + datos[7] +  "','" + datos[8] +  "','" + datos[9] +  "','" + datos[10] +  "','" + datos[11] +  "','" + datos[12] +"');"; 
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err) {
                Console.WriteLine(err.Message);
                return null;
            }
        }
		public OdbcDataReader insertar_direccion_personas(string[] datos) //funcion para insertar en db
        {
            try
            {
                cn.conexion();
                string consulta = "INSERT INTO direccion_personas Values ('" + datos[0] + "','" + datos[1] + "','" + datos[2] + "','" + datos[3] + "','" + datos[4] + "','" + datos[5] + "','" + datos[6] + "','" + datos[7] + "');"; 
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err) {
                Console.WriteLine(err.Message);
                return null;
            }
        }
		public OdbcDataReader insertar_facturacion(string[] datos) //funcion para insertar en db
        {
            try
            {
                cn.conexion();
                string consulta = "INSERT INTO facturacion Values ('" + datos[0] + "','" + datos[1] + "','" + datos[2] + "','" + datos[3] + "','" + datos[4] + "','" + datos[5] + "','" + datos[6] + "','" + datos[7] + "','" + datos[8] + "','" + datos[9] + "','" + datos[10] + "','" + datos[11] + "');"; 
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err) {
                Console.WriteLine(err.Message);
                return null;
            }
        }
		public OdbcDataReader insertar_membresias(string[] datos) //funcion para insertar en db
        {
            try
            {
                cn.conexion();
                string consulta = "INSERT INTO membresias Values ('" + datos[0] + "','" + datos[1] + "','" + datos[2] + "','" + datos[3] + "','" + datos[4] + "','" + datos[5] + "');"; 
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err) {
                Console.WriteLine(err.Message);
                return null;
            }
        }
		
		public OdbcDataReader insertar_met_pago(string[] datos) //funcion para insertar en db
        {
            try
            {
                cn.conexion();
                string consulta = "INSERT INTO met_pago Values ('" + datos[0] + "','" + datos[1] + "','" + datos[2] + "','" + datos[3] + "');"; 
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err) {
                Console.WriteLine(err.Message);
                return null;
            }
        }
		public OdbcDataReader insertar_registro_alquiler(string[] datos) //funcion para insertar en db
        {
            try
            {
                cn.conexion();
                string consulta = "INSERT INTO registro_alquiler Values ('" + datos[0] + "','" + datos[1] + "','" + datos[2] + "','" + datos[3] + "','" + datos[4] + "','" + datos[5] + "','" + datos[6] +  "','" + datos[7] +  "','" + datos[8] +  "','" + datos[9] +  "','" + datos[10] +  "','" + datos[11] +  "','" + datos[12] + "','" + datos[13] + "');"; 
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err) {
                Console.WriteLine(err.Message);
                return null;
            }
        }
		public OdbcDataReader insertar_registro_pagos(string[] datos) //funcion para insertar en db
        {
            try
            {
                cn.conexion();
                string consulta = "INSERT INTO registro_pagos Values ('" + datos[0] + "','" + datos[1] + "','" + datos[2] + "','" + datos[3] + "','" + datos[4] + "','" + datos[5] + "','" + datos[6] + "','" + datos[7] + "','" + datos[8] + "','" + datos[9] + "','" + datos[10] + "','" + datos[11] + "');"; 
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err) {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        public OdbcDataReader insertar_usuario(string[] datos) //funcion para insertar en db
        {
            try
            {
                cn.conexion();
                string consulta = "INSERT INTO Usuarios Values ('" + datos[0] + "','" + datos[1] + "','" + datos[2] + "','" + datos[3] + "','" + datos[4] + "','" + datos[5] + "','" + datos[6] + "','" + datos[7] + "','" + datos[8] + "','" + datos[9] + "','" + datos[10] + "','" + datos[11] + "');";
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        public OdbcDataReader insertar_videos(string[] datos) //funcion para insertar en db
        {
            try
            {
                cn.conexion();
                string consulta = "INSERT INTO videos Values ('" + datos[0] + "','" + datos[1] + "','" + datos[2] + "','" + datos[3] + "','" + datos[4] + "','" + datos[5] + "','" + datos[6] + "','" + datos[7] + "','" + datos[8] + "');"; 
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err) {
                Console.WriteLine(err.Message);
                return null;
            }
        }
		//SENTENCIAS DE MODIFICACION
 public OdbcDataReader modificar_bitacora(string[] datos) //funcion para insertar en db
        {
            try
            {
                cn.conexion();
                string consulta = "UPDATE bitacora SET usuario = '"+datos[1]+"', descripcion= '"+datos[2]+ "', fecha = '" + datos[3] +  "', tabla = '" + datos[4] + "'WHERE id_bitacora='" + datos[0]+"';"; // modificar por id
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
		  public OdbcDataReader modificar_categoria_pel(string[] datos) //funcion para modificar en db
        {
            try
            {
                cn.conexion();
                string consulta = "UPDATE categoria_pel SET nombre = '" + datos[1] + "', descripcion = '" + datos[2] + "', usuario = '" + datos[3] + "'  WHERE idcat='" + datos[0] + "';"; // modificar por id
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
		
        public OdbcDataReader modificar_clientes(string[] datos) //funcion para modificar en db
        {
            try
            {
                cn.conexion();
                string consulta = "UPDATE clientes SET nombre = '" + datos[1] + "', apellido = '" + datos[2] + "', fecha_nac = '" + datos[3] + "', DPI = '" + datos[4] + "', telefono = '" + datos[5] + "', correo = '" + datos[6] + "', contacto_nombre = '" + datos[7] + "', contacto_telefono = '" + datos[8] + "', id_membresia = '" + datos[9] + "', mora = '" + datos[10] + "', fecha_reg = '" + datos[11] + "', usuario = '" + datos[12] +  "'  WHERE id_cliente='" + datos[0] + "';"; // modificar por id
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
		public OdbcDataReader modificar_direccion_personas(string[] datos) //funcion para modificar en db
        {
            try
            {
                cn.conexion();
                string consulta = "UPDATE direccion_personas SET id_cliente = '" + datos[1]+"', departamento= '"+datos[2]+ "', municipio = '" + datos[3] + "' , aldea = '" + datos[4] + "', zona = '" + datos[5] + "', complemento = '" + datos[6] + "', usuario = '" + datos[7] + "'WHERE id_direccion='" + datos[0]+"';"; // modificar por id
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
		public OdbcDataReader modificar_facturacion(string[] datos) //funcion para modificar en db
        {
            try
            {
                cn.conexion();
                string consulta = "UPDATE facturacion SET no_factura = '"+datos[1]+"', nit_empresa= '"+datos[2]+ "', no_Serie = '" + datos[3] + "' , fecha_emision = '" + datos[4] + "', contribuyente = '" + datos[5] + "', nombre_cliente = '" + datos[6] + "', direccion = '" + datos[7] + "', nit_cliente = '" + datos[8] + "', id_registro = '" + datos[9] + "', id_met = '" + datos[10] + "', usuario = '" + datos[11] + "'WHERE id_factura='" + datos[0]+"';"; // modificar por id
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
		public OdbcDataReader modificar_membresias(string[] datos) //funcion para modificar en db
        {
            try
            {
                cn.conexion();
                string consulta = "UPDATE membresias SET nombre = '"+datos[1]+"', descripcion = '"+datos[2]+ "', descuento = '" + datos[3] + "' , num_pel_desc = '" + datos[4] + "' , usuario = '" + datos[5] + "'WHERE id_membresia='" + datos[0]+"';"; // modificar por id
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
		public OdbcDataReader modificar_met_pago(string[] datos) //funcion para modificar en db
        {
            try
            {
                cn.conexion();
                string consulta = "UPDATE met_pago SET nombre_met = '"+datos[1]+ "', descripcicon = '"+datos[2]+ "', usuario = '" + datos[3] + "'WHERE id_met='" + datos[0]+"';"; // modificar por id
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
		  public OdbcDataReader modificar_registro_alquiler(string[] datos) //funcion para modificar en db
        {
            try
            {
                cn.conexion();
                string consulta = "UPDATE registro_alquiler SET id_video = '" + datos[1] + "', id_cliente = '" + datos[2] + "', fecha_reg = '" + datos[3] + "', monto = '" + datos[4] + "', mora = '" + datos[5] + "', desc_mem = '" + datos[6] + "', desc_adi = '" + datos[7] + "', subtotal = '" + datos[8] + "', total = '" + datos[9] + "', fecha_dev = '" + datos[10] + "', dias_atraso = '" + datos[11] + "', usuario = '" + datos[12] +  "'  WHERE id_registro='" + datos[0] + "';"; // modificar por id
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
		 public OdbcDataReader modificar_registro_pagos(string[] datos) //funcion para modificar en db
        {
            try
            {
                cn.conexion();
                string consulta = "UPDATE registro_pagos SET id_registro = '" + datos[1] + "', id_met = '" + datos[2] + "', total_pag = '" + datos[3] + "', Abono = '" + datos[4] + "', vuelto = '" + datos[5] + "', num_tarjeta = '" + datos[6] + "', fechaexp = '" + datos[7] + "', titular = '" + datos[8] + "', efectivo = '" + datos[9] + "', id_factura = '" + datos[10] + "', usuario = '" + datos[11] + "'  WHERE id_reg='" + datos[0] + "';"; // modificar por id
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
		public OdbcDataReader modificar_videos(string[] datos) //funcion para modificar en db
        {
            try
            {
                cn.conexion();
                string consulta = "UPDATE videos SET nombre = '"+datos[1]+ "', idcat = '" + datos[2]+ "', fecha_estreno = '" + datos[3] + "' , duracion = '" + datos[4] + "', cantidad = '" + datos[5] + "', precio = '" + datos[6] + "', stock = '" + datos[7] + "', usuario = '" + datos[8] + "'WHERE id_video='" + datos[0]+"';"; // modificar por id
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
		//SENTENCIAS DE ELIMINACION
        // public OdbcDataReader eliminar_concepto(string[] datos) //funcion para modificar en db
        // {
            // try
            // {
                // cn.conexion();
                // string consulta = "UPDATE concepto SET  estatus_concepto = '"+ 0 + "'  WHERE codigo_concepto='" + datos[0] + "';"; // modificar por id
                // com = new OdbcCommand(consulta, cn.conexion());
                // OdbcDataReader respuesta = com.ExecuteReader();
                // return respuesta;
            // }
            // catch (Exception err)
            // {
                // Console.WriteLine(err.Message);
                // return null;
            // }
        // }
        // public OdbcDataReader eliminar_empleado(string[] datos) //funcion para modificar en db
        // {
            // try
            // {
                // cn.conexion();
                // string consulta = "UPDATE empleado SET nombre_empleado = '" + datos[1] + "', codigo_puesto = '" + datos[2] + "', codigo_departamento = '" + datos[3] + "' , sueldo_empleado = '" + datos[4] + "', estatus_empleado = '" + 0 + "'WHERE codigo_empleado='" + datos[0] + "';"; // modificar por id
                // com = new OdbcCommand(consulta, cn.conexion());
                // OdbcDataReader respuesta = com.ExecuteReader();
                // return respuesta;
            // }
            // catch (Exception err)
            // {
                // Console.WriteLine(err.Message);
                // return null;
            // }
        // }
       
    }
}

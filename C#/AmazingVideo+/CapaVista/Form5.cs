using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;
using System.Data.Odbc;

namespace CapaVista
{
    public partial class Form5 : Form
    {
        clsControlador logi = new clsControlador();
        public Form5()
        {
            InitializeComponent();
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario = new Form2();
            formulario.Show();
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTN_agregar_REGISTROALQUILER_Click(object sender, EventArgs e)
        {
            string[] valores = { TXT_id_RegistroAlquiler.Text, TXT_IDvideo_RegistroAlquiler.Text, TXT_idCliente_RegistroAlquiler.Text, TXT_Fecha_RegistroAlquiler.Text, TXT_monto_RegistroAlquiler.Text, TXT_mora_RegistroAlquiler.Text, TXT_idUsuario_MembresiaREGISTROALQUILER.Text, TXT_DescuentoMembresia_RegistroAlquiler.Text, TXT_total_RegistroAlquiler.Text, TXT_DescuentoAdicional_RegistroAlquiler.Text, TXT_subtotal_RegistroAlquiler.Text, TXT_FechaDevolucion_RegistroAlquiler.Text, TXT_DiasAtraso_RegistroAlquiler.Text, TXT_usuario_RegistroAlquiler.Text }; //valores a ingresar
            if (logi.insertar_registro_alquiler(valores) == null)
            {
                MessageBox.Show("Error al guardar");
            }
            else
            {
                MessageBox.Show("Datos agregados a la base de datos", "Ingreso de datos");
                TXT_id_RegistroAlquiler.Enabled = false;
                TXT_IDvideo_RegistroAlquiler.Enabled = false;
                TXT_idCliente_RegistroAlquiler.Enabled = false;
                TXT_Fecha_RegistroAlquiler.Enabled = false;
                TXT_monto_RegistroAlquiler.Enabled = false;
                TXT_mora_RegistroAlquiler.Enabled = false;
                TXT_idUsuario_MembresiaREGISTROALQUILER.Enabled = false;
                TXT_DescuentoMembresia_RegistroAlquiler.Enabled = false;
                TXT_total_RegistroAlquiler.Enabled = false;
                TXT_DescuentoAdicional_RegistroAlquiler.Enabled = false;
                TXT_subtotal_RegistroAlquiler.Enabled = false;
                TXT_FechaDevolucion_RegistroAlquiler.Enabled = false;
                TXT_DiasAtraso_RegistroAlquiler.Enabled = false;
                TXT_usuario_RegistroAlquiler.Enabled = false;

                TXT_id_RegistroAlquiler.Text = "";
                TXT_IDvideo_RegistroAlquiler.Text = "";
                TXT_idCliente_RegistroAlquiler.Text = "";
                TXT_Fecha_RegistroAlquiler.Text = "";
                TXT_monto_RegistroAlquiler.Text = "";
                TXT_mora_RegistroAlquiler.Text = "";
                TXT_idUsuario_MembresiaREGISTROALQUILER.Text = "";
                TXT_DescuentoMembresia_RegistroAlquiler.Text = "";
                TXT_total_RegistroAlquiler.Text = "";
                TXT_DescuentoAdicional_RegistroAlquiler.Text = "";
                TXT_subtotal_RegistroAlquiler.Text = "";
                TXT_FechaDevolucion_RegistroAlquiler.Text = "";
                TXT_DiasAtraso_RegistroAlquiler.Text = "";
                TXT_usuario_RegistroAlquiler.Text = "";


            }
        }

        private void BTN_modificar_REGISTROALQUILER_Click(object sender, EventArgs e)
        {
            string[] valores = { TXT_id_RegistroAlquiler.Text, TXT_IDvideo_RegistroAlquiler.Text, TXT_idCliente_RegistroAlquiler.Text, TXT_Fecha_RegistroAlquiler.Text, TXT_monto_RegistroAlquiler.Text, TXT_mora_RegistroAlquiler.Text, TXT_idUsuario_MembresiaREGISTROALQUILER.Text, TXT_DescuentoMembresia_RegistroAlquiler.Text, TXT_total_RegistroAlquiler.Text, TXT_DescuentoAdicional_RegistroAlquiler.Text, TXT_subtotal_RegistroAlquiler.Text, TXT_FechaDevolucion_RegistroAlquiler.Text, TXT_DiasAtraso_RegistroAlquiler.Text, TXT_usuario_RegistroAlquiler.Text }; //valores a ingresar
            if (logi.modificar_registro_alquiler(valores) == null)
            {
                MessageBox.Show("Error al modificar");
            }
            else
            {
                //MessageBox.Show("Modificacion exitosa");
                MessageBox.Show("Datos modificados a la base de datos", "Modificacion de datos");
                TXT_id_RegistroAlquiler.Enabled = false;
                TXT_IDvideo_RegistroAlquiler.Enabled = false;
                TXT_idCliente_RegistroAlquiler.Enabled = false;
                TXT_Fecha_RegistroAlquiler.Enabled = false;
                TXT_monto_RegistroAlquiler.Enabled = false;
                TXT_mora_RegistroAlquiler.Enabled = false;
                TXT_idUsuario_MembresiaREGISTROALQUILER.Enabled = false;
                TXT_DescuentoMembresia_RegistroAlquiler.Enabled = false;
                TXT_total_RegistroAlquiler.Enabled = false;
                TXT_DescuentoAdicional_RegistroAlquiler.Enabled = false;
                TXT_subtotal_RegistroAlquiler.Enabled = false;
                TXT_FechaDevolucion_RegistroAlquiler.Enabled = false;
                TXT_DiasAtraso_RegistroAlquiler.Enabled = false;
                TXT_usuario_RegistroAlquiler.Enabled = false;

                TXT_id_RegistroAlquiler.Text = "";
                TXT_IDvideo_RegistroAlquiler.Text = "";
                TXT_idCliente_RegistroAlquiler.Text = "";
                TXT_Fecha_RegistroAlquiler.Text = "";
                TXT_monto_RegistroAlquiler.Text = "";
                TXT_mora_RegistroAlquiler.Text = "";
                TXT_idUsuario_MembresiaREGISTROALQUILER.Text = "";
                TXT_DescuentoMembresia_RegistroAlquiler.Text = "";
                TXT_total_RegistroAlquiler.Text = "";
                TXT_DescuentoAdicional_RegistroAlquiler.Text = "";
                TXT_subtotal_RegistroAlquiler.Text = "";
                TXT_FechaDevolucion_RegistroAlquiler.Text = "";
                TXT_DiasAtraso_RegistroAlquiler.Text = "";
                TXT_usuario_RegistroAlquiler.Text = "";

            }
        }
    }
}

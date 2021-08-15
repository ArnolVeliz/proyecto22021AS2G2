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
    public partial class Form10 : Form
    {
        clsControlador logi = new clsControlador();
        public Form10()
        {
            InitializeComponent();
           
        }
        
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario = new Form2();
            formulario.Show();
            this.Close();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void BTN_agregar_FACTURACION_Click(object sender, EventArgs e)
        {
            string[] valores = { TXT_IdFactura_FACTURACION.Text, TXT_noFac__FACTURACION.Text, txt_nitEmpresa_FACTURACION.Text, txt_noSerie_FACTURACION.Text, txt_fechaEmision_FACTURACION.Text, txt_contribuyente_FACTURACION.Text, txt_nomCliente_FACTURACION.Text, txt_dirCliente_FACTURACION.Text, txt_nitCliente_FACTURACION.Text, TXT_MetodoPago_FACTURACION.Text, TXT_usuario_FACTURACION.Text, txt_IDregistro_FACTURACION.Text }; //valores a ingresar
            if (logi.insertar_facturacion(valores) == null)
            {
                MessageBox.Show("Error al guardar");
            }
            else
            {
                MessageBox.Show("Datos agregados a la base de datos", "Ingreso de datos");
                TXT_IdFactura_FACTURACION.Enabled = false;
                TXT_noFac__FACTURACION.Enabled = false;
                txt_nitEmpresa_FACTURACION.Enabled = false;
                txt_noSerie_FACTURACION.Enabled = false;
                txt_fechaEmision_FACTURACION.Enabled = false;
                txt_contribuyente_FACTURACION.Enabled = false;
                txt_nomCliente_FACTURACION.Enabled = false;
                txt_dirCliente_FACTURACION.Enabled = false;
                txt_nitCliente_FACTURACION.Enabled = false;
                TXT_MetodoPago_FACTURACION.Enabled = false;
                TXT_usuario_FACTURACION.Enabled = false;
                txt_IDregistro_FACTURACION.Enabled = false;
                

                TXT_IdFactura_FACTURACION.Text = "";
                TXT_noFac__FACTURACION.Text = "";
                txt_nitEmpresa_FACTURACION.Text = "";
                txt_noSerie_FACTURACION.Text = "";
                txt_fechaEmision_FACTURACION.Text = "";
                txt_contribuyente_FACTURACION.Text = "";
                txt_nomCliente_FACTURACION.Text = "";
                txt_dirCliente_FACTURACION.Text = "";
                txt_nitCliente_FACTURACION.Text = "";
                TXT_MetodoPago_FACTURACION.Text = "";
                TXT_usuario_FACTURACION.Text = "";
                txt_IDregistro_FACTURACION.Text = "";


            }
        }

        private void BTN_modificar_FACTURACION_Click(object sender, EventArgs e)
        {
            string[] valores = { TXT_IdFactura_FACTURACION.Text, TXT_noFac__FACTURACION.Text, txt_nitEmpresa_FACTURACION.Text, txt_noSerie_FACTURACION.Text, txt_fechaEmision_FACTURACION.Text, txt_contribuyente_FACTURACION.Text, txt_nomCliente_FACTURACION.Text, txt_dirCliente_FACTURACION.Text, txt_nitCliente_FACTURACION.Text, TXT_MetodoPago_FACTURACION.Text, TXT_usuario_FACTURACION.Text, txt_IDregistro_FACTURACION.Text }; //valores a ingresar
            if (logi.modificar_categoria_pel(valores) == null)
            {
                MessageBox.Show("Error al modificar");
            }
            else
            {
                //MessageBox.Show("Modificacion exitosa");
                MessageBox.Show("Datos modificados a la base de datos", "Modificacion de datos");
                TXT_IdFactura_FACTURACION.Enabled = false;
                TXT_noFac__FACTURACION.Enabled = false;
                txt_nitEmpresa_FACTURACION.Enabled = false;
                txt_noSerie_FACTURACION.Enabled = false;
                txt_fechaEmision_FACTURACION.Enabled = false;
                txt_contribuyente_FACTURACION.Enabled = false;
                txt_nomCliente_FACTURACION.Enabled = false;
                txt_dirCliente_FACTURACION.Enabled = false;
                txt_nitCliente_FACTURACION.Enabled = false;
                TXT_MetodoPago_FACTURACION.Enabled = false;
                TXT_usuario_FACTURACION.Enabled = false;
                txt_IDregistro_FACTURACION.Enabled = false;


                TXT_IdFactura_FACTURACION.Text = "";
                TXT_noFac__FACTURACION.Text = "";
                txt_nitEmpresa_FACTURACION.Text = "";
                txt_noSerie_FACTURACION.Text = "";
                txt_fechaEmision_FACTURACION.Text = "";
                txt_contribuyente_FACTURACION.Text = "";
                txt_nomCliente_FACTURACION.Text = "";
                txt_dirCliente_FACTURACION.Text = "";
                txt_nitCliente_FACTURACION.Text = "";
                TXT_MetodoPago_FACTURACION.Text = "";
                TXT_usuario_FACTURACION.Text = "";
                txt_IDregistro_FACTURACION.Text = "";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario = new Form13();
            formulario.Show();
            this.Close();
        }
    }
}

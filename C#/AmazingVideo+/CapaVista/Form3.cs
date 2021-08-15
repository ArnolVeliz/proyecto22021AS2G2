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
    public partial class Form3 : Form
    {
        clsControlador logi = new clsControlador();
        public Form3()
        {
            InitializeComponent();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void Button3_Click(object sender, EventArgs e)
        {
            Form formulario = new Form3();
            formulario.Show();
            this.Close();
        }

        private void BTN_modificarUSUARIO_Click(object sender, EventArgs e)
        {

        }

        private void BTN_agregarUSUARIO_Click(object sender, EventArgs e)
        {
            string[] valores = { TXT_idUsuario.Text, TXT_nomUsuario.Text, TXT_apeUSUARIO.Text, TXT_puestoUSUARIO.Text, TXT_dpiUSUARIO.Text, TXT_GeneroUSUARIO.Text, TXT_fechaUSUARIO.Text, TXT_tipoUsuario.Text, txt_telUSUARIO.Text, txt_EstadoCivilUSUARIO.Text, txt_correoUSUARIO.Text, txtContraUSUARIO.Text }; //valores a ingresar
            if (logi.insertar_usuario(valores) == null)
            {
                MessageBox.Show("Error al guardar");
            }
            else
            {
                MessageBox.Show("Datos agregados a la base de datos", "Ingreso de datos");
                TXT_idUsuario.Enabled = false;
                TXT_nomUsuario.Enabled = false;
                TXT_apeUSUARIO.Enabled = false;
                TXT_puestoUSUARIO.Enabled = false;
                TXT_dpiUSUARIO.Enabled = false;
                TXT_GeneroUSUARIO.Enabled = false;
                TXT_fechaUSUARIO.Enabled = false;
                TXT_tipoUsuario.Enabled = false;
                txt_telUSUARIO.Enabled = false;
                txt_EstadoCivilUSUARIO.Enabled = false;
                txt_correoUSUARIO.Enabled = false;
                txtContraUSUARIO.Enabled = false;

                TXT_idUsuario.Text = "";
                TXT_nomUsuario.Text = "";
                TXT_apeUSUARIO.Text = "";
                TXT_puestoUSUARIO.Text = "";
                TXT_dpiUSUARIO.Text = "";
                TXT_GeneroUSUARIO.Text = "";
                TXT_fechaUSUARIO.Text = "";
                TXT_tipoUsuario.Text = "";
                txt_telUSUARIO.Text = "";
                txt_EstadoCivilUSUARIO.Text = "";
                txt_correoUSUARIO.Text = "";
                txtContraUSUARIO.Text = "";

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Form8 : Form
    {
        clsControlador logi = new clsControlador();
        public Form8()
        {
            InitializeComponent();
       
        }

        private void Form8_Load(object sender, EventArgs e)
        {
                
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario = new Form2();
            formulario.Show();
            this.Close();
        }

        private void TXT_agregar_CLIENTES_Click(object sender, EventArgs e)
        {
            string[] valoresE = { TXT_idcliente_CLIENTES.Text, TXT_nom_CLIENTES.Text, TXT_ape_CLIENTES.Text, TXT_fechaNAC_CLIENTES.Text, txt_fechaRegistro_CLIENTES.Text, textBox1.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text, textBox2.Text, textBox3.Text };
            MessageBox.Show("Datos agregados a la base de datos", "Ingreso de datos");
            if (logi.insertar_clientes(valoresE) == null)
            {
                MessageBox.Show("Error al guardar");
            }
            else
            {
                TXT_idcliente_CLIENTES.Enabled = false;
                TXT_nom_CLIENTES.Enabled = false;
                TXT_ape_CLIENTES.Enabled = false;
                TXT_fechaNAC_CLIENTES.Enabled = false;
                txt_fechaRegistro_CLIENTES.Enabled = false;
                textBox1.Enabled = false;
                textBox6.Enabled = false;
                textBox7.Enabled = false;
                textBox8.Enabled = false;
                textBox9.Enabled = false;
                textBox10.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                TXT_idcliente_CLIENTES.Text = "";
                TXT_nom_CLIENTES.Text = "";
                TXT_ape_CLIENTES.Text = "";
                TXT_fechaNAC_CLIENTES.Text = "";
                txt_fechaRegistro_CLIENTES.Text = "";
                textBox1.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            

        }

        private void BTN_modificar_CLIENTES_Click(object sender, EventArgs e)
        {
            string[] valores = { TXT_idcliente_CLIENTES.Text, TXT_nom_CLIENTES.Text, TXT_ape_CLIENTES.Text, TXT_fechaNAC_CLIENTES.Text, txt_fechaRegistro_CLIENTES.Text, textBox1.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text, textBox2.Text, textBox3.Text }; //valores a ingresar
            if (logi.modificar_clientes(valores) == null)
            {
                MessageBox.Show("Error al modificar");
            }
            else
            {
                //MessageBox.Show("Modificacion exitosa");
                MessageBox.Show("Datos modificados a la base de datos", "Modificacion de datos");
                textBox1.Enabled = false;
                TXT_idcliente_CLIENTES.Enabled = false;
                TXT_nom_CLIENTES.Enabled = false;
                TXT_ape_CLIENTES.Enabled = false;
                TXT_fechaNAC_CLIENTES.Enabled = false;
                txt_fechaRegistro_CLIENTES.Enabled = false;
                textBox1.Enabled = false;
                textBox6.Enabled = false;
                textBox7.Enabled = false;
                textBox8.Enabled = false;
                textBox9.Enabled = false;
                textBox10.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                TXT_idcliente_CLIENTES.Text = "";
                TXT_nom_CLIENTES.Text = "";
                TXT_ape_CLIENTES.Text = "";
                TXT_fechaNAC_CLIENTES.Text = "";
                txt_fechaRegistro_CLIENTES.Text = "";
                textBox1.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";

            }
        }
    }
}

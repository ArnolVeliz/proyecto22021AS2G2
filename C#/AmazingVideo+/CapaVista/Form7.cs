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
    public partial class Form7 : Form
    {
        clsControlador logi = new clsControlador();
        public Form7()
        {
            InitializeComponent();
      
        }

        public void mostrar_consulta()
        {
            OdbcDataReader mostrar = logi.consultar("registro_pagos"); //envia el nombre de la tabla pa mostrar contenido
            try
            {


                while (mostrar.Read())
                    dataGridView1.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2), mostrar.GetString(3), mostrar.GetString(4), mostrar.GetString(5), mostrar.GetString(6), mostrar.GetString(7), mostrar.GetString(8), mostrar.GetString(9), mostrar.GetString(10), mostrar.GetString(11)); //anade fila con estos datos

            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario = new Form2();
            formulario.Show();
            this.Close();
        }

        private void BTN_agregar_REGISTROPAGO_Click(object sender, EventArgs e)
        {
            string[] valoresE = { textBox1.Text, TXT_idRegistro_REGISTROPAGO.Text, TXT_alquiler_REGISTROPAGO.Text, TXT_pagototal_REGISTROPAGO.Text, TXT_abono_REGISTROPAGO.Text, TXT_vuelto_REGISTROPAGO.Text, TXT_numeroTarjeta_REGISTROPAGO.Text, TXT_fechaExp_REGISTROPAGO.Text, TXT_titular_REGISTROPAGO.Text, TXT_efectivo_REGISTROPAGO.Text, textBox2.Text, textBox3.Text };
            MessageBox.Show("Datos agregados a la base de datos", "Ingreso de datos");
            textBox1.Enabled = false;
            TXT_idRegistro_REGISTROPAGO.Enabled = false;
            TXT_alquiler_REGISTROPAGO.Enabled = false;
            TXT_pagototal_REGISTROPAGO.Enabled = false;
            TXT_abono_REGISTROPAGO.Enabled = false;
            TXT_vuelto_REGISTROPAGO.Enabled = false;
            TXT_numeroTarjeta_REGISTROPAGO.Enabled = false;
            TXT_fechaExp_REGISTROPAGO.Enabled = false;
            TXT_titular_REGISTROPAGO.Enabled = false;
            TXT_efectivo_REGISTROPAGO.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox1.Text = "";
            TXT_idRegistro_REGISTROPAGO.Text = "";
            TXT_alquiler_REGISTROPAGO.Text = "";
            TXT_pagototal_REGISTROPAGO.Text = "";
            TXT_abono_REGISTROPAGO.Text = "";
            TXT_vuelto_REGISTROPAGO.Text = "";
            TXT_numeroTarjeta_REGISTROPAGO.Text = "";
            TXT_fechaExp_REGISTROPAGO.Text = "";
            TXT_titular_REGISTROPAGO.Text = "";
            TXT_efectivo_REGISTROPAGO.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            if (logi.insertar_registro_pagos(valoresE) == null)
            {
                MessageBox.Show("Error al guardar");
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string[] valores = { textBox1.Text, TXT_idRegistro_REGISTROPAGO.Text, TXT_alquiler_REGISTROPAGO.Text, TXT_pagototal_REGISTROPAGO.Text, TXT_abono_REGISTROPAGO.Text, TXT_vuelto_REGISTROPAGO.Text, TXT_numeroTarjeta_REGISTROPAGO.Text, TXT_fechaExp_REGISTROPAGO.Text, TXT_titular_REGISTROPAGO.Text, TXT_efectivo_REGISTROPAGO.Text, textBox2.Text, textBox3.Text };

                if (logi.insertar_registro_pagos(valores) == null)
                {
                    MessageBox.Show("Error al guardar");
                }
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BTN_modificar_REGISTROPAGO_Click(object sender, EventArgs e)
        {
            string[] valores = { textBox1.Text, TXT_idRegistro_REGISTROPAGO.Text, TXT_alquiler_REGISTROPAGO.Text, TXT_pagototal_REGISTROPAGO.Text, TXT_abono_REGISTROPAGO.Text, TXT_vuelto_REGISTROPAGO.Text, TXT_numeroTarjeta_REGISTROPAGO.Text, TXT_fechaExp_REGISTROPAGO.Text, TXT_titular_REGISTROPAGO.Text, TXT_efectivo_REGISTROPAGO.Text, textBox2.Text, textBox3.Text }; //valores a ingresar
            if (logi.modificar_registro_pagos(valores) == null)
            {
                MessageBox.Show("Error al modificar");
            }
            else
            {
                //MessageBox.Show("Modificacion exitosa");
                MessageBox.Show("Datos modificados a la base de datos", "Modificacion de datos");
                textBox1.Enabled = false;
                TXT_idRegistro_REGISTROPAGO.Enabled = false;
                TXT_alquiler_REGISTROPAGO.Enabled = false;
                TXT_pagototal_REGISTROPAGO.Enabled = false;
                TXT_abono_REGISTROPAGO.Enabled = false;
                TXT_vuelto_REGISTROPAGO.Enabled = false;
                TXT_numeroTarjeta_REGISTROPAGO.Enabled = false;
                TXT_fechaExp_REGISTROPAGO.Enabled = false;
                TXT_titular_REGISTROPAGO.Enabled = false;
                TXT_efectivo_REGISTROPAGO.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox1.Text = "";
                TXT_idRegistro_REGISTROPAGO.Text = "";
                TXT_alquiler_REGISTROPAGO.Text = "";
                TXT_pagototal_REGISTROPAGO.Text = "";
                TXT_abono_REGISTROPAGO.Text = "";
                TXT_vuelto_REGISTROPAGO.Text = "";
                TXT_numeroTarjeta_REGISTROPAGO.Text = "";
                TXT_fechaExp_REGISTROPAGO.Text = "";
                TXT_titular_REGISTROPAGO.Text = "";
                TXT_efectivo_REGISTROPAGO.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            mostrar_consulta();

        }
    }
}

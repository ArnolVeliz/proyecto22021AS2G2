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
    public partial class Form6 : Form
    {
        clsControlador logi = new clsControlador();
        public Form6()
        {
            InitializeComponent();
          
        }

        public void mostrar_consulta()
        {
            OdbcDataReader mostrar = logi.consultar("met_pago"); //envia el nombre de la tabla pa mostrar contenido
            try
            {


                while (mostrar.Read())
                    dataGridView1.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2), mostrar.GetString(3)); //anade fila con estos datos

            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

        }
        private void Form6_Load(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario = new Form2();
            formulario.Show();
            this.Close();
        }

        private void TXT_agregar_METODOPAGO_Click(object sender, EventArgs e)
        {
            string[] valoresE = { TXT_idmetodo_METODOPAGO.Text, TXT_nom_METODOPAGO.Text, TXT_descripcion_METODOPAGO.Text, textBox1.Text };
            MessageBox.Show("Datos agregados a la base de datos", "Ingreso de datos");
            TXT_idmetodo_METODOPAGO.Enabled = false;
            TXT_nom_METODOPAGO.Enabled = false;
            TXT_descripcion_METODOPAGO.Enabled = false;
            textBox1.Enabled = false;
            TXT_idmetodo_METODOPAGO.Text = "";
            TXT_nom_METODOPAGO.Text = "";
            TXT_descripcion_METODOPAGO.Text = "";
            textBox1.Text = "";
            if (logi.insertar_met_pago(valoresE) == null)
            {
                MessageBox.Show("Error al guardar");
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string[] valores = { TXT_idmetodo_METODOPAGO.Text, TXT_nom_METODOPAGO.Text, TXT_descripcion_METODOPAGO.Text, textBox1.Text };

                if (logi.insertar_met_pago(valores) == null)
                {
                    MessageBox.Show("Error al guardar");
                }
            }
        }

        private void BTN_modificar_METODOPAGO_Click(object sender, EventArgs e)
        {
            string[] valores = { TXT_idmetodo_METODOPAGO.Text, TXT_nom_METODOPAGO.Text, TXT_descripcion_METODOPAGO.Text, textBox1.Text }; //valores a ingresar
            if (logi.modificar_met_pago(valores) == null)
            {
                MessageBox.Show("Error al modificar");
            }
            else
            {
                //MessageBox.Show("Modificacion exitosa");
                MessageBox.Show("Datos modificados a la base de datos", "Modificacion de datos");
                TXT_idmetodo_METODOPAGO.Enabled = false;
                TXT_nom_METODOPAGO.Enabled = false;
                TXT_descripcion_METODOPAGO.Enabled = false;
                textBox1.Enabled = false;
                TXT_idmetodo_METODOPAGO.Text = "";
                TXT_nom_METODOPAGO.Text = "";
                TXT_descripcion_METODOPAGO.Text = "";
                textBox1.Text = "";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            mostrar_consulta();
        }
    }
}

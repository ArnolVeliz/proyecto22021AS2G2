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
    public partial class Form11 : Form
    {
        clsControlador logi = new clsControlador();
        public Form11()
        {
            InitializeComponent();
            
        }

        public void mostrar_consulta()
        {
            OdbcDataReader mostrar = logi.consultar("categoria_pel"); //envia el nombre de la tabla pa mostrar contenido
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
        private void Form11_Load(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario = new Form2();
            formulario.Show();
            this.Close();
        }

        private void BTN_agregar_CATEPELI_Click(object sender, EventArgs e)
        {
            string[] valoresE = { TXT_idCategoria_CATEPELI.Text, TXT_nombre_CATEPELI.Text, TXT_des_CATEPELI.Text, textBox1.Text};
            MessageBox.Show("Datos agregados a la base de datos", "Ingreso de datos");
            TXT_idCategoria_CATEPELI.Enabled = false;
            TXT_nombre_CATEPELI.Enabled = false;
            TXT_des_CATEPELI.Enabled = false;
            textBox1.Enabled = false;
            TXT_idCategoria_CATEPELI.Text = "";
            TXT_nombre_CATEPELI.Text = "";
            TXT_des_CATEPELI.Text = "";
            textBox1.Text = "";
            if (logi.insertar_categoria_pel(valoresE) == null)
            {
                MessageBox.Show("Error al guardar");
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string[] valores = { TXT_idCategoria_CATEPELI.Text, TXT_nombre_CATEPELI.Text, TXT_des_CATEPELI.Text, textBox1.Text };

                if (logi.insertar_categoria_pel(valores) == null)
                {
                    MessageBox.Show("Error al guardar");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            mostrar_consulta();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TXT_des_CATEPELI.Text = "";
            TXT_idCategoria_CATEPELI.Text = "";
            TXT_nombre_CATEPELI.Text = "";
            textBox1.Text = "";
        }

        private void BTN_modificar_CATEPELI_Click(object sender, EventArgs e)
        {
            string[] valores = { TXT_idCategoria_CATEPELI.Text, TXT_nombre_CATEPELI.Text, TXT_des_CATEPELI.Text, textBox1.Text }; //valores a ingresar
            if (logi.modificar_categoria_pel(valores) == null)
            {
                MessageBox.Show("Error al modificar");
            }
            else
            {
                //MessageBox.Show("Modificacion exitosa");
                MessageBox.Show("Datos modificados a la base de datos", "Modificacion de datos");
                TXT_idCategoria_CATEPELI.Enabled = false;
                TXT_nombre_CATEPELI.Enabled = false;
                TXT_des_CATEPELI.Enabled = false;
                textBox1.Enabled = false;
                TXT_idCategoria_CATEPELI.Text = "";
                TXT_nombre_CATEPELI.Text = "";
                TXT_des_CATEPELI.Text = "";
                textBox1.Text = "";

            }
        }
    }
}

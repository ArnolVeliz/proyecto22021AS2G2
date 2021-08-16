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
    public partial class Form4 : Form
    {
        clsControlador logi = new clsControlador();
        public Form4()
        {
            InitializeComponent();
          
        }
        public void mostrar_consulta()
        {
            OdbcDataReader mostrar = logi.consultar("membresias"); //envia el nombre de la tabla pa mostrar contenido
            try
            {


                while (mostrar.Read())
                    dataGridView1.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2), mostrar.GetString(3), mostrar.GetString(4), mostrar.GetString(5)); //anade fila con estos datos

            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario = new Form2();
            formulario.Show();
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void BTN_agregarMEMBRESIA_Click(object sender, EventArgs e)
        {
            string[] valoresE = { TXT_idMEMBRESIA.Text, TXT__nomMEMBRESIA.Text, TXT_descripcionMEMBRESIA.Text, txt_descuentoMEMBRESIA.Text, TXT__numPeliculaMEMBRESIA.Text, textBox1.Text };
            MessageBox.Show("Datos agregados a la base de datos", "Ingreso de datos");
            TXT_idMEMBRESIA.Enabled = false;
            TXT__nomMEMBRESIA.Enabled = false;
            TXT_descripcionMEMBRESIA.Enabled = false;
            txt_descuentoMEMBRESIA.Enabled = false;
            TXT__numPeliculaMEMBRESIA.Enabled = false;
            textBox1.Enabled = false;
            TXT_idMEMBRESIA.Text = "";
            TXT__nomMEMBRESIA.Text = "";
            TXT_descripcionMEMBRESIA.Text = "";
            txt_descuentoMEMBRESIA.Text = "";
            TXT__numPeliculaMEMBRESIA.Text = "";
            textBox1.Text = "";
            if (logi.insertar_membresias(valoresE) == null)
            {
                MessageBox.Show("Error al guardar");
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string[] valores = { TXT_idMEMBRESIA.Text, TXT__nomMEMBRESIA.Text, TXT_descripcionMEMBRESIA.Text, txt_descuentoMEMBRESIA.Text, TXT__numPeliculaMEMBRESIA.Text, textBox1.Text };

                if (logi.insertar_membresias(valores) == null)
                {
                    MessageBox.Show("Error al guardar");
                }
            }

        }

        private void BTN_modificarMEMBRESIA_Click(object sender, EventArgs e)
        {
            string[] valores = { TXT_idMEMBRESIA.Text, TXT__nomMEMBRESIA.Text, TXT_descripcionMEMBRESIA.Text, txt_descuentoMEMBRESIA.Text, TXT__numPeliculaMEMBRESIA.Text, textBox1.Text }; //valores a ingresar
            if (logi.modificar_membresias(valores) == null)
            {
                MessageBox.Show("Error al modificar");
            }
            else
            {
                //MessageBox.Show("Modificacion exitosa");
                MessageBox.Show("Datos modificados a la base de datos", "Modificacion de datos");
                TXT_idMEMBRESIA.Enabled = false;
                TXT__nomMEMBRESIA.Enabled = false;
                TXT_descripcionMEMBRESIA.Enabled = false;
                txt_descuentoMEMBRESIA.Enabled = false;
                TXT__numPeliculaMEMBRESIA.Enabled = false;
                textBox1.Enabled = false;
                TXT_idMEMBRESIA.Text = "";
                TXT__nomMEMBRESIA.Text = "";
                TXT_descripcionMEMBRESIA.Text = "";
                txt_descuentoMEMBRESIA.Text = "";
                TXT__numPeliculaMEMBRESIA.Text = "";
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

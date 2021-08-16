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

    public partial class Form9 : Form
    {
        clsControlador logi = new clsControlador();

        public Form9()
        {
          
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario = new Form2();
            formulario.Show();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void BTN_agregar_VIDEOSREGIS_Click(object sender, EventArgs e)
        {
            string[] valores = { TXT_idVideo_VIDEOSREGIS.Text, TXT_nom_VIDEOSREGIS.Text, TXT_categoria_VIDEOSREGIS.Text, TXT_estreno_VIDEOSREGIS.Text, TXT_duracion_VIDEOSREGIS.Text, TXT_cantidad_VIDEOSREGIS.Text, TXT_precioDia_VIDEOSREGIS.Text, txt_fechaingreso_VIDEOSREGIS.Text, textBox1.Text }; //valores a ingresar
            if (logi.insertar_videos(valores) == null)
            {
                MessageBox.Show("Error al guardar");
            }
            else
            {
                MessageBox.Show("Guardado exitosamente");
                TXT_idVideo_VIDEOSREGIS.Enabled = false;
                TXT_nom_VIDEOSREGIS.Enabled = false;
                TXT_categoria_VIDEOSREGIS.Enabled = false;
                TXT_estreno_VIDEOSREGIS.Enabled = false;
                TXT_duracion_VIDEOSREGIS.Enabled = false;
                TXT_cantidad_VIDEOSREGIS.Enabled = false;
                TXT_precioDia_VIDEOSREGIS.Enabled = false;
                txt_fechaingreso_VIDEOSREGIS.Enabled = false;
                textBox1.Enabled = false;
                TXT_idVideo_VIDEOSREGIS.Text = "";
                TXT_nom_VIDEOSREGIS.Text = "";
                TXT_categoria_VIDEOSREGIS.Text = "";
                TXT_estreno_VIDEOSREGIS.Text = "";
                TXT_duracion_VIDEOSREGIS.Text = "";
                TXT_cantidad_VIDEOSREGIS.Text = "";
                TXT_precioDia_VIDEOSREGIS.Text = "";
                txt_fechaingreso_VIDEOSREGIS.Text = "";
                textBox1.Text = "";

            }

        }

        private void BTN_modificar_VIDEOSREGIS_Click(object sender, EventArgs e)
        {
            string[] valores = { TXT_idVideo_VIDEOSREGIS.Text, TXT_nom_VIDEOSREGIS.Text, TXT_categoria_VIDEOSREGIS.Text, TXT_estreno_VIDEOSREGIS.Text, TXT_duracion_VIDEOSREGIS.Text, TXT_cantidad_VIDEOSREGIS.Text, TXT_precioDia_VIDEOSREGIS.Text, txt_fechaingreso_VIDEOSREGIS.Text, textBox1.Text }; //valores a ingresar
            if (logi.modificar_videos(valores) == null)
            {
                MessageBox.Show("Error al modificar");
            }
            else
            {
                //MessageBox.Show("Modificacion exitosa");
                MessageBox.Show("Datos modificados a la base de datos", "Modificacion de datos");
                TXT_idVideo_VIDEOSREGIS.Enabled = false;
                TXT_nom_VIDEOSREGIS.Enabled = false;
                TXT_categoria_VIDEOSREGIS.Enabled = false;
                TXT_estreno_VIDEOSREGIS.Enabled = false;
                TXT_duracion_VIDEOSREGIS.Enabled = false;
                TXT_cantidad_VIDEOSREGIS.Enabled = false;
                TXT_precioDia_VIDEOSREGIS.Enabled = false;
                txt_fechaingreso_VIDEOSREGIS.Enabled = false;
                textBox1.Enabled = false;
                TXT_idVideo_VIDEOSREGIS.Text = "";
                TXT_nom_VIDEOSREGIS.Text = "";
                TXT_categoria_VIDEOSREGIS.Text = "";
                TXT_estreno_VIDEOSREGIS.Text = "";
                TXT_duracion_VIDEOSREGIS.Text = "";
                TXT_cantidad_VIDEOSREGIS.Text = "";
                TXT_precioDia_VIDEOSREGIS.Text = "";
                txt_fechaingreso_VIDEOSREGIS.Text = "";
                textBox1.Text = "";

            }
        }
    }
}

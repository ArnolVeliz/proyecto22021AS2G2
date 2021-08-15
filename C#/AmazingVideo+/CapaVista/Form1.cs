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
    public partial class Form1 : Form
    {
        clsControlador logi = new clsControlador();

        public Form1()
        {
            InitializeComponent();
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TXTusuario.Text != "Username" && TXTusuario.TextLength > 2)
            {
                if (TXTcontra.Text != "Password")
                {

                    var validLogin = logi.consultarlogin(TXTusuario.Text, TXTcontra.Text);
                    if (validLogin ==  null)
                    {
                        this.Hide();
                        MessageBox.Show("Error");
                        TXTcontra.Text = " ";
                        TXTusuario.Focus();
                    }
                    else
                    {
                        
                        Form2 frm = new Form2();

                        MessageBox.Show("Bienvenido ");
                        this.Hide();
                        frm.Show();

                        
                    }
                }
                else MessageBox.Show("Please enter password.");
                
            }
            else MessageBox.Show("Please enter username.");

            




        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new Form3();
            formulario.Show();
            
        }

        private void TXTcontra_TextChanged(object sender, EventArgs e)
        {
            TXTcontra.PasswordChar = '*';
        }
    }
}

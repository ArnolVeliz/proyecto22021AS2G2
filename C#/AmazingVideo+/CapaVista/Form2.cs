using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form formulario = new Form3();
            formulario.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form formulario = new Form4();
            formulario.Show();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario = new Form5();
            formulario.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form formulario = new Form6();
            formulario.Show();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form formulario = new Form7();
            formulario.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form formulario = new Form8();
            formulario.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form formulario = new Form9();
            formulario.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form formulario = new Form10();
            formulario.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario = new Form11();
            formulario.Show();
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form formulario = new Form1();
            formulario.Show();
            this.Close();

        }
    }
}

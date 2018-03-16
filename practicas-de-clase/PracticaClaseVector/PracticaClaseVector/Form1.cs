using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaClaseVector
{
    public partial class Form1 : Form
    {
        MiVector vect;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            vect = new MiVector(int.Parse(textBox2.Text));
            button1.Enabled = false;
            textBox1.Text += "hecho.." + Environment.NewLine;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vect.fill();
            textBox1.Text += "llenado secuencialmente.." + Environment.NewLine;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vect.fill(int.Parse(textBox3.Text));
            textBox1.Text += "llenado random.." + Environment.NewLine;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "suma de los elementos = ";
            textBox1.Text += vect.sum().ToString() + Environment.NewLine;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "promedio de los elementos = ";
            textBox1.Text += vect.mean().ToString() + Environment.NewLine;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += vect.show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += vect.showinv();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void btn_girara_Click(object sender, EventArgs e)
        {
            textBox1.Text += "girar arriba.." + Environment.NewLine;
            vect.girarArriba();
        }

        private void btn_girard_Click(object sender, EventArgs e)
        {
            textBox1.Text += "girar abajp.." + Environment.NewLine;
            vect.girarAbajo();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "invertir" + Environment.NewLine;
            vect.invertir();
        }
    }
}

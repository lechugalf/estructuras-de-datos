using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaClaseDado
{
    public partial class Form1 : Form
    {
        int[] tiros, sumas;
        Dado dado, dado2;

        public Form1()
        {
            InitializeComponent();
            tiros = new int[6];
            sumas = new int[11];
            dado = new Dado();
            dado2 = new Dado();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            int suma = 0;
            for (int x = 0; x < 100; x++)
            {
                suma = dado.tirar() + dado2.tirar();
                sumas[suma - 2]++;
            }
            for (int i = 0; i < 11; i++)
                textBox1.Text += "suma " + (i + 2).ToString() + " cayo " + sumas[i] + Environment.NewLine;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int x=0; x<100; x++)
            {
                switch (dado.tirar())
                {
                    case 1: tiros[0]++; break;
                    case 2: tiros[1]++; break;
                    case 3: tiros[2]++; break;
                    case 4: tiros[3]++; break;
                    case 5: tiros[4]++; break;
                    case 6: tiros[5]++; break;
                }
            }
            for (int i = 1; i <= 6; i++)
                textBox1.Text += "cara " + i.ToString() + " cayo " + tiros[i - 1] + Environment.NewLine;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            int suma = 0;
            for(int x=0; x<100; x++)
            {
                suma = dado.tirar() + dado.tirar();
                sumas[suma - 2]++;
            }
            for (int i = 0; i < 11; i++)
                textBox1.Text += "suma " + (i+2).ToString() + " cayo " + sumas[i] + Environment.NewLine;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guerra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nave navet = new Nave("Terricola");
            Nave navem = new Nave("Marciana");

            while (navem.cuantosQuedan() > 0 && navet.cuantosQuedan() > 0)
            {
                for(int t = 0; t < 10; t++)
                {
                    navem.recibirDisparo(navet.disparar(t));
                    navet.recibirDisparo(navem.disparar(t));
                }
            }
            if (navem.cuantosQuedan() > 0)
                MessageBox.Show("Ganan los marcianos!!!");
            else
                MessageBox.Show("Ganan los terricolas!!!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaCarrera
{
    public partial class Carrera : Form
    {
        private Corredor jug1, jug2;

        public Carrera()
        {
            InitializeComponent();
        }

        private void btn_jugar_Click(object sender, EventArgs e)
        {
            txtBx_jug1.Enabled = false;
            txtBx_jug2.Enabled = false;

            jug1 = new Corredor(txtBx_jug1.Text, 12);
            jug2 = new Corredor(txtBx_jug2.Text, 4);

            while (jug1.Pasos < 100 && jug2.Pasos < 100)
            {
                imprimeEstado();
                jug1.Correr();
                jug2.Correr();
            }
            txtBx_carrera.Text += "Ganador " + ganador();
        }

        private void imprimeEstado()
        {
            txtBx_carrera.Text += jug1.Nombre + " esta en "
                    + jug1.Pasos.ToString()
                    + Environment.NewLine
                    + jug2.Nombre + " esta en "
                    + jug2.Pasos.ToString()
                    + Environment.NewLine;
        }

        private string ganador()
        {
            if (jug1.Pasos > jug2.Pasos) return jug1.Nombre;
            else if (jug1.Pasos < jug2.Pasos) return jug2.Nombre;
            else return "Empate!";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda2
{
    public partial class Form1 : Form
    {
        Agenda agenda;

        public Form1()
        {
            agenda = new Agenda(5);
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Contacto ncon = new Contacto
                (
                    txtBx_nom.Text,
                    txtBx_app.Text,
                    txtBx_apm.Text,
                    byte.Parse(txtBx_eda.Text),
                    txtBx_ema.Text,
                    txtBx_tel.Text
                );
            if (agenda.Agregar(ncon) == 0)
                txtBx_salida.Text = "Contacto Agregado" + Environment.NewLine;
            else
                txtBx_salida.Text = "Agenda llena" + Environment.NewLine;

        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            txtBx_salida.Text = agenda.Listar();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de borrar el contacto actual?", "Eliminar Contacto", MessageBoxButtons.YesNo) == DialogResult.Yes)
                agenda.Eliminar(int.Parse(txtBx_pos.Text));
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Contacto resultado = agenda.Buscar(txtBx_tel.Text);
            if (resultado != null)
            {
                txtBx_nom.Text = resultado.Nombre;
                txtBx_app.Text = resultado.Apellido_p;
                txtBx_apm.Text = resultado.Apellido_m;
                txtBx_eda.Text = resultado.Edad.ToString();
                txtBx_ema.Text = resultado.Email;
                txtBx_tel.Text = resultado.Telefono;
                txtBx_salida.Text = "Teléfono encontrado" + Environment.NewLine;
            }
        }
    }
}

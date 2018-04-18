using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Form1 : Form
    {
        Agenda agenda;

        public Form1()
        {
            agenda = new Agenda(10);
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            //verificamos si hay espacio para un nuevo contacto
            if (agenda.Nuevo == agenda.Len)
                txtBx_salida.Text = "Agenda Llena!" + Environment.NewLine;
            else
            {
                //creamos un objeto para nuestro nuevo contacto
                Contacto ncon = new Contacto();
                ncon.Nombre = txtBx_nom.Text;
                ncon.Apellido_p = txtBx_app.Text;
                ncon.Apellido_m = txtBx_apm.Text;
                ncon.Edad = byte.Parse(txtBx_eda.Text);
                ncon.Email = txtBx_ema.Text;
                ncon.Telefono = txtBx_tel.Text;

                //agrgamos nuestro nuevo contacto a la agenda
                agenda.Agregar(ncon);
                txtBx_salida.Text = "Nuevo Contacto Agregado" + Environment.NewLine;
                txtBx_pos.Text = agenda.Nuevo.ToString();

                //limpiamos el formulario
                txtBx_nom.Clear();
                txtBx_app.Clear();
                txtBx_apm.Clear();
                txtBx_eda.Clear();
                txtBx_ema.Clear();
                txtBx_tel.Clear();
                txtBx_nom.Focus();
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            //buscamos en la agenda
            int result = agenda.Buscar(txtBx_tel.Text);

            //si la busqueda nos devuelve una posicion valida mostramos el contacto 
            if (result != -1)
            {
                txtBx_nom.Text = agenda.Contactos(result).Nombre;
                txtBx_app.Text = agenda.Contactos(result).Apellido_p;
                txtBx_apm.Text = agenda.Contactos(result).Apellido_m;
                txtBx_eda.Text = agenda.Contactos(result).Edad.ToString();
                txtBx_ema.Text = agenda.Contactos(result).Email;
                txtBx_tel.Text = agenda.Contactos(result).Telefono;
                txtBx_pos.Text = result.ToString();
                txtBx_salida.Text = "Teléfono encontrado" + Environment.NewLine;
            }
            else
            {
                txtBx_salida.Text = "Ningún contacto coincide con el numero buscado" + Environment.NewLine;
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Estas seguro de borrar el contacto actual?", "Eliminar Contacto", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                agenda.Eliminar(byte.Parse(txtBx_pos.Text));
                txtBx_nom.Clear();
                txtBx_app.Clear();
                txtBx_apm.Clear();
                txtBx_eda.Clear();
                txtBx_ema.Clear();
                txtBx_tel.Clear();
                txtBx_nom.Focus();
            }
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            txtBx_salida.Text = agenda.Listar() + Environment.NewLine;
        }

        private void btn_insertar_Click(object sender, EventArgs e)
        {
            //verificamos si hay espacio para un nuevo contacto
            if (agenda.Nuevo == agenda.Len)
                txtBx_salida.Text = "Agenda Llena!" + Environment.NewLine;
            else
            {
                //creamos un objeto para nuestro nuevo contacto
                Contacto ncon = new Contacto();
                ncon.Nombre = txtBx_nom.Text;
                ncon.Apellido_p = txtBx_app.Text;
                ncon.Apellido_m = txtBx_apm.Text;
                ncon.Edad = byte.Parse(txtBx_eda.Text);
                ncon.Email = txtBx_ema.Text;
                ncon.Telefono = txtBx_tel.Text;

                //agrgamos nuestro nuevo contacto a la agenda
                byte pos = byte.Parse(txtBx_pos.Text);
                if (pos <= agenda.Nuevo)
                {
                    agenda.Insertar(ncon, byte.Parse(txtBx_pos.Text));
                    txtBx_salida.Text = "Nuevo Contacto Agregado" + Environment.NewLine;
                }
                else
                {
                    txtBx_salida.Text = "posicion invalida" + Environment.NewLine;
                }

                //limpiamos el formulario
                txtBx_nom.Clear();
                txtBx_app.Clear();
                txtBx_apm.Clear();
                txtBx_eda.Clear();
                txtBx_ema.Clear();
                txtBx_tel.Clear();
                txtBx_nom.Focus();
            }
        }
    }
}

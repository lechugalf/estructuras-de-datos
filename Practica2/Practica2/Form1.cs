using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Practica2
{
    public partial class form_Practica2 : Form
    {
        private BMP bmpinfo;

        public form_Practica2()
        {
            InitializeComponent();
        }

        private void btn_readBmp_Click(object sender, EventArgs e)
        {
            //abrir opendialog para obtener el nombre del archivo a leer
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "Archivo de mapa de bits BMP *bmp|*.bmp|Todos los archivos *.|*";
            openfile.ShowDialog();

            //crear objeto BMP
            bmpinfo = new BMP(openfile.FileName);

            //mostrar información del objeto solo si el archivo bmp es valido
            if (bmpinfo.isBmp)
            {
                txtBox_result.Text = "Archivo: " + bmpinfo.filename + Environment.NewLine;
                txtBox_result.Text += "Tamaño(bytes):" + bmpinfo.size.ToString() + Environment.NewLine;
                txtBox_result.Text += "Ancho: " + bmpinfo.width.ToString() + Environment.NewLine;
                txtBox_result.Text += "Alto: " + bmpinfo.height.ToString() + Environment.NewLine;
                txtBox_result.Text += "Bits por pixel: " + bmpinfo.npixel.ToString() + Environment.NewLine;
            }
            else
                txtBox_result.Text = "El archivo  " + bmpinfo.filename + "  es invalido, no es un bmp";

        }

        private void genXml(string filename, string[] parms)
        {
            //configuracion del archivo XML
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.NewLineOnAttributes = true;
            XmlWriter writer = XmlWriter.Create(filename, settings);

            //escribe el header de XML
            writer.WriteStartDocument();

            //escribe etiqueta 
            writer.WriteStartElement("Agenda");

            //escribe subetiqueta
            writer.WriteStartElement("nombre");
            writer.WriteString(parms[0]);

            //escribe cierre de subetiqueta
            writer.WriteEndElement();

            //asi con los otros nodos...
            writer.WriteStartElement("cuenta");
            writer.WriteString(parms[1]);
            writer.WriteEndElement();
            writer.WriteStartElement("telefono");
            writer.WriteString(parms[2]);
            writer.WriteEndElement();
            writer.WriteStartElement("edad");
            writer.WriteString(parms[3]);
            writer.WriteEndElement();
            writer.WriteStartElement("correo");
            writer.WriteString(parms[4]);
            writer.WriteEndElement();

            //escribe cierre de etiqueta
            writer.WriteEndElement();

            writer.Close();
        }

        private void btn_genXML_Click(object sender, EventArgs e)
        {
            //definimos el nombre del archivo XML que queremos guardar
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "xml(*.xml)|*.xml";
            savefile.ShowDialog();

            //almacenamos los parametros en un arreglo
            string[] parms = { txtBx_val1.Text, txtBx_val2.Text, txtBx_val3.Text, txtBx_val4.Text, txtBx_val5.Text };

            //generamos el archivo XML
            genXml(savefile.FileName, parms);
        }
    }
}

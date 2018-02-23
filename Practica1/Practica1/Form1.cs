using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data
{
    public partial class Form_Practica1 : Form
    {
        //object that process the number
        Data dat;

        public Form_Practica1()
        {
            dat = new Data();
            InitializeComponent();
        }

        private void Btn_SetDate_Click(object sender, EventArgs e)
        {
            //method that adjust date
            dat.SetDate(Dtp_SetDate.Value.Day, Dtp_SetDate.Value.Month, Dtp_SetDate.Value.Year-1900);
            TxtBx_SetDate.Text = dat.GetDate().ToString();
        }

        private void Btn_Procces_Click(object sender, EventArgs e)
        {
            //clear form objects
            PicBx_Direction.Image = null;
            PrBar_Level.Style = ProgressBarStyle.Blocks;
            PicBx_Sensor1.BackColor = Color.LightGray;
            PicBx_Sensor2.BackColor = Color.LightGray;

            //process number
            dat.Input = uint.Parse(TxtBx_Procces.Text);
            dat.Procces();

            //set data to form objects
            //Direction
            switch (dat.Direction)
            {
                case 0: PicBx_Direction.Image = Practica1.Properties.Resources.N; break;
                case 1: PicBx_Direction.Image = Practica1.Properties.Resources.NE;break;
                case 2: PicBx_Direction.Image = Practica1.Properties.Resources.E; break;
                case 3: PicBx_Direction.Image = Practica1.Properties.Resources.SE;break;
                case 4: PicBx_Direction.Image = Practica1.Properties.Resources.S; break;
                case 5: PicBx_Direction.Image = Practica1.Properties.Resources.SO;break;
                case 6: PicBx_Direction.Image = Practica1.Properties.Resources.O; break;
                case 7: PicBx_Direction.Image = Practica1.Properties.Resources.NO;break;
            }

            //level
            switch (dat.Level)
            {
                case 0: PrBar_Level.Value = 0; break;
                case 1: PrBar_Level.Value = 50; break;
                case 2: PrBar_Level.Value = 100; break;
                case 3:
                    PrBar_Level.Value = 100;
                    PrBar_Level.Style = ProgressBarStyle.Marquee;
                    break;
            }

            //Sensors
            if ((dat.Sensors & 1) == 1)
                PicBx_Sensor2.BackColor = Color.Green;

            if ((dat.Sensors >> 1) == 1)
                PicBx_Sensor1.BackColor = Color.Green;

            //Date
            Lbl_Date.Text = (dat.DateYear + 1900).ToString() + '/'
                + dat.DateMonth.ToString() + '/'
                + dat.DateDay.ToString();
        }
    }
}

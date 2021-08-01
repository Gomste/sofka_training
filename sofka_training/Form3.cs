using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sofka_training
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            MessageBox.Show(Convert.ToString(Form1.x1));
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            Convert.ToBoolean(button2.Visible);
            button2.Visible = false;
            Convert.ToBoolean(button1.Visible);
            button1.Visible = true;

            int[] tiempos = {Form1.x1,Form1.x2,Form1.x3, Form1.x4, Form1.x5};
            int puesto1 = 0;
            int puesto2 = 0;
            int puesto3 = 0;

            for (int i = 0; i < 5; i++)
            {
                if (tiempos[i]>puesto1)
                {
                    puesto1 = tiempos[i];
                }
                if (tiempos[i] < puesto1 && tiempos[i] > puesto3 && tiempos[i] > puesto2)
                {
                    puesto2 = tiempos[i]; 
                }
                if (tiempos[i] < puesto1 && tiempos[i] < puesto2 && tiempos[i] > puesto3)
                {
                    puesto3 = tiempos[i];
                }
            }


            label2.Text = Convert.ToString(puesto1);
            label3.Text = Convert.ToString(puesto2);
            label4.Text = Convert.ToString(puesto3);
            //Form1.jugadores jugador1 = new Form1.jugadores();
           
        }
    }
}

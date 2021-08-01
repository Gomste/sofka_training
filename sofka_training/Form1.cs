using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace sofka_training
{
    public partial class Form1 : Form
    {
        public static int dado,x1,x2,x3,x4,x5,cont,dis=0,cont2=1;

        public Form1()
        {
            InitializeComponent();
        }

        private void podioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {
            Random aletorio = new Random();
            int dadoa;
            dadoa = aletorio.Next(1, 7);
            label6.Text = Convert.ToString(dadoa);
            dado = Convert.ToInt32(this.label6.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("porfavor ingresar detos necesarios para jugar");
            }
            if (comboBox2.Text != "" && comboBox1.Text != "")
            {
            label2.Text = Convert.ToString("0");
            label3.Text = Convert.ToString("0");
            label4.Text = Convert.ToString("0");
            label5.Text = Convert.ToString("0");
            label7.Text = Convert.ToString("0");
                x1 = 0;
                x2 = 0;
                x3 = 0;
                x4 = 0;
                cont = 1;

                if (Convert.ToInt32(comboBox1.SelectedIndex) == 0)
                {
                    dis = 5000;
                }
                if (Convert.ToInt32(comboBox1.SelectedIndex) == 1)
                {
                    dis = 10000;
                }
                if (Convert.ToInt32(comboBox1.SelectedIndex) == 2)
                {
                    dis = 15000;
                }
               
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 informacion = new Form4();
            informacion.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 podio = new Form3();
            
            if (dis == 0)
            {
                MessageBox.Show("por favor darle al boton de jugar");
            }
            else
            {
                switch (Convert.ToInt32(comboBox2.Text))
                {
                    case 1:
                        if (x1 >= dis)
                        {
                            MessageBox.Show("has terminado la carrera con " + x1);
                            podio.Show();
                        }
                        else
                        {
                            x1 = x1 + (dado * 100);
                            label2.Text = Convert.ToString(x1);
                            MessageBox.Show("lanza el dado nuevamente");
                        }
                        break;
                    case 2:

                        switch (cont)
                        {
                            case 1:
                                if (x1 > dis)
                                {
                                    MessageBox.Show(" jugador 1 has terminado la carrera con " + x1);
                                    cont = 2;
                                    podio.Show();
                                }
                                else
                                {
                                    x1 = x1 + (dado * 100);
                                    label2.Text = Convert.ToString(x1);
                                    MessageBox.Show("turno del jugador 2");
                                    cont++;
                                }
                                break;
                            case 2:
                                if (x2 > dis)
                                {
                                    MessageBox.Show("jugador 2 has terminado la carrera con " + x2);
                                    cont = 1;
                                    podio.Show();
                                }
                                else
                                {
                                    x2 = x2 + (dado * 100);
                                    label3.Text = Convert.ToString(x2);
                                    MessageBox.Show("turno del jugador 1");
                                    cont--;
                                }
                                break;
                        }
                        break;
                    case 3:
                        switch (cont)
                        {
                            case 1:
                                if (x1 > dis)
                                {
                                    MessageBox.Show("has terminado la carrera con " + x1);
                                    podio.Show();
                                }
                                else
                                {
                                    x1 = x1 + (dado * 100);
                                    label2.Text = Convert.ToString(x1);
                                    MessageBox.Show("turno del jugador 2");
                                    cont++;
                                }
                                break;
                            case 2:
                                if (x2 > dis)
                                {
                                    MessageBox.Show("has terminado la carrera con " + x2);
                                    podio.Show();
                                }
                                else
                                {
                                    x2 = x2 + (dado * 100);
                                    label3.Text = Convert.ToString(x2);
                                    MessageBox.Show("turno del jugador 3");
                                    cont++;
                                }
                                break;
                            case 3:
                                if (x3 > dis)
                                {
                                    MessageBox.Show("has terminado la carrera con " + x3);
                                    podio.Show();
                                }
                                else
                                {
                                    x3 = x3 + (dado * 100);
                                    label4.Text = Convert.ToString(x3);
                                    MessageBox.Show("turno del jugador 1");
                                    cont = 1;
                                }
                                break;
                        }
                        break;
                    case 4:
                        switch (cont)
                        {
                            case 1:
                                if (x1 > dis)
                                {
                                    MessageBox.Show("has terminado la carrera con " + x1);
                                    podio.Show();
                                }
                                else
                                {
                                    x1 = x1 + (dado * 100);
                                    label2.Text = Convert.ToString(x1);
                                    MessageBox.Show("turno del jugador 2");
                                    cont++;
                                }
                                break;
                            case 2:
                                if (x2 > dis)
                                {
                                    MessageBox.Show("has terminado la carrera con " + x2);
                                    podio.Show();
                                }
                                else
                                {
                                    x2 = x2 + (dado * 100);
                                    label3.Text = Convert.ToString(x2);
                                    MessageBox.Show("turno del jugador 3");
                                    cont++;
                                }
                                break;
                            case 3:
                                if (x3 > dis)
                                {
                                    MessageBox.Show("has terminado la carrera con " + x3);
                                    podio.Show();
                                }
                                else
                                {
                                    x3 = x3 + (dado * 100);
                                    label4.Text = Convert.ToString(x3);
                                    MessageBox.Show("turno del jugador 4");
                                    cont++;
                                }
                                break;
                            case 4:
                                if (x4 > dis)
                                {
                                    MessageBox.Show("has terminado la carrera con " + x4);
                                    podio.Show();
                                }
                                else
                                {
                                    x4 = x4 + (dado * 100);
                                    label5.Text = Convert.ToString(x4);
                                    MessageBox.Show("turno del jugador 1");
                                    cont = 1;
                                }
                                break;
                        }
                        break;
                    case 5:
                        switch (cont)
                        {
                            case 1:
                                if (x1 > dis)
                                {
                                    MessageBox.Show("has terminado la carrera con " + x1);
                                    podio.Show();
                                }
                                else
                                {
                                    x1 = x1 + (dado * 100);
                                    label2.Text = Convert.ToString(x1);
                                    MessageBox.Show("turno del jugador 2");
                                    cont++;
                                }
                                break;
                            case 2:
                                if (x2 > dis)
                                {
                                    MessageBox.Show("has terminado la carrera con " + x2);
                                    podio.Show();
                                }
                                else
                                {
                                    x2 = x2 + (dado * 100);
                                    label3.Text = Convert.ToString(x2);
                                    MessageBox.Show("turno del jugador 3");
                                    cont++;
                                }
                                break;
                            case 3:
                                if (x3 > dis)
                                {
                                    MessageBox.Show("has terminado la carrera con " + x3);
                                    podio.Show();
                                }
                                else
                                {
                                    x3 = x3 + (dado * 100);
                                    label4.Text = Convert.ToString(x3);
                                    MessageBox.Show("turno del jugador 4");
                                    cont++;
                                }
                                break;
                            case 4:
                                if (x4 > dis)
                                {
                                    MessageBox.Show("has terminado la carrera con " + x4);
                                    podio.Show();
                                }
                                else
                                {
                                    x4 = x4 + (dado * 100);
                                    label5.Text = Convert.ToString(x4);
                                    MessageBox.Show("turno del jugador 5");
                                    cont++;
                                }
                                break;
                            case 5:
                                if (x4 > dis)
                                {
                                    MessageBox.Show("has terminado la carrera con " + x5);
                                    podio.Show();
                                }
                                else
                                {
                                    x5 = x5 + (dado * 100);
                                    label7.Text = Convert.ToString(x5);
                                    MessageBox.Show("turno del jugador 1");
                                    cont = 1;
                                }
                                break;
                        }
                        break;
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 reglas_de_juego = new Form2();
            reglas_de_juego.Show(); 
            
        }

        public class jugadores
        {
            public int id = cont ++; 

            string carro;
            public int metros_recorridos(int x)
            {
                return x;
            }
            public int kilometros_recorridos(int x)
            {
                return x / 1000;
            }
            
        }

        public class carro
        {
            string carril;
            string pista;
        }
    }
}

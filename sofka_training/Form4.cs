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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.jugadores jugador = new Form1.jugadores();
            StreamWriter escribir = new StreamWriter(@"C:\Users\RYZEN CYCLON\Documents\sofka\sofka_training\sofka_training\BD.txt", true);
            try
            {
                escribir.WriteLine("id del jugador" + jugador.id);
                escribir.WriteLine("kilometros recorridos" + jugador.kilometros_recorridos(Form1.x1));
                escribir.WriteLine("metros recorridos" + jugador.metros_recorridos(Form1.x1));
                escribir.WriteLine("\n");
            }
            catch
            {
                MessageBox.Show("Error");
            }
            escribir.Close();

            StreamReader leer = new StreamReader(@"C:\Users\RYZEN CYCLON\Documents\sofka\sofka_training\sofka_training\BD.txt");
            string linea;
            try
            {
                linea = leer.ReadLine();
                while (linea != null)
                {
                    richTextBox1.AppendText(linea + "\n");
                    linea = leer.ReadLine();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}

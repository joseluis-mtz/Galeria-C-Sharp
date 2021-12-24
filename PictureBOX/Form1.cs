using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBOX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Se pone el intervalo del TIMER 
            timer1.Interval = 300;
            // Se activa el control
            timer1.Enabled = true;
            // Se inicia el temporizador
            timer1.Start();
        }
        // Contador para ver las imagenes
        int contador = 0;

        // Evento de paso del temporizador
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Cuando el contador lleve 100 se mostrara la imagen 1, cuando lleve 150 la 2
            // y así sucesivamente....
            if (contador == 100)
                pictureBox1.Image = Properties.Resources._1;
            if (contador == 150)
                pictureBox1.Image = Properties.Resources._2;
            if (contador == 200)
                pictureBox1.Image = Properties.Resources._3;
            if (contador == 250)
                pictureBox1.Image = Properties.Resources._4;
            // Se reinicia la primer imagen
            if (contador == 300)
            {
                // Se muestra la primer imagen
                pictureBox1.Image = Properties.Resources._1;
                // Se vacia el contador para que vuelva a iniciar de 0 e ir incrementando
                contador = 0;
            }
            // Incremento del contador para que tome valores entre cada intervalo del TIMER
            contador += 50;
        }
    }
}

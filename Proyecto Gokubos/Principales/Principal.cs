using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Proyecto_Gokubos
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        SoundPlayer Player;
        private void Principal_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Player = new SoundPlayer(Proyecto_Gokubos.Properties.Resources.SCOUTER);
            Player.Play();
            Principiante Acceso = new Principiante();
            Acceso.Show();
            this.Dispose();
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Player = new SoundPlayer(Proyecto_Gokubos.Properties.Resources.SCOUTER);
            Player.Play();
            Cronometro Acceso = new Cronometro();
            Acceso.Show();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Player = new SoundPlayer(Proyecto_Gokubos.Properties.Resources.SCOUTER);
            Player.Play();
            Intermedio Acceso = new Intermedio();
            Acceso.Show();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Player = new SoundPlayer(Proyecto_Gokubos.Properties.Resources.SCOUTER);
            Player.Play();
            Avanzado Acceso = new Avanzado();
            Acceso.Show();
            this.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Player = new SoundPlayer(Proyecto_Gokubos.Properties.Resources.SCOUTER);
            Player.Play();
            Algoritmos Acceso = new Algoritmos();
            Acceso.Show();
            this.Dispose();
        }
    }
}

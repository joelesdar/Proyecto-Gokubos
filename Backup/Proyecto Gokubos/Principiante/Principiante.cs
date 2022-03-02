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
    public partial class Principiante : Form
    {
        public Principiante()
        {
            InitializeComponent();
        }
        SoundPlayer Player;
        private void Principiante_FormClosed(object sender, FormClosedEventArgs e)
        {

            Principal Acceso = new Principal();
            Acceso.Show();
            this.Dispose();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Player = new SoundPlayer(Proyecto_Gokubos.Properties.Resources.SCOUTER);
            Player.Play();
            Hola_soy_Goku Acceso = new Hola_soy_Goku();
            Acceso.Show();
            this.Dispose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Player = new SoundPlayer(Proyecto_Gokubos.Properties.Resources.SCOUTER);
            Player.Play();
            Introduccion_Cruz_Superior_P Acceso = new Introduccion_Cruz_Superior_P();
            Acceso.Show();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Player = new SoundPlayer(Proyecto_Gokubos.Properties.Resources.SCOUTER);
            Player.Play();
            La_Cruz Acceso = new La_Cruz();
            Acceso.Show();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Player = new SoundPlayer(Proyecto_Gokubos.Properties.Resources.SCOUTER);
            Player.Play();
            Introduccion_Corona Acceso = new Introduccion_Corona();
            Acceso.Show();
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Player = new SoundPlayer(Proyecto_Gokubos.Properties.Resources.SCOUTER);
            Player.Play();
            Introduccion_Doble_Corona Acceso = new Introduccion_Doble_Corona();
            Acceso.Show();
            this.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Player = new SoundPlayer(Proyecto_Gokubos.Properties.Resources.SCOUTER);
            Player.Play();
            Introduccion_Cruz_superior_O Acceso = new Introduccion_Cruz_superior_O();
            Acceso.Show();
            this.Dispose();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Player = new SoundPlayer(Proyecto_Gokubos.Properties.Resources.SCOUTER);
            Player.Play();
            Introduccion_Esquinas_P Acceso = new Introduccion_Esquinas_P();
            Acceso.Show();
            this.Dispose();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Player = new SoundPlayer(Proyecto_Gokubos.Properties.Resources.SCOUTER);
            Player.Play();
            Introduccion_Esquinas_O Acceso = new Introduccion_Esquinas_O();
            Acceso.Show();
            this.Dispose();
        }
    }
}

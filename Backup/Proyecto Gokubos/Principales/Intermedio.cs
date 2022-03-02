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
    public partial class Intermedio : Form
    {
        public Intermedio()
        {
            InitializeComponent();
        }
        SoundPlayer Player;

        private void Intermedio_Load(object sender, EventArgs e)
        {

        }

        private void Intermedio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Principal Acceso = new Principal();
            Acceso.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Player = new SoundPlayer(Proyecto_Gokubos.Properties.Resources.SCOUTER);
            Player.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Player = new SoundPlayer(Proyecto_Gokubos.Properties.Resources.SCOUTER);
            Player.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Player = new SoundPlayer(Proyecto_Gokubos.Properties.Resources.SCOUTER);
            Player.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Player = new SoundPlayer(Proyecto_Gokubos.Properties.Resources.SCOUTER);
            Player.Play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Player = new SoundPlayer(Proyecto_Gokubos.Properties.Resources.SCOUTER);
            Player.Play();
        }
    }
}

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
    public partial class Hola_soy_Goku : Form
    {
        public Hola_soy_Goku()
        {
            InitializeComponent();
        }
        SoundPlayer Player;
        private void button1_Click(object sender, EventArgs e)
        {
            Player = new SoundPlayer(Proyecto_Gokubos.Properties.Resources.SCOUTER);
            Player.Play();
            El_Cubo_Rubik Acceso = new El_Cubo_Rubik();
            Acceso.Show();
            this.Dispose();
        }

        private void Hola_soy_Goku_FormClosed(object sender, FormClosedEventArgs e)
        {
            Principiante Acceso = new Principiante();
            Acceso.Show();
            this.Dispose();
        }
    }
}

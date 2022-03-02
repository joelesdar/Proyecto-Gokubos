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
    public partial class El_Cubo_Rubik : Form
    {
        public El_Cubo_Rubik()
        {
            InitializeComponent();
        }
        SoundPlayer Player;
        private void El_Cubo_Rubik_FormClosed(object sender, FormClosedEventArgs e)
        {
            Principiante Acceso = new Principiante();
            Acceso.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Player = new SoundPlayer(Proyecto_Gokubos.Properties.Resources.SCOUTER);
            Player.Play();
            Partes_del_cubo Acceso = new Partes_del_cubo();
            Acceso.Show();
            this.Dispose();
        }

        private void Boton_ingresar_Click(object sender, EventArgs e)
        {
            Player = new SoundPlayer(Proyecto_Gokubos.Properties.Resources.SCOUTER);
            Player.Play();
            Hola_soy_Goku Acceso = new Hola_soy_Goku();
            Acceso.Show();
            this.Dispose();
        }
    }
}

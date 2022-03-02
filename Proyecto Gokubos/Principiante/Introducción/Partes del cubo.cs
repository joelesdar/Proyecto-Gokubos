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
    public partial class Partes_del_cubo : Form
    {
        public Partes_del_cubo()
        {
            InitializeComponent();
        }
        SoundPlayer Player;
        private void Partes_del_cubo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Player = new SoundPlayer(@"F:\Archivos\Cubos\Dragon ball T\draon ball\Nueva carpeta\scouter.wav");
            Player.Play();
            Principiante Acceso = new Principiante();
            Acceso.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Player = new SoundPlayer(Proyecto_Gokubos.Properties.Resources.SCOUTER);
            Player.Play();
            Notacion Acceso = new Notacion();
            Acceso.Show();
            this.Dispose();
        }

        private void Boton_ingresar_Click(object sender, EventArgs e)
        {
            Player = new SoundPlayer(Proyecto_Gokubos.Properties.Resources.SCOUTER);
            Player.Play();
            El_Cubo_Rubik Acceso = new El_Cubo_Rubik();
            Acceso.Show();
            this.Dispose();
        }
    }
}

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
    public partial class Beneficios : Form
    {
        public Beneficios()
        {
            InitializeComponent();
        }
        SoundPlayer Player;
        private void Beneficios_FormClosed(object sender, FormClosedEventArgs e)
        {
            Principiante Acceso = new Principiante();
            Acceso.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Player = new SoundPlayer(Proyecto_Gokubos.Properties.Resources.SCOUTER);
            Player.Play();
            Consejos Acceso = new Consejos();
            Acceso.Show();
            this.Dispose();
        }

        private void Boton_ingresar_Click(object sender, EventArgs e)
        {
            Player = new SoundPlayer(Proyecto_Gokubos.Properties.Resources.SCOUTER);
            Player.Play();
            Notacion Acceso = new Notacion();
            Acceso.Show();
            this.Dispose();
        }
    }
}

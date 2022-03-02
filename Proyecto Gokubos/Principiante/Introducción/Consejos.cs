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
    public partial class Consejos : Form
    {
        public Consejos()
        {
            InitializeComponent();
        }
        SoundPlayer Player;
        private void Consejos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Principiante Acceso = new Principiante();
            Acceso.Show();
            this.Dispose();
        }

        private void Boton_ingresar_Click(object sender, EventArgs e)
        {
            Player = new SoundPlayer(Proyecto_Gokubos.Properties.Resources.SCOUTER);
            Player.Play();
            Beneficios Acceso = new Beneficios();
            Acceso.Show();
            this.Dispose();
        }
    }
}

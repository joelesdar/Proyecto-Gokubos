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
    public partial class Algoritmos : Form
    {
        public Algoritmos()
        {
            InitializeComponent();
        }
        SoundPlayer Player;
        private void Boton_ingresar_Click(object sender, EventArgs e)
        {
            Player = new SoundPlayer(Proyecto_Gokubos.Properties.Resources.SCOUTER);
            Player.Play();
            Principal Acceso = new Principal();
            Acceso.Show();
            this.Dispose();
        }

        private void Algoritmos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Principal Acceso = new Principal();
            Acceso.Show();
            this.Dispose();
        }
    }
}

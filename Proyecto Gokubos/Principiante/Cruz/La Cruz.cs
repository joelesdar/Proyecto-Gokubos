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
    public partial class La_Cruz : Form
    {
        public La_Cruz()
        {
            InitializeComponent();
        }
        SoundPlayer Player;
        private void Introduccion_cruz_FormClosed(object sender, FormClosedEventArgs e)
        {
            Principiante Acceso = new Principiante();
            Acceso.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Player = new SoundPlayer(Proyecto_Gokubos.Properties.Resources.SCOUTER);
            Player.Play();
            Introduccion_Cruz Acceso = new Introduccion_Cruz();
            Acceso.Show();
            this.Dispose();
        }
    }
}

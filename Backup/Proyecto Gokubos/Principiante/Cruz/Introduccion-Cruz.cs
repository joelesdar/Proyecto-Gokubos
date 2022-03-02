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
    public partial class Introduccion_Cruz : Form
    {
        public Introduccion_Cruz()
        {
            InitializeComponent();
        }
        SoundPlayer Player;
        private void button1_Click(object sender, EventArgs e)
        {
            Player = new SoundPlayer(@"F:\Archivos\Cubos\Dragon ball T\draon ball\Nueva carpeta\scouter.wav");
            Player.Play();
            Cruz_caso_1 Acceso = new Cruz_caso_1();
            Acceso.Show();
            this.Dispose();
        }

        private void Boton_ingresar_Click(object sender, EventArgs e)
        {
            Player = new SoundPlayer(@"F:\Archivos\Cubos\Dragon ball T\draon ball\Nueva carpeta\scouter.wav");
            Player.Play();
            La_Cruz Acceso = new La_Cruz();
            Acceso.Show();
            this.Dispose();
        }

        private void Introduccion_Cruz_FormClosed(object sender, FormClosedEventArgs e)
        {
            Principiante Acceso = new Principiante();
            Acceso.Show();
            this.Dispose();
        }
    }
}

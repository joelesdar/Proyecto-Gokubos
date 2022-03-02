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
    public partial class Recuperacion : Form
    {
        public Recuperacion()
        {
            InitializeComponent();
        }
        SoundPlayer Player;
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Boton_cancelar_Click(object sender, EventArgs e)
        {
            Player = new SoundPlayer(Proyecto_Gokubos.Properties.Resources.SCOUTER);
            Player.Play();
            Login Acceso = new Login();
            Acceso.Show();
            this.Dispose();
        }

        private void Boton_ingresar_Click(object sender, EventArgs e)
        {
            Player = new SoundPlayer(Proyecto_Gokubos.Properties.Resources.SCOUTER);
            Player.Play();
            MessageBox.Show(textBox1.Text + "\n" + "Se ha enviado un mensaje al correo: " + textBox2.Text + "\n" + "Para recuperar tu contraseña");
            Login Acceso = new Login();
            Acceso.Show();
            this.Dispose();
        }

        private void Recuperacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login Acceso = new Login();
            Acceso.Show();
            this.Dispose();
        }
    }
}

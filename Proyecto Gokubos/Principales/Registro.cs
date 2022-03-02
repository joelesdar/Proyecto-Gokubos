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
    public partial class Registro : Form
    {
        Validacion v = new Validacion();
        public Registro()
        {
            InitializeComponent();
        }
        SoundPlayer Player;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Boton_ingresar_Click(object sender, EventArgs e)
        {
            Player = new SoundPlayer(Proyecto_Gokubos.Properties.Resources.SCOUTER);
            Player.Play();
            MessageBox.Show("El usuario: " + textBox3.Text + "\n" + "Ha sido registrado");
            Login Acceso = new Login();
            Acceso.Show();
            this.Dispose();
        }

        private void Boton_cancelar_Click(object sender, EventArgs e)
        {
            Player = new SoundPlayer(Proyecto_Gokubos.Properties.Resources.SCOUTER);
            Player.Play();
            Login Acceso = new Login();
            Acceso.Show();
            this.Dispose();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.letras(e);
        }

        private void Registro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login Acceso = new Login();
            Acceso.Show();
            this.Dispose();
        }
    }
}

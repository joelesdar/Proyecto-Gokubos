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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SoundPlayer Player;
        private void Boton_ingresar_Click(object sender, EventArgs e)
        {
            Player = new SoundPlayer(Proyecto_Gokubos.Properties.Resources.SCOUTER);
            Player.Play();
            if ((textBox1.Text == "Goku") && (textBox2.Text == "123456789"))
            {
                MessageBox.Show("Bienvenido Amo:" + "\n" + textBox1.Text);
                Cargando Acceso = new Cargando ();
                Acceso.Show();
                this.Hide();
            }
            else if ((textBox1.Text == "Vegeta") && (textBox2.Text == "123456789"))
            {
                Player = new SoundPlayer(Proyecto_Gokubos.Properties.Resources.SCOUTER);
                Player.Play();
                MessageBox.Show("Bienvenido Principe:" + "\n" + textBox1.Text + "-Sama");
                Cargando Acceso = new Cargando();
                Acceso.Show();
                this.Hide();
            }
            else if ((textBox1.Text == "Gohan") && (textBox2.Text == "123456789"))
            {
                Player = new SoundPlayer(Proyecto_Gokubos.Properties.Resources.SCOUTER);
                Player.Play();
                MessageBox.Show("Bienvenido Aprendiz:" + "\n" + textBox1.Text);
                Cargando Acceso = new Cargando();
                Acceso.Show();
                this.Hide();
            }
            else if ((textBox1.Text == "Goten") && (textBox2.Text == "123456789"))
            {
                Player = new SoundPlayer(Proyecto_Gokubos.Properties.Resources.SCOUTER);
                Player.Play();
                MessageBox.Show("Bienvenido Aprendiz:" + "\n" + textBox1.Text);
                Cargando Acceso = new Cargando();
                Acceso.Show();
                this.Hide();
            }
            else if ((textBox1.Text == "Trunks") && (textBox2.Text == "123456789"))
            {
                Player = new SoundPlayer(Proyecto_Gokubos.Properties.Resources.SCOUTER);
                Player.Play();
                MessageBox.Show("Bienvenido Aprendiz:" + "\n" + textBox1.Text);
                Cargando Acceso = new Cargando();
                Acceso.Show();
                this.Hide();
            }
            else
            {
                Player = new SoundPlayer(Proyecto_Gokubos.Properties.Resources.SCOUTER);
                Player.Play();
                MessageBox.Show("Usuario y/o contraseña no válidos. Por favor, inténtalo de nuevo");
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Boton_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Player = new SoundPlayer(Proyecto_Gokubos.Properties.Resources.SCOUTER);
            Player.Play();
            Recuperacion Acceso = new Recuperacion();
            Acceso.Show();
            this.Hide();
        }

        private void Registrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Player = new SoundPlayer(Proyecto_Gokubos.Properties.Resources.SCOUTER);
            Player.Play();
            Registro Acceso = new Registro();
            Acceso.Show();
            this.Hide();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if ((textBox1.Text == "Goku") && (textBox2.Text == "123456789"))
                {
                    Player = new SoundPlayer(Proyecto_Gokubos.Properties.Resources.SCOUTER);
                    Player.Play();
                    MessageBox.Show("Bienvenido Amo:" + "\n" + textBox1.Text);
                    Cargando Acceso = new Cargando();
                    Acceso.Show();
                    this.Hide();
                }
                else if ((textBox1.Text == "Vegeta") && (textBox2.Text == "123456789"))
                {
                    Player = new SoundPlayer(Proyecto_Gokubos.Properties.Resources.SCOUTER);
                    Player.Play();
                    MessageBox.Show("Bienvenido Principe:" + "\n" + textBox1.Text + "-Sama");
                    Cargando Acceso = new Cargando();
                    Acceso.Show();
                    this.Hide();
                }
                else if ((textBox1.Text == "Gohan") && (textBox2.Text == "123456789"))
                {
                    Player = new SoundPlayer(Proyecto_Gokubos.Properties.Resources.SCOUTER);
                    Player.Play();
                    MessageBox.Show("Bienvenido Aprendiz:" + "\n" + textBox1.Text);
                    Cargando Acceso = new Cargando();
                    Acceso.Show();
                    this.Hide();
                }
                else if ((textBox1.Text == "Goten") && (textBox2.Text == "123456789"))
                {
                    Player = new SoundPlayer(Proyecto_Gokubos.Properties.Resources.SCOUTER);
                    Player.Play();
                    MessageBox.Show("Bienvenido Aprendiz:" + "\n" + textBox1.Text);
                    Cargando Acceso = new Cargando();
                    Acceso.Show();
                    this.Hide();
                }
                else if ((textBox1.Text == "Trunks") && (textBox2.Text == "123456789"))
                {
                    Player = new SoundPlayer(Proyecto_Gokubos.Properties.Resources.SCOUTER);
                    Player.Play();
                    MessageBox.Show("Bienvenido Aprendiz:" + "\n" + textBox1.Text);
                    Cargando Acceso = new Cargando();
                    Acceso.Show();
                    this.Hide();
                }
                else
                {
                    Player = new SoundPlayer(Proyecto_Gokubos.Properties.Resources.SCOUTER);
                    Player.Play();
                    MessageBox.Show("Usuario y/o contraseña no válidos. Por favor, inténtalo de nuevo");
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

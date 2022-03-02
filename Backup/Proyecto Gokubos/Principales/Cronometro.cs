using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;

namespace Proyecto_Gokubos
{
    public partial class Cronometro : Form
    {
        Stopwatch reloj = new Stopwatch();

        public Cronometro()
        {
            InitializeComponent();
        }
        SoundPlayer Player;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int var = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            Player = new SoundPlayer(Proyecto_Gokubos.Properties.Resources.SCOUTER);
            Player.Play();
            if (reloj.IsRunning)
            {
                reloj.Stop();
                button1.Text = "Reiniciar";
                listBox1.Items.Add(var.ToString() + "- " + label1.Text);
                var++;
            }
            else
            {
                reloj.Start();
                button1.Text = "Parar";
            }

            if (button1.Text == "Parar" && label1.Text != "0:00:00.00")
            {
                button1.Text = "Iniciar";
                label1.Text = "0:00:00.00";
                reloj.Reset();
            }
            if (reloj.IsRunning)
            {

                Player = new SoundPlayer(@"F:\Archivos\Cubos\Dragon ball T\draon ball\Nueva carpeta\SCOUTER3.WAV");
                Player.PlayLooping();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (reloj.IsRunning)
            {
                TimeSpan tiempo = reloj.Elapsed;
                this.label1.Text = String.Format("{0:0}:{1:00}:{2:00}:{3:00}", tiempo.Hours, tiempo.Minutes, tiempo.Seconds, tiempo.Milliseconds / 10);
            }
        }

        private void Cronometro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Principal Acceso = new Principal();
            Acceso.Show();
            this.Dispose();
            if (reloj.IsRunning)
            {
                Player.Stop();
            }
        }
    }
}

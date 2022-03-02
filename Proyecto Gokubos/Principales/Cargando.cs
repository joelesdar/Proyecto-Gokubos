using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Gokubos
{
    public partial class Cargando : Form
    {
        Timer t = new Timer();
        double pbUnit;
        int pbAncho, pbAlto, pbCompleto;
        Bitmap bmp;
        Graphics g;

        public Cargando()
        {
            InitializeComponent();
        }
        
        private void splash_Load(object sender, EventArgs e)
        {
            pbAncho = picboxPB.Width;
            pbAlto = picboxPB.Height;
            pbUnit = pbAncho / 100.0;
            pbCompleto = 0;
            bmp = new Bitmap(pbAncho, pbAlto);
            t.Interval = 15;
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
            label1.Parent = pictureBox1;
        }
        private void t_Tick(object sender, EventArgs e)
        {
            g = Graphics.FromImage(bmp);
            g.Clear(Color.LightSkyBlue);
            g.FillRectangle(Brushes.CornflowerBlue, new Rectangle(0,0, (int)(pbCompleto * pbUnit), pbAncho));
            picboxPB.Image = bmp;
            pbCompleto++;
            if (pbCompleto > 100)
            {
                g.Dispose();
                t.Stop();
            }
        }
        public void fn_prbar_()
        {
            progressBar1.Increment(1);
            label1.Text = "Cargando " + progressBar1.Value.ToString() + "%";
            if (progressBar1.Value == progressBar1.Maximum)
            {
             timer1.Stop();
             Principal Acceso = new Principal();
             Acceso.Show();
             this.Dispose();
            }
    }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fn_prbar_();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void picboxPB_Click(object sender, EventArgs e)
        {

        }

        private void Cargando_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
}
}

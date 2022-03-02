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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fn_prbar_();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
        }
        public void fn_prbar_()
        {
            progressBar1.Increment(1) ;
            label1.Text = progressBar1.Value.ToString () + "%";
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                this.Hide();
                Principal ff = new Principal();
                ff.Show();
                
              }   
                
          
    }
}
}

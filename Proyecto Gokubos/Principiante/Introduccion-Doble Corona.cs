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
    public partial class Introduccion_Doble_Corona : Form
    {
        public Introduccion_Doble_Corona()
        {
            InitializeComponent();
        }

        private void Introduccion_Doble_Corona_FormClosed(object sender, FormClosedEventArgs e)
        {
            Principiante Acceso = new Principiante();
            Acceso.Show();
            this.Dispose();
        }
    }
}

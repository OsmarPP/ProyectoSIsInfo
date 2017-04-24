using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPapeletaPago
{
    public partial class FormOlvideContraseña : Form
    {
        public FormOlvideContraseña()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCambiarContraseña CambiarCOntraseña = new FormCambiarContraseña();
            CambiarCOntraseña.ShowDialog();
        }
    }
}

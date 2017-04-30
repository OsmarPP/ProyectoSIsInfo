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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*private void button3_Click(object sender, EventArgs e)
        {
            //FormCodigo Codigo = new FormCodigo();
           // Codigo.ShowDialog();
        }*/

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            //FormRegistroNuevoUsuario NuevoUsuario = new FormRegistroNuevoUsuario();
            //NuevoUsuario.ShowDialog();
            FormRegistroNuevoEmpleado register = new FormRegistroNuevoEmpleado();
            register.ShowDialog();
        }

        private void buttonOlvideContraseña_Click(object sender, EventArgs e)
        {
            FormOlvideContraseña OlvideContraseña = new FormOlvideContraseña();
            OlvideContraseña.ShowDialog();
        }

        private void buttonSesion_Click(object sender, EventArgs e)
        {
            FormAdministrador Admi = new FormAdministrador();
            Admi.ShowDialog();
        }
    }
}

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
        DateTime fec = DateTime.Now;
        ConectarFecha ft = new ConectarFecha();
        public Form1()
        {
            InitializeComponent();
        }

        /*private void button3_Click(object sender, EventArgs e)
        {
            //FormCodigo Codigo = new FormCodigo();
           // Codigo.ShowDialog();
        }*/

        

        private void button1_Click(object sender, EventArgs e)
        {
            FormNuevoEmpleado nuevo = new FormNuevoEmpleado();
            nuevo.Show();
            //ft.InsertarFecha(fec);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormVistaAdministrador admi = new FormVistaAdministrador();
            admi.ShowDialog();
        }

        private void buttonSesion_Click(object sender, EventArgs e)
        {
            FormVistaAdministrador admi = new FormVistaAdministrador();
            admi.ShowDialog();
        }
    }
}

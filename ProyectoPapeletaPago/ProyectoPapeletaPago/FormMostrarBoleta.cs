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
    public partial class FormMostrarBoleta : Form
    {

        MostrarBoleta boleta = new MostrarBoleta();

        public FormMostrarBoleta()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            

            if (boleta.verSiExiste(Convert.ToInt32(textBoxCi.Text), Convert.ToString(textBoxMes.Text), Convert.ToInt32(textBoxAnio.Text) ) > 0)
            {


                FormVistaBoleta vista = new FormVistaBoleta();
                vista.Show();
            
            }









        }
    }
}

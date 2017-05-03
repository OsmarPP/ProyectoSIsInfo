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
    public partial class FormVistaAdministrador : Form
    {
        public FormVistaAdministrador()
        {
            InitializeComponent();
        }

        private void buttonGestionarPago_Click(object sender, EventArgs e)
        {
            FormGestionarPago gp = new FormGestionarPago();
            gp.ShowDialog();
        }

        private void buttonGestionEMpleado_Click(object sender, EventArgs e)
        {
            FormNuevoEmpleado newEmploye = new FormNuevoEmpleado();
            newEmploye.ShowDialog();
        }
    }
}

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
    public partial class FormRegistroUsuario : Form
    {
        RegistroDeNuevaCuenta cuenta = new RegistroDeNuevaCuenta();
        string vrol;
        int id;
        public FormRegistroUsuario()
        {
            InitializeComponent();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            if(textBoxContraseña.Text.Equals(textBoxConfContraseña.Text))
            {
                vrol = cuenta.RecuperarRol(textBoxCorreo.Text);
                id = cuenta.RecuperarCi(textBoxCorreo.Text);

               if( cuenta.InsertarNuevaCuenta(textBoxUsuario.Text,textBoxContraseña.Text,textBoxCorreo.Text,vrol)==1)
                {
                    cuenta.InsertCuentaFija(textBoxUsuario.Text, id, vrol);
                    textBoxUsuario.Text = " ";
                    textBoxCorreo.Text = " ";
                    textBoxContraseña.Text = " ";
                    textBoxConfContraseña.Text = " ";
                    MessageBox.Show("Exito en el registro de nueva cuenta");

                }
               else
                {
                    MessageBox.Show("no se puedo registra cuenta");
                }
            }
            else
            {
                MessageBox.Show("La contraseña tiene que ser iguales");
            }
        }
    }
}

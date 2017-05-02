using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ProyectoPapeletaPago
{
    public partial class FormNuevoEmpleado : Form
    {
        RegistroEmpleado registro = new RegistroEmpleado();
        RegistroEmpleadoFijo fijo = new RegistroEmpleadoFijo();
        RegistroEmpleadoHora hora = new RegistroEmpleadoHora();
        public FormNuevoEmpleado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if(textBoxCi.Text.Length>0 && textBoxNombre.Text.Length>0 && textBoxAPaterno.Text.Length>0 && textBoxAMaterno.Text.Length>0 && textBoxTelefono.Text.Length>0 && textBoxProfesion.Text.Length>0 && comboBoxRol.Text.Length>0 && textBoxSueldo.Text.Length>0 && textBoxCargo.Text.Length>0 && textBoxCorreo.Text.Length>0 && textBoxCuentaBancaria.Text.Length>0)
            {
                if(registro.VerificaSiYaEstaRegistrado(Convert.ToInt32(textBoxCi.Text))==0)
                {
                    int ci = Convert.ToInt32(textBoxCi.Text);
                    int fono = Convert.ToInt32(textBoxTelefono.Text);
                    float moneda = Convert.ToSingle(textBoxSueldo.Text);
                    string rol = comboBoxRol.SelectedItem.ToString();
                    int cuenta = Convert.ToInt32(textBoxCuentaBancaria.Text);
                    if (registro.InsertarNuevoEmpleado(ci, textBoxNombre.Text, textBoxAPaterno.Text, textBoxAMaterno.Text, fono, textBoxProfesion.Text, rol, moneda, textBoxCargo.Text, textBoxCorreo.Text) == 1)
                    {
                       
                        if(rol.Equals("fijo") || rol.Equals("administrador"))
                        {
                            if(fijo.InsertarNuevoEmpleadoFijo(ci, rol, moneda, textBoxCargo.Text, textBoxCargo.Text, cuenta)==1)
                            {
                                textBoxCi.Text = "";
                                textBoxNombre.Text = " ";
                                textBoxAPaterno.Text = " ";
                                textBoxAMaterno.Text = " ";
                                textBoxTelefono.Text = " ";
                                textBoxProfesion.Text = "";
                                comboBoxRol.Text = " ";
                                textBoxSueldo.Text = " ";
                                textBoxCargo.Text = " ";
                                textBoxCorreo.Text = " ";
                                textBoxCuentaBancaria.Text = " ";
                                
                        
                            }
                        }
                        else
                        {
                            if(rol.Equals("hora"))
                            {
                                if(hora.InsertarNuevoEmpleadoHora(ci, rol, moneda, textBoxCargo.Text, textBoxCargo.Text, cuenta)==1)
                                {
                                    textBoxCi.Text = "";
                                    textBoxNombre.Text = " ";
                                    textBoxAPaterno.Text = " ";
                                    textBoxAMaterno.Text = " ";
                                    textBoxTelefono.Text = " ";
                                    textBoxProfesion.Text = "";
                                    comboBoxRol.Text = " ";
                                    textBoxSueldo.Text = " ";
                                    textBoxCargo.Text = " ";
                                    textBoxCorreo.Text = " ";
                                    textBoxCuentaBancaria.Text = " ";
                                }
                            }
                        }
                       
                        MessageBox.Show("Se registro a un nuevo empleado");
                    }
                    else
                    {
                        MessageBox.Show("Fallo en el registro de nuevo empleado");
                    }
                }
                else
                {
                    MessageBox.Show("Empleado con el carnet    " + textBoxCi.Text + "  ya esta registrado");
                }
            }
            else
            {
                MessageBox.Show("Tiene que llenar el formulario");
            }

            
        }

        private void textBoxCi_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condicion que solo nos permite ingresar datos numericos
            if(char.IsDigit(e.KeyChar))
             {
                 e.Handled = false;
             }
            //condicion que nos permite utlizar el backspace
            else if(char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admite numeros","Validacion del campo de cedula de identidad", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void textBoxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condicion que solo nos permite ingresar datos numericos
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //condicion que nos permite utlizar el backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admite numeros", "Validacion del telefono del empleado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBoxSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condicion que solo nos permite ingresar datos numericos
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //condicion que nos permite utlizar el backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admite numeros", "Validacion del campo del sueldo de nuevo empleado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condicion que solo nos permite ingresar datos de tipo texto
            if(char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            //condicion que nos permite utlizar el backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //condicion que nos permite utilizar la tecla de esapcio
            else if(char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo admite letras", "Validacion del campo de nombre del nuevo empleado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBoxAPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condicion que solo nos permite ingresar datos de tipo texto
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            //condicion que nos permite utlizar el backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //condicion que nos permite utilizar la tecla de esapcio
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo admite letras", "Validacion del campo de apellido paterno del nuevo empleado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBoxAMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condicion que solo nos permite ingresar datos de tipo texto
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            //condicion que nos permite utlizar el backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //condicion que nos permite utilizar la tecla de esapcio
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo admite letras", "Validacion del campo de apellido materno del nuevo empleado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBoxProfesion_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condicion que solo nos permite ingresar datos de tipo texto
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            //condicion que nos permite utlizar el backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //condicion que nos permite utilizar la tecla de esapcio
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo admite letras", "Validacion del campo de profesion del nuevo empleado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBoxCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condicion que solo nos permite ingresar datos de tipo texto
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            //condicion que nos permite utlizar el backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //condicion que nos permite utilizar la tecla de esapcio
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo admite letras", "Validacion del campo de cargo del nuevo empleado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //textBoxCargo.CharacterCasing = CharacterCasing.Upper; //para mayuscula
                //textBoxCargo.CharacterCasing = CharacterCasing.Lower;//para minusculas
            }
        }

        //metodo para validar el emal ingresado
        public static bool ValidacionEmailEmpleado(string email)
        {
            bool res = false;
            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    res =  true;
                }
                else
                {
                    res = false;
                }
            }
            return res;
        }
        private void textBoxCorreo_Leave(object sender, EventArgs e)
        {
            //condicion que captura el emal
            if(ValidacionEmailEmpleado(textBoxCorreo.Text))
            {
            }
            else
            {
                MessageBox.Show("Direccion de correo electronico no es valido, el correo debe tener el formato: nombre@domicio.com,"+ "por favor introdusca un correo valido","validacion de correo electronico",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                textBoxCorreo.SelectAll();
                textBoxCorreo.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            registro.CerreConexion();
            fijo.CerraConexion();
            hora.CerrarConexion();
            this.Close();
        }

        private void buttonVistaPrevia_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("CI : " + textBoxCi.Text +"\n"+ " NOMBRE :  \n" + textBoxNombre.Text);
        }

        private void textBoxNumeroCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condicion que solo nos permite ingresar datos numericos
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //condicion que nos permite utlizar el backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admite numeros", "Validacion del Numero de cuenta del empleado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBoxCuentaBancaria_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condicion que solo nos permite ingresar datos numericos
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //condicion que nos permite utlizar el backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admite numeros", "Validacion del Numero de cuenta del empleado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

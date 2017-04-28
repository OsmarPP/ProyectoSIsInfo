using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoPapeletaPago
{
    class EmpleadoFijoHora
    {
        SqlConnection cm;
        SqlCommand cmdEmpleado;
        SqlCommand cmdEmpFijo;
        SqlCommand cmdEmpHora;
        SqlCommand cmdRegistroFijo;
        SqlCommand cmdRegistroHora;
        SqlDataReader dirEmpleado;
        SqlDataAdapter da;
        DataTable dt;
        private DateTime fecActual;
    

        public EmpleadoFijoHora()
        {
            fecActual = DateTime.Now;
            try
            {

                cm = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MatiasPF\Source\Repos\ProyectoSIsInfo\ProyectoPapeletaPago\ProyectoPapeletaPago\BDPago.mdf;Integrated Security=True");
                cm.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo en la conexion" + ex.ToString());
            }
        }

        public bool VerificarSiEsEmpleadoFIjo(string vrol)
        {
            bool res = false;
            if(vrol == "administrador")
            {
                res = true;
            }

            return res;
        }

        public string InsertarNuevoEmpleado(int vci,string vnom,string vapellidopaterno,string vapellidomaterno,int vtelefono,string vprofesion,string vrol,float vsueldo,string vcargo,string vcorreo)
        {
            int vestado;
            string salida = "se registro los datos correctamente";
            try
            {
                vestado = 1;
                cmdEmpleado = new SqlCommand("Insert into Empleado(ci,nombre,apellidopaterno,apellidomaterno,telefono,profesion,estado) values("+vci+",'"+vnom+"','"+vapellidopaterno+ "','"+vapellidomaterno+ "',"+vtelefono+ ",'"+vprofesion+ "','"+vcargo+ "','"+vcorreo+ "',"+vestado+")", cm);
                if(VerificarSiEsEmpleadoFIjo(vrol))
                {
                    
                    InsertarNuevoEmpleadoFijo(vci, vrol, vsueldo, vcargo, vcorreo, vestado);
                    InsertarNuevoRegistroFijo(vci, vci, vestado, vrol);
                }
                else
                {
                    InsertarNuevoEmpleadoHora(vci, vrol, vsueldo, vcargo, vcorreo, vestado);
                    InsertarNuevoRegistroHora(vci, vci, vestado, vrol);
                }
                cmdEmpleado.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                salida = "Error al registra de los datos" + ex.ToString();
            }
            return salida;
        }

        public string InsertarNuevoEmpleadoFijo(int vcodigo,string vrol,float vsalario,string vcargo,string vcorreo,int vestado)
        {
            string salida = "se registro los datos correctamente";
            try
            {
                cmdEmpFijo = new SqlCommand("Insert into EmpFijo(codigo,rol,sueldo,cargo,correo,estado)value("+vcodigo+ ",'"+vrol+ "',"+vsalario+ ",'"+vcargo+ "','"+vcorreo+ "',"+vestado+")", cm);
                cmdEmpFijo.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                salida = "Error al registro de los datos" + ex.ToString();
            }
            return salida;
        }

        public string InsertarNuevoEmpleadoHora(int vcodigo, string vrol, float vsalario, string vcargo, string vcorreo, int vestado)
        {
            string salida = "se registro los datos correctamente";
            try
            {
                cmdEmpHora = new SqlCommand("Insert into EmpHora(codigo,rol,sueldo,cargo,correo,estado)value(" + vcodigo + ",'" + vrol + "'," + vsalario + ",'" + vcargo + "','" + vcorreo + "'," + vestado + ")", cm);
                cmdEmpHora.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "Error al registro de los datos" + ex.ToString();
            }
            return salida;
        }

        public void InsertarNuevoRegistroFijo(int vci,int vcodigo,int vestado,string vrol)
        {
            try
            {
                cmdRegistroFijo = new SqlCommand("Insert into RegistroFijo(fech,ci,codigo,rol,estado)value("+fecActual+ ","+vci+ ","+vcodigo+ ",'"+vrol+"'," + vestado+")", cm);
                cmdRegistroFijo.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error en la conexion" + ex.ToString());
            }
        }

        public void InsertarNuevoRegistroHora(int vci, int vcodigo, int vestado, string vrol)
        {
            try
            {
                cmdRegistroHora = new SqlCommand("Insert into RegistroHora(fech,ci,codigo,rol,estado)value(" + fecActual + "," + vci + "," + vcodigo + ",'" + vrol + "'," + vestado + ")", cm);
                cmdRegistroHora.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la conexion" + ex.ToString());
            }
        }

        public int VerificarEmpleadoExistente(int id)
        {
            int con = 0;
            try
            {
                cmdEmpleado = new SqlCommand("Select * From Empleado where ci="+id+"", cm);
                dirEmpleado = cmdEmpleado.ExecuteReader();
                while(dirEmpleado.Read())
                {
                    con++;
                }
                dirEmpleado.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error en la conexion" + ex.ToString());
            }
            return con;
        }
    }
}

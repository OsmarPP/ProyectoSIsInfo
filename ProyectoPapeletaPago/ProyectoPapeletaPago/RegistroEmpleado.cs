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
    class RegistroEmpleado
    {
        SqlConnection cm;
        SqlCommand cmd;
        SqlDataReader dir;

        SqlDataAdapter da;
        DataTable dt;
        
        public RegistroEmpleado()
        {
            try
            {
                cm = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MatiasPF\Source\Repos\ProyectoSIsInfo\ProyectoPapeletaPago\ProyectoPapeletaPago\BDPago.mdf;Integrated Security=True");
                cm.Open();
                //MessageBox.Show(fecactual.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show("Fallo en la conexion " + ex.ToString());
            }          
        }

        public int VerificaSiYaEstaRegistrado(int id)
        {
            int cont = 0;
            try
            {
                cmd = new SqlCommand("Select * From Empleado Where ci = "+id+"", cm);
                dir = cmd.ExecuteReader();
                while(dir.Read())
                {
                    cont++;
                }
                dir.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Fallo en la conexion" + ex.ToString());
            }
            return cont;
        }

        public int InsertarNuevoEmpleado(int vci,string nom,string paterno,string materno,int vfono,string vprofesion,string vrol,float vsueldo,string vcargo,string vcorreo)
        {
            int vestado = 1;
            int salida;
            try
            {
                cmd = new SqlCommand("Insert into Empleado(ci,nombre,apellidopaterno,apellidomaterno,telefono,profesion,estado,rol) values(" + vci + ",'" + nom + "','" + paterno + "','" + materno + "'," + vfono + ",'" + vprofesion + "'," + vestado + ",'"+vrol+"')", cm);
                cmd.ExecuteNonQuery();
                salida = 1;
               
            }
            catch(Exception ex)
            {
                MessageBox.Show("Fallo en el registro de nuevo empleado " + ex.ToString());
                salida = 0;
            }
            return salida;
        }

        public void MostraEmpleadoRegistrado(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select ci,nombre,apellidopaterno,apellidomaterno,telefono,profesion,rol From Empleado Where estado=" + 1+"", cm);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se puede mostra a los empleados" + ex.ToString());
            }
        }

        public void CerreConexion()
        {
            cm.Close();
        }
    }
}

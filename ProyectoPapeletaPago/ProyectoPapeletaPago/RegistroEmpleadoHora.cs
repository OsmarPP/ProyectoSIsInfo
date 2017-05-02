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
    class RegistroEmpleadoHora
    {
        SqlConnection cm;
        SqlCommand cmd;

        public RegistroEmpleadoHora()
        {
            try
            {
                cm = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MatiasPF\Source\Repos\ProyectoSIsInfo\ProyectoPapeletaPago\ProyectoPapeletaPago\BDPago.mdf;Integrated Security=True");
                cm.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Fallo con la conexion de la base de datos" + ex.ToString());
            }
        }

        public int InsertarNuevoEmpleadoHora(int vcodigo, string vrol, float vsueldo, string vcargo, string vcorreo, int cuenta)
        {
            int est = 1;
            int salida;
            try
            {
                cmd = new SqlCommand("Insert into EmpHora(codigo,rol,sueldo,cargo,correo,estado,numerobancario) values(" + vcodigo + ",'" + vrol + "'," + vsueldo + ",'" + vcargo + "','" + vcorreo + "'," + est + "," + cuenta + ")", cm);
                cmd.ExecuteNonQuery();
                salida = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo en la conexion al crear nuevo empleado hora" + ex.ToString());
                salida = 0;
            }
            return salida;
        }

        public void CerrarConexion()
        {
            cm.Close();
        }


    }
}

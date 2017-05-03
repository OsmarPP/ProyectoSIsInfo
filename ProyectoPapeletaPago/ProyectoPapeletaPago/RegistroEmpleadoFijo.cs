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
    class RegistroEmpleadoFijo
    {
        SqlConnection cm;
        SqlCommand cmd;

        DateTime fecactual = DateTime.Now;

        public RegistroEmpleadoFijo()
        {
            try
            {
                cm = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MatiasPF\Source\Repos\ProyectoSIsInfo\ProyectoPapeletaPago\ProyectoPapeletaPago\BDPago.mdf;Integrated Security=True");
                cm.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Fallo en la conexion" + ex.ToString());
            }
        }

        public int InsertarNuevoEmpleadoFijo(int vcodigo,string vrol,float vsueldo,string vcargo,string vcorreo,int cuenta)
        {
            int est = 1;
            int salida;
            try
            {
                //cmd = new SqlCommand("Insert into EmpFijo(codigo,rol,sueldo,cargo,correo,estado,numerobancario) values("+vcodigo+",'"+vrol+"',"+vsueldo+",'"+vcargo+"','"+vcorreo+"',"+ est +","+cuenta+")",cm);
                //cmd.ExecuteNonQuery();
                string query = "INSERT INTO EmpFijo (codigo,rol,sueldo,cargo,correo,estado,fecha,numerobancario) VALUES (@codigo,@rol,@sueldo,@cargo,@correo,@estado,@fecha,@numerobancario)";
                SqlCommand cmd = new SqlCommand(query, cm);
                
                cmd.Parameters.AddWithValue("@codigo", vcodigo);
                cmd.Parameters.AddWithValue("@rol", vrol);
                cmd.Parameters.AddWithValue("@sueldo", vsueldo);
                cmd.Parameters.AddWithValue("@cargo", vcargo);
                cmd.Parameters.AddWithValue("@correo", vcorreo);
                cmd.Parameters.AddWithValue("@estado", est);
                cmd.Parameters.AddWithValue("@fecha", fecactual);
                cmd.Parameters.AddWithValue("@numerobancario", cuenta);
                cmd.ExecuteNonQuery();
                salida = 1;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Fallo en la conexion al crear nuevo empleado fijo" + ex.ToString());
                salida = 0;
            }
            return salida;
        }

        public void CerraConexion()
        {
            cm.Close();
        }
    }
}

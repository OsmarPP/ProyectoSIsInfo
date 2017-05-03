using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace ProyectoPapeletaPago
{
    class RegistroUsuario
    {
        SqlConnection cm;
        SqlCommand cmd;
        SqlCommand cmdfijo;
        SqlCommand cmdHora;
        SqlDataReader dir;
        SqlDataReader dirFijo;
        SqlDataReader dirHora;

        SqlDataAdapter da;
        DataTable dt;

        public RegistroUsuario()
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

        public int InsertarNuevoUsuario(string user,string password,string email)
        {
            //
            int vestado = 1;
            int salida;
            string vrol;
            string id;
            try
            {
                //sacamos el ci del usuario
               // cmd = new SqlCommand("Select fijo.codigo = "+id+" From Cuenta cuenta, EmpFijo fijo Where cuenta.correo='"+email+"' and cuenta.correo=fijo.correo", cm);
                

                /*cmd = new SqlCommand("Insert into Cuenta() values()", cm);
                cmd.ExecuteNonQuery();*/
                salida = 1;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Fallo al guardar los datos del nuevo usuario " + ex.ToString());
                salida = 0;
            }
            return salida;
        }
    }
}

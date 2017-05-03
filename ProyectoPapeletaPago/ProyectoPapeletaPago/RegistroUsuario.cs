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
    class RegistroUsuario
    {
        SqlConnection cm;
        SqlCommand cmd;
        SqlCommand cmd1;
        SqlCommand cmdCuenta;
        SqlDataReader dir;
        SqlDataReader dir1;
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

        /*public int RecuperarCI(string  email)
        {
            //string  iden;
            int id = 0;
            cmd = new SqlCommand("Select codigo From EmpFijo Where correo='" + email + "'", cm);
            //cm.Open();
            dir = cmd.ExecuteReader();
            if(dir.Read()==true)
            {
                id = Convert.ToInt32( dir["codigo"].ToString());
            }
            dir.Close();
            return id;
            
        }

        public string RecuperarRol(string email)
        {
            string res = " ";
            cmd1 = new SqlCommand("Select rol From EmpFijo Where correo='"+email+"'", cm);
            dir1 = cmd1.ExecuteReader();
            if(dir1.Read()==true)
            {
                res = Convert.ToString(dir1["rol"].ToString());
            }
            dir1.Close();
            return res;
            //cm.Close();
        }*/

        public int InsertarNuevoUsuario(string user,string password,string email)
        {
           // cm.Open();
            int res;
            int esta = 1;
            //int iden = RecuperarCI(email);
            //string rolen = RecuperarRol(email);
            string rolen = "administrador";
            
            try
            {
                cmdCuenta = new SqlCommand("Insert into Cuenta(usuario,contraseña,correo,rol,estado) values('"+user+"','"+password+"','"+email+"','"+rolen+"',"+esta+",)", cm);
                cmdCuenta.ExecuteNonQuery();
                res = 1;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Fallo de conexion " + ex.ToString());
                res = 0;
            }
            return res;

        }
    }
}

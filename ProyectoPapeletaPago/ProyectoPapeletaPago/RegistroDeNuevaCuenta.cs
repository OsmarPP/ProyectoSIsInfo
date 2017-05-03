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
    class RegistroDeNuevaCuenta
    {
        SqlConnection cm;
        SqlCommand cmd;
        SqlCommand cmdCI;
        SqlCommand cmdRol;
        SqlCommand cuentaFija;
        SqlCommand cuentaHora;
        DateTime fec = DateTime.Now;

        SqlDataReader dirCI;
        SqlDataReader dirRol;

        public RegistroDeNuevaCuenta()
        {
            try
            {
                cm = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MatiasPF\Source\Repos\ProyectoSIsInfo\ProyectoPapeletaPago\ProyectoPapeletaPago\BDPago.mdf;Integrated Security=True");
                cm.Open();
                //MessageBox.Show("Conectado");
            }
            catch(Exception ex)
            {
                MessageBox.Show("fallo en la conexion :  " + ex.ToString());
            }
        }

       public int InsertarNuevaCuenta(string vusuario,string password,string email,string vrol)
        {
            int est = 1;
            int res;
            //string vrol = "administrador";
            try
            {
                string query = "INSERT INTO Cuenta (usuario,contraseña,correo,rol,estado) VALUES (@usuario,@contraseña,@correo,@rol,@estado)";
                SqlCommand cmd = new SqlCommand(query, cm);

                cmd.Parameters.AddWithValue("@usuario", vusuario);
                cmd.Parameters.AddWithValue("@contraseña", password);
                cmd.Parameters.AddWithValue("@correo", email);
                cmd.Parameters.AddWithValue("@rol", vrol);
                cmd.Parameters.AddWithValue("@estado", est);
                
                cmd.ExecuteNonQuery();
                res = 1;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Fallo en intentar insertar nueva cuenta" + ex.ToString());
                res = 0;
            }
            return res;
        }

        public int InsertCuentaFija(string vuser,int id,string vrol)
        {
            int est = 1;
            int res;
            try
            {
                string query = "INSERT INTO CuentaFijo(fecha,usuario,codigo,rol,estado) VALUES(@fecha,@usuario,@codigo,@rol,@estado)";
                cuentaFija = new SqlCommand(query, cm);
                cuentaFija.Parameters.AddWithValue("@fecha", fec);
                cuentaFija.Parameters.AddWithValue("@usuario", vuser);
                cuentaFija.Parameters.AddWithValue("@codigo", id);
                cuentaFija.Parameters.AddWithValue("@rol", vrol);
                cuentaFija.Parameters.AddWithValue("@estado", est);

                cuentaFija.ExecuteNonQuery();

                res = 1;
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se creo cuenta de empleado fijo" + ex.ToString());
                res = 0;
            }
            return res;
        }

        /*public int InsertCuentaHoa()
        {

        }*/

        public int RecuperarCi(string email)
        {
            //string iden;
            int id = 0;
            cmdCI = new SqlCommand("Select codigo From EmpFijo Where correo='" + email + "'", cm);
            dirCI = cmdCI.ExecuteReader();
            if(dirCI.Read()==true)
            {
                id = Convert.ToInt32(dirCI["codigo"].ToString());
            }
            dirCI.Close();
            return id;
        }

        public string RecuperarRol(string email)
        {
            string res = " ";
            cmdRol = new SqlCommand("Select rol From EmpFijo Where correo = '"+email+"'", cm);
            dirRol = cmdRol.ExecuteReader();
            if(dirRol.Read()==true)
            {
                res = Convert.ToString(dirRol["rol"].ToString());
            }
            dirRol.Close();
            return res;
        }
       
    }
}

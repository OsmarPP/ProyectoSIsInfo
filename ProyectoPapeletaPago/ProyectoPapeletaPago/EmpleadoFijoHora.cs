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
        SqlCommand cmd;
        SqlDataReader dir;
        SqlDataAdapter da;
        DataTable dt;
    

        public EmpleadoFijoHora()
        {
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

        public bool VerificarSiEsEmpleadoFIjo(int vcodigo)
        {
            bool res = false;

            return res;
        }

        public void InsertarNuevoEmpleado(int vci,string vnom,string vapelli,string vfono,string vdir,string vrol,string vcargo,int vnumerobancario,string vcorreo,int estado,DateTime vfecinicio)
        {
           
        }

        public void InsertarNuevoEmpleadoFijo(int vci,int vcodigo,string cargo,int vnumeroCuenta,float vsalario,string vcorreo,int vestado)
        {

        }
    }
}

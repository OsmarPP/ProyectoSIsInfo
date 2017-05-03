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
    class MostrarBoleta
    {
        SqlConnection cm;
        SqlCommand cmd;
        SqlDataReader dir;

        public MostrarBoleta()
        {
            try
            {
                cm = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c:\Users\Robert\Source\Repos\ProyectoSIsInfo2\ProyectoPapeletaPago\ProyectoPapeletaPago\Boletas.mdf;Integrated Security=True");
                cm.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Fallo con la conexion de la base de datos" + ex.ToString());

            }
        }


        public int verSiExiste(int vci,string vmes,int vanio)
        {
            
            int cont = 0;
            try
            {
                cm.Open();
                cmd = new SqlCommand("Select * From Boleta Where ciEmpl = " + vci + " and mes ="+ vmes +" and anio = "+ vanio +"", cm);
                dir = cmd.ExecuteReader();
                while (dir.Read())
                {
                    cont++;
                }
                dir.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo en la conexion" + ex.ToString());
            }
            return cont;
                       
        }



        public int cargarBoleta()
        {
            int valor = 1;



            return valor;
        }




        public void CerreConexion()
        {
            cm.Close();
        }




    }
}

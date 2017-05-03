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
    class ConectarFecha
    {
        SqlConnection cm;
        SqlCommand cmd;

        public ConectarFecha()
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

        public void InsertarFecha(DateTime fec)
        {
            string nom = "Osmar";
            try
            {
               // cmd = new SqlCommand("Insert into Fecha(nombre) values('"+nom+"')", cm);
                string query = "INSERT INTO Fecha (fecha) VALUES (@fecha)";
                SqlCommand cmd1 = new SqlCommand(query, cm);
                //cmd.Parameters.AddWithValue("@param1", Convert.ToInt32(txtCodigo.Text));
                cmd1.Parameters.AddWithValue("@fecha",fec);
                cmd1.ExecuteNonQuery();
                //cmd.ExecuteNonQuery();

                cmd = new SqlCommand("Insert into Fecha(fecha,nombre) values('" + nom + "')", cm);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Fallo al insertar " + ex.ToString());
            }
        }
    }
}

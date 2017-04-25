﻿using System;
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
    class Conexion
    {
        SqlConnection cm;
        SqlCommand cmd;
        SqlDataReader dir;
        SqlDataAdapter da;
        DataTable dt;

        /*public Conexion()
        {
        }*/

        public bool AbrirConexion()
        {
            bool res = true;
            try
            {
                
                cm = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MatiasPF\Source\Repos\ProyectoSIsInfo\ProyectoPapeletaPago\ProyectoPapeletaPago\BDPago.mdf;Integrated Security=True");
                cm.Open();
            }
            catch (Exception ex)
            {
                res = false;
                MessageBox.Show("Fallo en la conexion" + ex.ToString());
            }

            return res;
        }

        public void CerraConexion()
        {
            cm.Close();
        }
    }
}
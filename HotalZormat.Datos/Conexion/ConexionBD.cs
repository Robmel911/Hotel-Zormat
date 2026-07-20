using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration; 

namespace HotalZormat.Datos.Conexion
{
    public class ConexionBD
    {
        private static readonly string connectionString =
        ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;

        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(connectionString);
        }

        public bool ProbarConexion() 
        {
            using (SqlConnection con = ObtenerConexion())
            {
                con.Open(); // si falla, lanza la excepción hacia arriba
                return con.State == System.Data.ConnectionState.Open;
            }
        }
    }
}



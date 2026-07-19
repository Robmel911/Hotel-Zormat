using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration; 

namespace HotalZormat.Datos.Conexion
{
    public static class ConexionBD
    {
        private static readonly string connectionString =
        ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;

        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(connectionString);
        }
    }
}



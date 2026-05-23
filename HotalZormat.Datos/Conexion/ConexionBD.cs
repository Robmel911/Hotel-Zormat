using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotalZormat.Datos.Conexion
{
    public static class ConexionBD
    {
        private static readonly string _cadena =
            "Data source=.;Initial Catalog=HotelZormatDB;Integrated Security=true;";
        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(_cadena);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotalZormat.Datos.Conexion;

namespace HotelZormat.Negocio
{
    public class Pruebas
    {
        public bool ProbarBD()
        {
            ConexionBD Conex = new ConexionBD();
            bool Exito = false;
            try 
            {
                Exito = Conex.ProbarConexion();
                if (Exito) return true;
            }
            catch { return false; }
            return false;
        }
    }
}

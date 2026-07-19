using HotelZormat.Negocio.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelZormat.Negocio.Servicios
{
    public class HabitacionService
    {
        private readonly List<Habitacion> _habitaciones;

        public HabitacionService() 
        {
            _habitaciones = new List<Habitacion>()
            {
                new Habitacion {Numero=101, Tipo="Sencilla", Piso=1, Estado="Disponible", Capacidad=1},
                new Habitacion {Numero=201, Tipo="Doble", Piso=2, Estado="Reservada", Capacidad=2},
                new Habitacion {Numero=301, Tipo="Sencilla", Piso=3, Estado="Disponible", Capacidad=1},
                new Habitacion {Numero=302, Tipo="Doble", Piso=3, Estado="Limpieza", Capacidad=2},
                new Habitacion {Numero=305, Tipo="Suite", Piso=3, Estado="Ocupada", Capacidad=4},
                new Habitacion {Numero=306, Tipo="Suite", Piso=3, Estado="Disponible", Capacidad=4},
                new Habitacion {Numero=401, Tipo="Suite", Piso=4, Estado="Reservada", Capacidad=4},
            };
        }
        
        public List<Habitacion> ObtenerTodas() 
        {
            return _habitaciones;       
        }

        public Habitacion Buscar(int Numero) 
        {
            foreach(var hab in _habitaciones)
            {
                if(hab.Numero == Numero) return hab;
            }
            return null;
        }

        public void Guardar(Habitacion habitacion) 
        {
            if (habitacion == null)
                throw new ArgumentNullException("Habitacion");

            //Regla del hotel: Ocupada no puede ir directo a disponible
            var existente = Buscar(habitacion.Numero);
            if(existente != null && 
                existente.Estado == "Ocupado" &&
                habitacion.Estado == "Disponible")
            {
                throw new InvalidOperationException(
                    "Debe pasar por Limpieza antes de liberar.");
            }
            if(existente != null) 
            {
                existente.Estado= habitacion.Estado;
                existente.Tipo= habitacion.Tipo;
            }
        }
    }
}

//Cedula 402-1035106-6
using HotelZormat.Datos;
using HotelZormat.Datos.Repositorios;
using HotelZormat.Modelo;
using HotelZormat.Negocio.Servicios;
using HotelZormat.Negocio.Exepciones;
using System;
using System.Collections.Generic;
using System.Data;

namespace HotelZormat.Negocio
{
    public class ReservaService
    {
        private ReservaRepository reservadatos = new ReservaRepository();
        private HabitacionRepository habitaciondatos = new HabitacionRepository();
        private EstadiaService estadiaService = new EstadiaService();
        private BitacoraService bitacoraService = new BitacoraService();
       

        public List<Reserva> ObtenerTodos()
        {
            DataTable tabla = reservadatos.ObtenerTodos();
            return MapearLista(tabla);
        }

        public Reserva ObtenerPorId(int idReserva)
        {
            DataTable tabla = reservadatos.ObtenerPorId(idReserva);
            if (tabla.Rows.Count == 0)
            {
                return null;
            }
            return Mapear(tabla.Rows[0]);
        }

        public List<Reserva> ObtenerProximas7Dias()
        {
            DataTable tabla = reservadatos.ObtenerProximas7Dias();
            return MapearLista(tabla);
        }

        // Crea la reserva calculando el monto segun temporada
        public int CrearReserva(int idHabitacion, int idHuesped, DateTime checkIn, DateTime checkOut,
                                 Temporada temporada, decimal tarifaBase)
        {
            if (checkOut <= checkIn)
            {
                throw new ReservaFechasInvalidasException(
                    "La fecha de check-out debe ser posterior a la fecha de check-in.");
            }

            int noches = (checkOut - checkIn).Days;
            decimal montoTotal = CalcularMonto(noches, tarifaBase, temporada);

            return reservadatos.Insertar(idHabitacion, idHuesped, checkIn, checkOut,
                                        temporada.ToString(), tarifaBase, montoTotal);
        }

        // Calculo reutilizable: lo usa CrearReserva y tambien la vista previa en tiempo real del form
        public decimal CalcularMonto(int noches, decimal tarifaBase, Temporada temporada)
        {
            decimal factorTemporada = ObtenerFactorTemporada(temporada);
            return noches * tarifaBase * factorTemporada;
        }

        // Confirmar: valida que no haya otra reserva confirmada cruzando esas fechas
        public void ConfirmarReserva(int idReserva, int idHabitacion, DateTime checkIn, DateTime checkOut)
        {
            string estadoHabitacion = habitaciondatos.ObtenerEstado(idHabitacion);
            if (reservadatos.ExisteSolapamiento(idHabitacion, checkIn, checkOut, idReserva))
            {
                throw new ReservaNoDisponibleException(
                    "La habitacion ya tiene una reserva confirmada en esas fechas.");
            }
            if (estadoHabitacion != "Disponible")
            {
                throw new ReservaNoDisponibleException(
                    "La habitacion no esta disponible para Confirmar reserva (estado actual: " 
                    + estadoHabitacion + ").");
            }
            reservadatos.ActualizarEstado(idReserva, EstadoReserva.Confirmada.ToString());
            habitaciondatos.ActualizarEstado(idHabitacion,EstadoHabitacion.Reservada.ToString());
            bitacoraService.Registrar("Corfirmo Reserva ", $"El usuario confirmo la reserva {idReserva}");
        }

        public void CancelarReserva(int idReserva)
        {
            reservadatos.ActualizarEstado(idReserva, EstadoReserva.Cancelada.ToString());
            bitacoraService.Registrar("Cancelacion de Reserva ",
                $"El usuario Cancelo la reserva {idReserva}");
        }

        // Check-in real: solo si la habitacion esta Disponible
        public int RealizarCheckIn(int idReserva, int idHabitacion)
        {
            string estadoHabitacion = habitaciondatos.ObtenerEstado(idHabitacion);

            if (estadoHabitacion != "Disponible")
            {
                throw new ReservaNoDisponibleException(
                    "La habitacion no esta disponible para hacer check-in (estado actual: " 
                    + estadoHabitacion + ").");
            }

            habitaciondatos.ActualizarEstado(idHabitacion, EstadoHabitacion.Ocupada.ToString());

            int idEstadia = estadiaService.CrearEstadia(idReserva, idHabitacion, "Check-in inicial");
            bitacoraService.Registrar("Check-in ", $"El Usuario relizo el Check-In de {idReserva}");
            return idEstadia;
        }

        private decimal ObtenerFactorTemporada(Temporada temporada)
        {
            switch (temporada)
            {
                case Temporada.Alta:
                    return 1.00m;
                case Temporada.Media:
                    return 0.90m;
                case Temporada.Baja:
                    return 0.80m;
                default:
                    return 1.00m;
            }
        }

        private List<Reserva> MapearLista(DataTable tabla)
        {
            List<Reserva> lista = new List<Reserva>();
            foreach (DataRow fila in tabla.Rows)
            {
                lista.Add(Mapear(fila));
            }
            return lista;
        }

        private Reserva Mapear(DataRow fila)
        {
            Reserva reserva = new Reserva();
            reserva.IdReserva = Convert.ToInt32(fila["IdReserva"]);
            reserva.IdHabitacion = Convert.ToInt32(fila["IdHabitacion"]);
            reserva.Numero = Convert.ToInt32(fila["Numero"]);
            reserva.IdHuesped = Convert.ToInt32(fila["IdHuesped"]);
            reserva.NombreHuesped = fila["NombreHuesped"].ToString();
            reserva.NumeroDocumento = fila["NumeroDocumento"].ToString();
            reserva.FechaCheckIn = Convert.ToDateTime(fila["FechaCheckIn"]);
            reserva.FechaCheckOut = Convert.ToDateTime(fila["FechaCheckOut"]);
            reserva.CantidadNoches = Convert.ToInt32(fila["CantidadNoches"]);
            reserva.Estado = (EstadoReserva)Enum.Parse(typeof(EstadoReserva), fila["Estado"].ToString());
            reserva.Temporada = (Temporada)Enum.Parse(typeof(Temporada), fila["Temporada"].ToString());
            reserva.TarifaAplicada = Convert.ToDecimal(fila["TarifaAplicada"]);
            reserva.MontoTotal = Convert.ToDecimal(fila["MontoTotal"]);
            reserva.FechaCreacion = Convert.ToDateTime(fila["FechaCreacion"]);
            return reserva;
        }
    
    }
}
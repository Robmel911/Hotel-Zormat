// Cedula: [tu cedula aqui]
using System.Text.RegularExpressions;
using HotelZormat.Negocio.Excepciones;

namespace HotelZormat.Negocio.Validaciones
{
    public static class Validador
    {
        // Solo letras (incluye tildes, enie y espacios para nombres compuestos)
        private static readonly Regex RegexSoloLetras =
            new Regex(@"^[a-zA-ZÁÉÍÓÚáéíóúÑñ\s]+$");

        // Solo digitos, espacios, guiones, parentesis y '+' (para codigo de pais)
        private static readonly Regex RegexTelefono =
            new Regex(@"^[0-9\s\-\+\(\)]+$");

        // texto@ + al menos 2 letras + '.' + al menos 2 letras
        private static readonly Regex RegexEmail =
            new Regex(@"^[^@\s]+@[a-zA-Z]{2,}\.[a-zA-Z]{2,}$");

        public static void ValidarNombre(string valor, string nombreCampo)
        {
            if (!RegexSoloLetras.IsMatch(valor))
            {
                throw new NombreInvalidoException(
                    nombreCampo + " solo puede contener letras.");
            }
        }

        public static void ValidarTelefono(string valor)
        {
            if (!RegexTelefono.IsMatch(valor))
            {
                throw new TelefonoInvalidoException(
                    "El telefono no puede contener letras.");
            }
        }

        public static void ValidarEmail(string valor)
        {
            if (!RegexEmail.IsMatch(valor))
            {
                throw new EmailInvalidoException(
                    "El email debe tener el formato correcto, ej: nombre@dominio.com");
            }
        }
    }
}

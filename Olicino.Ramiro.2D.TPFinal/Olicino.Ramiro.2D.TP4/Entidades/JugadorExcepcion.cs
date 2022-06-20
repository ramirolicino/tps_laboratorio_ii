using System;

namespace Entidades
{
    /// <summary>
    /// Clase de excepciones
    /// </summary>
    public class JugadorExcepcion : Exception
    {
        public JugadorExcepcion()
        {
        }

        public JugadorExcepcion(string message) : base(message)
        {
        }

        public JugadorExcepcion(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}

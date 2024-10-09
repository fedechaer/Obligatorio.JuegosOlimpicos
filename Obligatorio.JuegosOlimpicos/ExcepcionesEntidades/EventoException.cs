using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.ExcepcionesEntidades
{
    public class EventoException : Exception
    {
        public EventoException() { }
        public EventoException(string message) : base(message) { }
        public EventoException(string message, Exception innerException) : base(message, innerException) { }
    }
}

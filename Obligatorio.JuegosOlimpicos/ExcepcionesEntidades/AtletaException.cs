using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.ExcepcionesEntidades
{
    public class AtletaException : Exception
    {
        public AtletaException() { }
        public AtletaException(string message) : base(message) { }
        public AtletaException(string message, Exception innerException) : base(message, innerException) { }
    }
}

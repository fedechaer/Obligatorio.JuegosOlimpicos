using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.ValueObjects
{
    [ComplexType]
    public class Password
    {
        public string Valor { get; init; }

        public Password(string valor)
        {
            this.Valor = valor;
        }

        public void Validar()
        {
            if (!Valor.Contains("!") && !Valor.Contains(".") && !Valor.Contains(";") && !Valor.Contains(","))
            {
                throw new Exception("La contrasenia es incorrecta");
            }
            if(Valor.Length < 6)
            {
                throw new Exception("La contrasenia es incorrecta");
            }
            if (!Valor.Any(char.IsUpper))
            {
                throw new Exception("La contrasenia es incorrecta");
            }
            if (!Valor.Any(char.IsLower))
            {
                throw new Exception("La contrasenia es incorrecta");
            }
            if (!Valor.Any(char.IsDigit))
            {
                throw new Exception("La contrasenia es incorrecta");

            }
        }
    }
}

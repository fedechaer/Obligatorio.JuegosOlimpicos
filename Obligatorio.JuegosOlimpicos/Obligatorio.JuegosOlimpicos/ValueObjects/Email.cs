using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.ValueObjects
{
    [ComplexType]
    public class Email
    {
        public string Valor { get; init; }

        public Email(string valor)
        {
            this.Valor = valor;
        }

        public void Validar ()
        {
            if (Valor.IndexOf("@") == -1)
            {
                throw new Exception("El email es incorrecto");
            }
        }

    }

}


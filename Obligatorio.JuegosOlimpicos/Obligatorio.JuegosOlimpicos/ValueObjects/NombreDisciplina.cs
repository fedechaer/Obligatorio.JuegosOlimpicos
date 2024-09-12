using LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.ValueObjects
{
    public class NombreDisciplina
    {
        public string Valor { get; init; }

        public NombreDisciplina(string valor)
        {
            this.Valor = valor;
        }

        public void Validar()
        {
            if(Valor.Count() < 10 || Valor.Count() > 50)
            {
                throw new Exception("El nombre de la disciplina no es valido");
            }
        }
    }
}

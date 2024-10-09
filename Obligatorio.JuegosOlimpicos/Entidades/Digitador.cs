using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public class Digitador : Usuario
    {
        
        public int Id { get; set; }

        public Digitador(string email, string password, string rol) : base(email, password, rol)
        {
        }

        public override void CreacionEvento() { }

        public override void AgregarDisciplina(Evento evento, Atleta atleta)
        {
            if (!atleta._eventos.Contains(evento))
            {
                atleta._eventos.Add(evento);
            }
            else 
            {
                throw new Exception("Ya participa del evento");
            }
        }

    }
}

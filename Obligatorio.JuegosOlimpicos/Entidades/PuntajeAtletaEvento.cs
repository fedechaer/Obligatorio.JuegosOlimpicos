using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public class PuntajeAtletaEvento
    {
        public Atleta Atleta { get; set; }
        public Evento Evento { get; set; }
        public decimal Puntaje { get; set; }

        public PuntajeAtletaEvento(Atleta atleta, Evento evento, decimal puntaje)
        {
            Atleta = atleta;
            Evento = evento;
            Puntaje = puntaje;
        }
    }
}

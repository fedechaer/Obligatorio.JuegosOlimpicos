using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public class PuntajeAtletaEvento
    {
        [Key]
        public int IdPuntajeAtletaEvento {  get; set; }
        public static int UltId;
        public decimal Puntaje { get; set; }
        [ForeignKey(nameof(Atleta))]
        public int IdAtleta { get; set; }
        public Atleta Atleta { get; set; }
        [ForeignKey(nameof(Evento))]
        public int IdEvento {  get; set; }
        public Evento Evento { get; set; }
        

        public PuntajeAtletaEvento() { }
        public PuntajeAtletaEvento(Atleta atleta, Evento evento, decimal puntaje)
        {
            Atleta = atleta;
            Evento = evento;
            Puntaje = puntaje;
        }
    }
}

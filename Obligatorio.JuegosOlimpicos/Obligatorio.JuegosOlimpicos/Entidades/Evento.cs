using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public class Evento
    {
        public List<Disciplina> Disciplina { get; set; }
        public string NombreEvento  { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin {  get; set; }

        public List<Atleta> _atletas = new List<Atleta>();


        private Evento() { }
        public Evento(string nombreEvento, DateTime fechaInicio, DateTime fechaFin)
        {
            NombreEvento = nombreEvento;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
        }

        public void AgregarAtletaAlEvento(Atleta atleta)
        {
            if (!_atletas.Contains(atleta))
            {
                _atletas.Add(atleta);
            }
            else
            {
                throw new Exception("El atleta ya pertenece al evento");
            }
        }
    }
}

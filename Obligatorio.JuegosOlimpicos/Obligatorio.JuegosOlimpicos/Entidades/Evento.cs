using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public class Evento
    {
        [Key]
        public int Id { get; set; }
        public static int UltId;
        public List<Disciplina> Disciplina { get; set; }
        [Key]
        [Required]
        [Display(Name ="Nombre del Evento")]
        [StringLength(100)]
        public string NombreEvento  { get; set; }
        [Required]
        [Display(Name ="Fecha de Inicio")]
        public DateTime FechaInicio { get; set; }
        [Required]
        [Display(Name ="Fecha de Fin")]
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

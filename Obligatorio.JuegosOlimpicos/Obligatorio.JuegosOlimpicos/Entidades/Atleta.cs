using LogicaNegocio.ExcepcionesEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    //[PrimaryKey(nameof(Id))]
    public class Atleta
    {
        [Key]
        public int Id { get; set; }
        
        public static int UltId;
        [Required]
        [Display (Name="Nombre Completo")]
        [StringLength(100)]
        public string NombreCompleto { get; set; }
        [Required]
        public Sexo Sexo {  get; set; }
        [Required]
        public Pais Pais { get; set; }
        public List<Evento> _eventos = new List<Evento>();
        private string sexo;
        public PuntajeAtletaEvento? Puntaje { get; set; }

        private Atleta() { }
        public Atleta(string nombreCompleto, Sexo sexo, Pais pais)
        {
            NombreCompleto = nombreCompleto;
            Sexo = sexo;
            Pais = pais;
        }
        public Atleta(string nombreCompleto, Sexo sexo)
        {
            NombreCompleto = nombreCompleto;
            Sexo = sexo;
        }

        public Atleta(string nombreCompleto, string sexo)
        {
            NombreCompleto = nombreCompleto;
            this.sexo = sexo;
        }

        public void Validar()
        {
            if(Pais == null)
            {
                throw new AtletaException("El atleta no tiene Pais correspondiente");
            } 
        }

    }
}

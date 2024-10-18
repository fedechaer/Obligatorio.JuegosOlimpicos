using LogicaNegocio.ExcepcionesEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LogicaNegocio.Entidades
{
    //[PrimaryKey(nameof(Id))]
    public class Atleta
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(100)]
        public string Apellido { get; set; }
        [Required]
        public Sexo Sexo {  get; set; }
        [Required]
        public Pais Pais { get; set; }
        public List<Evento> _eventos = new List<Evento>();
        private string sexo;
        public PuntajeAtletaEvento? Puntaje { get; set; }

        private Atleta(string nombreCompleto) { }
        public Atleta(string nombre, string apellido, Sexo sexo, Pais pais)
        {
            Nombre = nombre;
            Apellido = apellido;
            Sexo = sexo;
            Pais = pais;
            Validar();
        }
        public Atleta(string nombre, string apellido, Sexo sexo)
        {
            Nombre = nombre;
            Apellido = apellido;
            Sexo = sexo;
        }

        public Atleta(string nombre, string apellido, string sexo)
        {
            Nombre = nombre;
            Apellido = apellido;
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

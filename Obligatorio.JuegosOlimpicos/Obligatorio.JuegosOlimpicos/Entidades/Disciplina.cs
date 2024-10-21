using LogicaNegocio.InterfacesEntidades;
using LogicaNegocio.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public class Disciplina : IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public NombreDisciplina NombreDescriptivo { get; set; }
        [Required]
        public int AnioInclusion { get; set; }

        public Disciplina() { }
        
        public Disciplina(NombreDisciplina nombreDesc, int anioInclusion)
        {
            NombreDescriptivo = nombreDesc;
            AnioInclusion = anioInclusion;
        }
        public Disciplina(string nombreDescriptivo, int anioInclusion)
        {
            NombreDescriptivo = new NombreDisciplina(nombreDescriptivo);
            AnioInclusion = anioInclusion;
        }
        public void Validar() { }

    }   
}
    
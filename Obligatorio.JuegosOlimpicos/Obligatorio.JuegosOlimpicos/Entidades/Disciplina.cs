using LogicaNegocio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public class Disciplina
    {
        public int Id { get; set; }
        public NombreDisciplina NombreDescriptivo { get; set; }
        public int AnioInclusion { get; set; }

        public Disciplina() { }
        public Disciplina(string nombreDescriptivo, int anioInclusion)
        {
            NombreDescriptivo = new NombreDisciplina(nombreDescriptivo);
            AnioInclusion = anioInclusion;
        }
        public void Validar() { }

        
    }   
}
    
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
        public static int UltId;
        public NombreDisciplina NombreDescriptivo { get; set; }
        public DateTime AnioInclusion { get; set; }

        public Disciplina(string nombreDescriptivo, DateTime anioInclusion)
        {
            NombreDescriptivo = new NombreDisciplina(nombreDescriptivo);
            AnioInclusion = anioInclusion;
        }
        public void Validar() { }
    }   
}

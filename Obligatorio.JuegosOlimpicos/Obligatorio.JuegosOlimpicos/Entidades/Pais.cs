using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public class Pais
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int CantHabitantes { get; set; }
        public string NomDelegado { get; set; }
        public int TelDelegado { get; set; }
        //public List<Atleta> _atletas = new List<Atleta>();

        private Pais() { }
        public Pais(int cantHabitantes, string nomDelegado, int telDelegado, List<Atleta> atletas)
        {
            NomDelegado = nomDelegado;
            CantHabitantes = cantHabitantes;
            TelDelegado = telDelegado;
        }

    }
}

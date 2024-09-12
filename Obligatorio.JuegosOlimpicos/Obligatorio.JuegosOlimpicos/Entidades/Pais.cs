using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public class Pais
    {
        public int Id { get; set; }
        public static int UltId;
        public string Nombre { get; set; }
        public int CantHabitantes { get; set; }
        public int TelDelegado { get; set; }
        //public List<Atleta> _atletas = new List<Atleta>();

        public Pais(string nombre, int cantHabitantes, int telDelegado, List<Atleta> atletas)
        {
            Nombre = nombre;
            CantHabitantes = cantHabitantes;
            TelDelegado = telDelegado;
        }

    }
}

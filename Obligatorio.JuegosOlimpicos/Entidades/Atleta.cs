using LogicaNegocio.ExcepcionesEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public class Atleta
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public Sexo Sexo {  get; set; }       
        public Pais Pais { get; set; }
        public List<Evento> _eventos = new List<Evento>();

        public PuntajeAtletaEvento? Puntaje { get; set; }

        public Atleta(string nombreCompleto, Sexo sexo, Pais pais)
        {
            NombreCompleto = nombreCompleto;
            Sexo = sexo;
            Pais = pais;
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

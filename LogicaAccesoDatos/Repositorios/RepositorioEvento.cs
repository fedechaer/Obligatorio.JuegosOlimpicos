using LogicaNegocio.Entidades;
using LogicaNegocio.ExcepcionesEntidades;
using LogicaNegocio.InterfaceRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAccesoDatos.Repositorios
{
    public class RepositorioEvento : IRepositorioEvento
    {
        public static List<Evento> Eventos = new List<Evento>();
        public void Add(Evento iteam)
        {
            if (!Eventos.Contains(iteam))
            {
                Eventos.Add(iteam);
            }
        }

        public void Delete(int Id)
        {
            Evento evento = FindById(Id);
            if (evento == null)
            {
                throw new EventoException("El id recibido no es correcto");
            }
            Eventos.Remove(evento);
        }

        public IEnumerable<Evento> FindAll()
        {
            return Eventos;
        }

        public Evento FindById(int Id)
        {
            Evento evento = null;
            int i = 0;
            while (i < Eventos.Count() && evento == null)
            {
                if (Eventos[i].Id == Id)
                {
                    evento = Eventos[i];
                }
                i++;
            }
            return evento;
        }

        public void Update(Evento evento, int Id)
        {
            Evento eventoBuscado = FindById(Id);
            if (eventoBuscado == null)
            {
                throw new UsuarioException("El id es incorrecto");
            }
            else
            {
                evento.NombreEvento = eventoBuscado.NombreEvento;
                evento.FechaFin = eventoBuscado.FechaFin;
                evento.FechaInicio = eventoBuscado.FechaInicio;
            }
        }
    }
}

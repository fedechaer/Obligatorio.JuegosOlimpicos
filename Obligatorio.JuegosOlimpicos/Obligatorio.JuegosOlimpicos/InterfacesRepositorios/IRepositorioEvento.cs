using LogicaNegocio.Entidades;
using LogicaNegocio.InterfacesEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.InterfacesRepositorios
{
    public interface IRepositorioEvento : IRepositorio<Evento>
    {
        public static List<Evento> Eventos = new List<Evento>();
        public void Add(Evento evento)
        {
            if (!Eventos.Contains(evento)) 
            { 
                Eventos.Add(evento);
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Evento> FindAll()
        {
            return Eventos;
        }

        public Evento FindById(int id)
        {
            Evento  evento = null;
            int i = 0;
            while (i < Eventos.Count && evento == null)
            {
                if (Eventos[i].Id == id)
                {
                    evento = Eventos[i];
                }
                i++;
            }
            return evento;
        }

        public void Update(Evento item, int id)
        {
            throw new NotImplementedException();
        }
    }
}

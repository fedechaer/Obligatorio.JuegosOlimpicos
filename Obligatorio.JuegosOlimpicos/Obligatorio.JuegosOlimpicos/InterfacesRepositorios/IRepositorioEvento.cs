using LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.InterfacesRepositorios
{
    internal class IRepositorioEvento : IRepositorio<Evento>
    {
        public void Add(Evento item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Evento> FindAll()
        {
            throw new NotImplementedException();
        }

        public Evento FindById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Evento item, int id)
        {
            throw new NotImplementedException();
        }
    }
}

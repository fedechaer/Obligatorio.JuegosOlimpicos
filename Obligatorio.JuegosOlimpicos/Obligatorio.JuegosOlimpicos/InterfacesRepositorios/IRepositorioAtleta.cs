
using LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.InterfacesRepositorios
{
    public interface IRepositorioAtleta : IRepositorio<Atleta>
    {
        public void Add(Atleta item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Atleta> FindAll()
        {
            throw new NotImplementedException();
        }

        public Atleta FindById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Atleta item, int id)
        {
            throw new NotImplementedException();
        }
    }


}

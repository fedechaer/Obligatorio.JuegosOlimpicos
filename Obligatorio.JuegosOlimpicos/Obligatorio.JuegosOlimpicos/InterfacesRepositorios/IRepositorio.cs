using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.InterfacesRepositorios
{
    public interface IRepositorio<T>
    {
        void Add(T item);
        void Delete(int id);
        void Update(T item, int id);
        T FindById(int id);
        IEnumerable<T> FindAll();
    }
}

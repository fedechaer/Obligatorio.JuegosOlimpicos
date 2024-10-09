using LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.InterfaceRepositorio
{
    public interface IRepositorio<T>
    {
        public void Add(T iteam);
        public void Delete(int Id);
        public T FindById(int Id);
        public IEnumerable<T> FindAll();
        public void Update(T usuario, int Id);
    }
}

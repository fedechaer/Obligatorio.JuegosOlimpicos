using LogicaNegocio.Entidades;
using LogicaNegocio.InterfacesRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAccesoDatos.Repositorios
{
    public class RepositorioAtletaEF : IRepositorioAtleta
    {
        public LibreriaContext Contexto { get; set; }
        
        public RepositorioAtletaEF(LibreriaContext contexto)
        {
            Contexto = contexto;
        }
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
            return Contexto.Atletas;
        }

        public Atleta FindById(int id)
        {
            return Contexto.Atletas.Where(a => a.Id == id).SingleOrDefault();
        }

        public void Update(Atleta item, int id)
        {
            throw new NotImplementedException();
        }
    }
}

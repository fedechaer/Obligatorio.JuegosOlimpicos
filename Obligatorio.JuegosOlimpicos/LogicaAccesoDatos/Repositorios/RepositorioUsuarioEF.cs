using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaNegocio.Entidades;
using LogicaNegocio.InterfacesRepositorios;


namespace LogicaAccesoDatos.Repositorios
{
    public class RepositorioUsuarioEF : IRepositorioUsuario
    {
        public LibreriaContext Contexto { get; set; }
        public RepositorioUsuarioEF(LibreriaContext contexto)
        {
            Contexto = contexto;
        }

        public void Add(Usuario item)
        {
            Usuario usuarioBuscado = FindById(item.Id);
            if(usuarioBuscado == null)
            {
                Contexto.Usuarios.Add(item);
                Contexto.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            Usuario usuarioBuscado = FindById(id);
            if(usuarioBuscado == null)
            {
                Contexto.Usuarios.Remove(usuarioBuscado);
                Contexto.SaveChanges();
            }
        }

        public void Update(Usuario item, int id)
        {
            throw new NotImplementedException();
        }

        public Usuario FindById(int id)
        {
            return Contexto.Usuarios.Where(u => u.Id == id).SingleOrDefault();
        }

        public IEnumerable<Usuario> FindAll()
        {
            return Contexto.Usuarios;
        }
    }
}

using LogicaNegocio.Entidades;
using LogicaNegocio.ExcepcionesEntidades;
using LogicaNegocio.InterfacesEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.InterfacesRepositorios
{
    public interface IRepositorioUsuario : IRepositorio<Usuario>
    {
        public static List<Usuario> Usuarios = new List<Usuario>();
        public void Add(Usuario item)
        {
            if(Usuarios.Contains(item) == null)
            {
                Usuarios.Add(item);
            } 
                return;
        }

        public void Delete(int id)
        {
            Usuario usuario = FindById(id);
            if (usuario == null)
            {
                throw new UsuarioException("El id recibido no es correcto");
            }
            Usuarios.Remove(usuario);
        }

        public IEnumerable<Usuario> FindAll()
        {
            return Usuarios;
        }

        public Usuario FindById(int id)
        {
            Usuario usuario = null;
            int i = 0;
            while (i < Usuarios.Count && usuario == null)
            {
                if (Usuarios[i].Id == id)
                {
                    usuario = Usuarios[i];
                }
                i++;
            }
            return usuario;
        }

        public void Update(Usuario usuario, int Id)
        {
            Usuario usuarioBuscado = FindById(Id);
            if (usuarioBuscado == null)
            {
                throw new UsuarioException("El id es incorrecto");
            }
            else
            {
                usuario.Validar();
                usuario.Id = usuarioBuscado.Id;
                usuario.Email = usuarioBuscado.Email;
                usuario.Password = usuarioBuscado.Password;
            }
        }
    }
}

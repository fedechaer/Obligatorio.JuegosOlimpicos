using LogicaNegocio.Entidades;
using LogicaNegocio.ExcepcionesEntidades;
using LogicaNegocio.InterfacesRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAccesoDatos.Repositorios
{
    public class RepositorioUsuario : IRepositorioUsuario
    {
        public static List<Usuario> Usuarios = new List<Usuario>();


        public void Add(Usuario usuario)
        {
            if (!Usuarios.Contains(usuario))
            {
                Usuarios.Add(usuario);
            }
        }
        public void Delete(int Id)
        {
            Usuario usuario = FindById(Id);
            if (usuario == null)
            {
                throw new UsuarioException("El id recibido no es correcto");
            }
            Usuarios.Remove(usuario);
        }
        public Usuario FindById(int Id)
        {
            Usuario usuario = null;
            int i = 0;
            while(i<Usuarios.Count && usuario == null)
            {
                if( Usuarios[i].Id == Id)
                {
                    usuario = Usuarios[i];
                }
                i++;
            }
            return usuario;
        }
        public IEnumerable<Usuario> FindAll()
        {
            return Usuarios;
        }
        public void Update( Usuario usuario, int Id)
        {
            Usuario usuarioBuscado = FindById(Id);
            if (usuarioBuscado == null)
            {
                throw new UsuarioException("El id recibido no es correcto");
            }
            else
            {
                usuario.Validar();
                usuario.Password.Validar();
                usuario.Email.Validar();
                usuarioBuscado.Email = usuario.Email;
                usuarioBuscado.Password = usuario.Password;
                usuarioBuscado.Rol = usuario.Rol;
            }
        }
    }
}

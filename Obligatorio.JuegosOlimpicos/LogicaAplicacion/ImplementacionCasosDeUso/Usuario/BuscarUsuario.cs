using LogicaAccesoDatos.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.ImplementacionCasosDeUso.Usuario
{
    public class BuscarUsuario
    {

        public RepositorioUsuario RepoUsuario { get; set; }
        public static List<RepositorioUsuario> Usuarios = new List<RepositorioUsuario>();
        public BuscarUsuario (RepositorioUsuario repoUsuario)
        {
            RepoUsuario = repoUsuario;
        }

        public void Ejecutar(RepositorioUsuario usuario)
        {
            //Usuario usuario = RepoUsuario.FindById(usuario.UsuarioId);
            usuario = RepoUsuario.FindById(usuario.UsuarioId);

        }

        public RepositorioUsuario FindById(int Id)
        {
            RepositorioUsuario usuario = null;
            int i = 0;
            while (i < Usuarios.Count && usuario == null)
            {
                if (Usuarios[i].Id == Id)
                {
                    usuario = Usuarios[i];
                }
                i++;
            }
            return usuario;
        }
         

    }
}

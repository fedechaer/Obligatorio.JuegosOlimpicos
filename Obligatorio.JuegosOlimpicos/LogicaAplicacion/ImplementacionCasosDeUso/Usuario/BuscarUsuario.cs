using LogicaAccesoDatos.Repositorios;
using LogicaNegocio.Entidades;
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

        public void Ejecutar(int usuarioId)
        {
            //Usuario usuario = RepoUsuario.FindById(usuario.UsuarioId);
            LogicaNegocio.Entidades.Usuario usuario = RepoUsuario.FindById(usuarioId);

        }
    }
}

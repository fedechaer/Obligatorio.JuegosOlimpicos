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
        public BuscarUsuario (RepositorioUsuario repoUsuario)
        {
            RepoUsuario = repoUsuario;
        }

        public void Ejecutar(LogicaNegocio.Entidades.Usuario usuario)
        {
            //Usuario usuario = RepoUsuario.FindById(usuario.UsuarioId);

        }

    }
}

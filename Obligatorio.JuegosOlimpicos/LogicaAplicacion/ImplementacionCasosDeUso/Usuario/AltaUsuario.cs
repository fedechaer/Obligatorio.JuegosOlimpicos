using LogicaAccesoDatos.Repositorios;
using LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.ImplementacionCasosDeUso.Usuario
{
    public class AltaUsuario
    {
        public RepositorioUsuario RepoUsuario { get; set; } = new RepositorioUsuario();

        public void Ejecutar(LogicaNegocio.Entidades.Usuario usuario)
        {
            RepoUsuario.Add(usuario);
        }
    }
}

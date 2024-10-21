using LogicaAccesoDatos.Repositorios;
using LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.ImplementacionCasosDeUso.Atleta
{
    public class AltaAtleta
    {
        public RepositorioAtleta RepoAtleta{ get; set; } = new RepositorioAtleta();

        public void Ejecutar(LogicaNegocio.Entidades.Atleta atleta)
        {
            RepoAtleta.Add(atleta);
        }
    }
}

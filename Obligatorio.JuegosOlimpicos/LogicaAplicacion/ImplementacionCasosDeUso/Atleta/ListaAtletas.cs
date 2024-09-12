using LogicaAccesoDatos.Repositorios;
using LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.ImplementacionCasosDeUso
{
    public class ListaAtletas
    {
        public RepositorioAtleta RepoAtletas { get; set; } = new RepositorioAtleta();

        public List<Atleta> Ejecutar()
        {
            return (List<Atleta>)RepoAtletas.FindAll();
        }
    }
}

﻿using Compartido.Mappers;
using LogicaAccesoDatos.Repositorios;
using LogicaAplicacion.InterfacesCasosDeUso.Atleta;
using LogicaNegocio.Entidades;
using LogicaNegocio.InterfacesEntidades;
using LogicaNegocio.InterfacesRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.ImplementacionCasosDeUso
{
    public class ListadoAtletas : IListadoAtletas
    {
        public RepositorioAtleta RepoAtletas { get; set; }
        public ListadoAtletas(IRepositorioAtleta repoAtleta)
        {
            RepoAtletas = (RepositorioAtleta?)repoAtleta;
        }

        

        IEnumerable<IListadoAtletas> IListadoAtletas.Ejecutar()
        {
            IEnumerable<LogicaNegocio.Entidades.Atleta> Atletas = RepoAtletas.FindAll();
            IEnumerable<IListadoAtletas> atletaDTOs = (IEnumerable<IListadoAtletas>)MapperAtleta.ListAtletaToListAtletaDTO(Atletas);

            return atletaDTOs;
        }
    }

        
}

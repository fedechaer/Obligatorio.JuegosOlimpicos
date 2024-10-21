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
    public class RepositorioAtleta : IRepositorioAtleta
    {

        public static List<Atleta> Atletas = new List<Atleta>();
        

        public void Add(Atleta atleta)
        {
            if (!Atletas.Contains(atleta))
            {
                Atletas.Add(atleta);
            }
        }
        public void Delete(int Id)
        {
            Atleta atleta = FindById(Id);
            if (atleta == null)
            {
                throw new UsuarioException("El id recibido no es correcto");
            }
            Atletas.Remove(atleta);
        }
        public Atleta FindById(int Id)
        {
            Atleta atleta = null;
            int i = 0;
            while (i < Atletas.Count && atleta == null)
            {
                if (Atletas[i].Id == Id)
                {
                    atleta = Atletas[i];
                }
                i++;
            }
            return atleta;
        }
        public IEnumerable<Atleta> FindAll()
        {
            return Atletas;
        }
        public void Update(Atleta atleta, int Id)
        {
            Atleta atletaBuscado = FindById(Id);
            if (atletaBuscado == null)
            {
                throw new UsuarioException("El id es incorrecto");
            }
            else
            {
                atleta.Validar();
                atleta._eventos = atletaBuscado._eventos;
                atleta.Pais = atletaBuscado.Pais;
                atleta.Puntaje = atletaBuscado.Puntaje;
            }
        }
    }
}

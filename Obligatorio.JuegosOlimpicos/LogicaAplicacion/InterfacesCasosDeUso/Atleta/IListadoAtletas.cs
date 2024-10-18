using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.InterfacesCasosDeUso.Atleta
{
    public interface IListadoAtletas
    {
        IEnumerable<IListadoAtletas> Ejecutar();
    }

}

using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contratos
{
    public interface IPersonaRepositorio:IBaseRepositorio<Persona>
    {
        IEnumerable<Persona> TopPersona();
    }
}

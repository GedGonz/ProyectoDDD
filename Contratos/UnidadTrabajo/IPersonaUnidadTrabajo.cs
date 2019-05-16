using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contratos.UnidadTrabajo
{
    public interface IPersonaUnidadTrabajo
    {
        IPersonaRepositorio IPersonaRepositorio { get; }
        void commit();
        void RollBack();
        void Disposable();
    }
}

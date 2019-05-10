using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contratos
{
    public interface IBaseRepositorio<T> where T:class
    {
        bool Add(T Entidad);
        bool Update(T Entidad);
        IEnumerable<T> Lista();
    }
}

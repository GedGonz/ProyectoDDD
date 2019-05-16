using Contratos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorios
{
    public class BaseRepositorio<T> : IBaseRepositorio<T> where T : class
    {
        protected readonly DbContext contexto;
        protected readonly DbSet<T> Tabla;
        public BaseRepositorio(DbContext contexto)
        {
            this.contexto = contexto;
            this.Tabla = contexto.Set<T>();
        }
        public bool Add(T Entidad)
        {
            Tabla.Add(Entidad);
            return true;
        }
        public IEnumerable<T> Lista()
        {
            return Tabla.ToList();
        }
        public bool Update(T Entidad)
        {
            Tabla.Attach(Entidad);
            contexto.Entry(Entidad).State = EntityState.Modified;
            return true;
        }
    }
}

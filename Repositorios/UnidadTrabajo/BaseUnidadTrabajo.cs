using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorios.UnidadTrabajo
{
    public class BaseUnidadTrabajo
    {
        protected readonly DbContext Contexto;
        public BaseUnidadTrabajo(DbContext Contexto)
        {
            this.Contexto = Contexto;
        }
        
        public void commit()
        {

            Contexto.SaveChanges();
            if (Contexto.Database.CurrentTransaction!=null)
            {
                Contexto.Database.CurrentTransaction.Commit();
            }
        }
        public void RollBack()
        {
            Contexto.Database.CurrentTransaction.Rollback();
        }

        public void Disposable()
        {
            GC.KeepAlive(this);
            Contexto.Dispose();
        }
    }
}

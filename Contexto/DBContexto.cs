using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contexto
{
    public class DBContexto:DbContext
    {
        public DBContexto():base("name=DefaultConnection")
        {

        }
        public DbSet<Persona> Persona { get; set; }
    }
}

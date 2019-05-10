using Contratos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Contexto;

namespace Repositorios
{
    public class PersonaRepositorio : BaseRepositorio<Persona>, IPersonaRepositorio
    {
        public PersonaRepositorio(DbContext Contexto) : base(Contexto)
        {
        }

        public IEnumerable<Persona> TopPersona()
        {
            return Tabla.Take(20).ToList();
        }
    }
}

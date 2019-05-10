using Contratos.UnidadTrabajo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contratos;
using System.Data.Entity;
using Contexto;

namespace Repositorios.UnidadTrabajo
{
    public class PersonaUnidadTrabajo : BaseUnidadTrabajo, IPersonaUnidadTrabajo
    {
        IPersonaRepositorio personaRepositorio;
        public PersonaUnidadTrabajo() : base(new DBContexto())
        {
        }

        public IPersonaRepositorio IPersonaRepositorio
        {
            get
            {
                personaRepositorio = new PersonaRepositorio(this.Contexto);
                return personaRepositorio;
            }
        }
    }
}

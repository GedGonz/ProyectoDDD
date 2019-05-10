using Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesDTO;
using ServicioDomini = Contratos.Servicio;
namespace Manejador
{
    public class PersonaServicio : IPersonaServicio
    {
        private readonly ServicioDomini.IPersonaServicio personaServicio;
        public PersonaServicio(ServicioDomini.IPersonaServicio personaServicio)
        {
            this.personaServicio = personaServicio;
        }
        public List<Personadto> ListTopPersonas()
        {
            return new List<Personadto>();//personaServicio.ListaTopPersona();
        }
    }
}

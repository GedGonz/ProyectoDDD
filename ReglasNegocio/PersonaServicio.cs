using Contratos.Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Contratos.UnidadTrabajo;

namespace ReglasNegocio
{
    public class PersonaServicio : IPersonaServicio
    {
        private readonly IPersonaUnidadTrabajo personaUnidadTrabajo;
        public PersonaServicio(IPersonaUnidadTrabajo personaUnidadTrabajo)
        {
            this.personaUnidadTrabajo = personaUnidadTrabajo;
        }
        public List<Persona> ListaTopPersona()
        {
           
            return personaUnidadTrabajo.IPersonaRepositorio.TopPersona().ToList();



        }
    }
}

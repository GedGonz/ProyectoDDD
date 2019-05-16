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

        public bool Add(Persona persona)
        {
            personaUnidadTrabajo.IPersonaRepositorio.Add(persona);
            personaUnidadTrabajo.commit();
            return true;
        }

        public List<Persona> ListaTopPersona()
        {
           
            return personaUnidadTrabajo.IPersonaRepositorio.TopPersona().ToList();
        }

        public Persona Update(Persona persona)
        {
            var Persona = personaUnidadTrabajo.IPersonaRepositorio.Lista().Where(x => x.PersonaId == persona.PersonaId).FirstOrDefault();
            Persona.Nombre = "XXXX";
            personaUnidadTrabajo.IPersonaRepositorio.Update(Persona);
            personaUnidadTrabajo.commit();
            return persona;
        }
    }
}

using Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesDTO;
using ServicioDomini = Contratos.Servicio;
using AutoMapper;
using Entidades;

namespace Manejador
{
    public class PersonaServicio : IPersonaServicio
    {
        private readonly ServicioDomini.IPersonaServicio personaServicio;
        public PersonaServicio(ServicioDomini.IPersonaServicio personaServicio)
        {
            this.personaServicio = personaServicio;
        }

        public bool Add(Personadto personadto)
        {
            var Persona=Mapper.Map<Personadto, Persona>(personadto);
            return personaServicio.Add(Persona);
            
        }







        public List<Personadto> ListTopPersonas()
        {
            var ListaPersonas=personaServicio.ListaTopPersona();

            var ListPersonasDto=Mapper.Map<List<Persona>,List<Personadto>> (ListaPersonas);

            return ListPersonasDto;
        }


















        public Personadto Update(Personadto personadto)
        {
            var Persona = Mapper.Map<Personadto, Persona>(personadto);

            Persona= personaServicio.Update(Persona);

            var Personadto = Mapper.Map<Persona, Personadto>(Persona);

            return Personadto;
        }
    }
}

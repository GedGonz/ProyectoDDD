using AutoMapper;
using Entidades;
using EntidadesDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapa
{
    public class ConfigMapaProfile: Profile
    {
        public ConfigMapaProfile()
        {
            CreateMap<Persona, Personadto>()
            .ForMember(x=>x.PersonaId,y=>y.MapFrom(x=>x.PersonaId))
            .ForMember(x => x.Nombre, y => y.MapFrom(x => x.Nombre));

            CreateMap<Personadto, Persona>();



        }
    }
}

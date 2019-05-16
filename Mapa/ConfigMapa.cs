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
            CreateMap<Persona, Personadto>();

            CreateMap<Personadto, Persona>();
        }
    }
}

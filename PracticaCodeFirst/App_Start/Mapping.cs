using AutoMapper;
using Mapa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaCodeFirst.App_Start
{
    public class Mapping
    {
        public static void InitialMapping()
        {
            Mapper.Initialize(x => x.AddProfile(new ConfigMapaProfile()));
        }
    }
}
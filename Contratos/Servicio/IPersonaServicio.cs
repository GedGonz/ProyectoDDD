using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contratos.Servicio
{
    public interface IPersonaServicio
    {

        List<Persona> ListaTopPersona();
        bool Add(Persona persona);
        Persona Update(Persona persona);
    }
}

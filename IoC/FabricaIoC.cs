using Autofac;
using Contratos;
using Contratos.UnidadTrabajo;
using CNegocio = ReglasNegocio;
using Repositorios;
using Repositorios.UnidadTrabajo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INegocio = Contratos.Servicio;
using CAplicacion = Manejador;
using IAplicacion=Servicio;

namespace IoC
{
    public class FabricaIoC
    {
        public static ContainerBuilder Contenedor(ContainerBuilder build)
        {
            #region Repositorio

                build.RegisterType(typeof(PersonaUnidadTrabajo)).As(typeof(IPersonaUnidadTrabajo)).InstancePerLifetimeScope();
                build.RegisterType(typeof(PersonaRepositorio)).As(typeof(IPersonaRepositorio)).InstancePerLifetimeScope();

            #endregion

            #region Servicios

            build.RegisterType(typeof(CNegocio.PersonaServicio)).As(typeof(INegocio.IPersonaServicio)).InstancePerLifetimeScope();
            build.RegisterType(typeof(CAplicacion.PersonaServicio)).As(typeof(IAplicacion.IPersonaServicio)).InstancePerLifetimeScope();

            #endregion
            return build;
        }
    }
}

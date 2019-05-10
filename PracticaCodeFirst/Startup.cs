using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PracticaCodeFirst.Startup))]
namespace PracticaCodeFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

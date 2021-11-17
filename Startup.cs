using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Recetas.Startup))]
namespace Recetas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Plusminuszero.Startup))]
namespace Plusminuszero
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

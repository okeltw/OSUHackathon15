using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WorldAware.Startup))]
namespace WorldAware
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

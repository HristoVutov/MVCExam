using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SportSystem.Startup))]
namespace SportSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

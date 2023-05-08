using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EventsProject.Startup))]
namespace EventsProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

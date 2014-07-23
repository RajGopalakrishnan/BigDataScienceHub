using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BigDataScienceHub.Startup))]
namespace BigDataScienceHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sampleDotNetWebApp.Startup))]
namespace sampleDotNetWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PolymerDemoApplication.Startup))]
namespace PolymerDemoApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

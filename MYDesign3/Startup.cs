using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MYDesign3.Startup))]
namespace MYDesign3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

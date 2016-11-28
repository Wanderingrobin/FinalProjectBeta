using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FPBeta.Startup))]
namespace FPBeta
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

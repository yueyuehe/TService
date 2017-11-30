using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TService.Startup))]
namespace TService
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

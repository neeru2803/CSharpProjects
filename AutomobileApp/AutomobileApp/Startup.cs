using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AutomobileApp.Startup))]
namespace AutomobileApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

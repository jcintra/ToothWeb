using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ToothFairyWeb.Startup))]
namespace ToothFairyWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

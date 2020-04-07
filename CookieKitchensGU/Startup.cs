using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CookieKitchensGU.Startup))]
namespace CookieKitchensGU
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

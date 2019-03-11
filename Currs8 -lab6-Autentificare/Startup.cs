using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Currs8__lab6_Autentificare.Startup))]
namespace Currs8__lab6_Autentificare
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

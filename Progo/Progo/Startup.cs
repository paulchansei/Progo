using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Progo.Startup))]
namespace Progo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Panta.Startup))]
namespace Panta
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

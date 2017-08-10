using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cliniquinha.Startup))]
namespace Cliniquinha
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

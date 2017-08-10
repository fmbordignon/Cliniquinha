using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjetoCliniquinha.Startup))]
namespace ProjetoCliniquinha
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

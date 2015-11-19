using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TAXWEB_TESTE.Startup))]
namespace TAXWEB_TESTE
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

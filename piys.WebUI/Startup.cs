using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bitirme_Web.Startup))]
namespace Bitirme_Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

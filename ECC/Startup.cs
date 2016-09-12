using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ECC.Startup))]
namespace ECC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

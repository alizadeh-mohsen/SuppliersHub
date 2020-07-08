using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SuppliersHub.Startup))]
namespace SuppliersHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

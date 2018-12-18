using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sale.backend.Startup))]
namespace sale.backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

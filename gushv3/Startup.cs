using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gushv3.Startup))]
namespace gushv3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

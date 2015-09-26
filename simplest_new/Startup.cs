using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(simplest_new.Startup))]
namespace simplest_new
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

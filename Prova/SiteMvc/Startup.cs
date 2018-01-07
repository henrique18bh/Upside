using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SiteMvc.Startup))]
namespace SiteMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

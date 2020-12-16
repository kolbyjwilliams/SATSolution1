using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SATUI.MVC.Startup))]
namespace SATUI.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

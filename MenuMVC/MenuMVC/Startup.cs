using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MenuMVC.Startup))]
namespace MenuMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

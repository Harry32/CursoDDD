using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CursoDDD.MVC.Startup))]
namespace CursoDDD.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

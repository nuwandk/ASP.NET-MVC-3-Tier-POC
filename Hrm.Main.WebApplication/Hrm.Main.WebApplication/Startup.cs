using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hrm.Main.WebApplication.Startup))]
namespace Hrm.Main.WebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

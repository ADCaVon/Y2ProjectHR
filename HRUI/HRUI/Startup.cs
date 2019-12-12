using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HRUI.Startup))]
namespace HRUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

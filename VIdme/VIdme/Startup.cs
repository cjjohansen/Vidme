using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VIdme.Startup))]
namespace VIdme
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

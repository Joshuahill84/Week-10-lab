using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(week10lab.Startup))]
namespace week10lab
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

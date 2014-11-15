using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Creddit.Startup))]
namespace Creddit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

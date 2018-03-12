using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fundamentals.Startup))]
namespace Fundamentals
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5MoviesTurtorial.Startup))]
namespace MVC5MoviesTurtorial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

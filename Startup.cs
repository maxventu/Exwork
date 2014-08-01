using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Exwork.Startup))]
namespace Exwork
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

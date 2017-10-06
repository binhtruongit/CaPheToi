using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CaPheToi.Startup))]
namespace CaPheToi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

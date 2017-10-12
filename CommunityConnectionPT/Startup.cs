using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CommunityConnectionPT.Startup))]
namespace CommunityConnectionPT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

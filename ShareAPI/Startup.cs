using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShareAPI.Startup))]
namespace ShareAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

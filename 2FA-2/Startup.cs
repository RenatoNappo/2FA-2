using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2FA_2.Startup))]
namespace _2FA_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

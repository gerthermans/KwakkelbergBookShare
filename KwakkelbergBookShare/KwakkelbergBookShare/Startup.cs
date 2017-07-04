using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KwakkelbergBookShare.Startup))]
namespace KwakkelbergBookShare
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

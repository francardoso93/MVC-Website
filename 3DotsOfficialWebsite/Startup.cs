using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_3DotsOfficialWebsite.Startup))]
namespace _3DotsOfficialWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

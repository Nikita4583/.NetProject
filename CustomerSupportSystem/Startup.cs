using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CustomerSupportSystem.Startup))]
namespace CustomerSupportSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FidlyAdvanced2.Startup))]
namespace FidlyAdvanced2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

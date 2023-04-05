using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(webformssample.Startup))]
namespace webformssample
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

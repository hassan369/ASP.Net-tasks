using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testing_authentication.Startup))]
namespace testing_authentication
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

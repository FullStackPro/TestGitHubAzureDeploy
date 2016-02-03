using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestGitHubAzureDeploy.Startup))]
namespace TestGitHubAzureDeploy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

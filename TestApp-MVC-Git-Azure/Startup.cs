using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestApp_MVC_Git_Azure.Startup))]
namespace TestApp_MVC_Git_Azure
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

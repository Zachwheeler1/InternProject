using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TFSTest.Startup))]
namespace TFSTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CIT280App.Startup))]
namespace CIT280App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

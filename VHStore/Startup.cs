using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VHStore.Startup))]
namespace VHStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

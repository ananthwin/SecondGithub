using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureMsgQueuingPOC.Startup))]
namespace AzureMsgQueuingPOC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TianWei.Web.Startup))]
namespace TianWei.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FirstDesign.Startup))]
namespace FirstDesign
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

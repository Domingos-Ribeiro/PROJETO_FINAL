using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PROJETO_FINAL.Startup))]
namespace PROJETO_FINAL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

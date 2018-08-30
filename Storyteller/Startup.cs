using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Storyteller.Startup))]
namespace Storyteller
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

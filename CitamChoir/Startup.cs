using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CitamChoir.Startup))]
namespace CitamChoir
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

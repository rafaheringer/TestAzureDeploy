using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(I.Love.Nibo.Startup))]
namespace I.Love.Nibo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

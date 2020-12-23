using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QLTB.Startup))]
namespace QLTB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

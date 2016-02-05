using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sisikaryakan.Startup))]
namespace Sisikaryakan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

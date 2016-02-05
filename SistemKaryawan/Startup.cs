using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SistemKaryawan.Startup))]
namespace SistemKaryawan
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

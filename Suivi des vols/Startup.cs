using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Suivi_des_vols.Startup))]
namespace Suivi_des_vols
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Infraction_2.Startup))]
namespace Infraction_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
           
        }
    }
}



using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvc_auth_SandraJones.Startup))]
namespace mvc_auth_SandraJones
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

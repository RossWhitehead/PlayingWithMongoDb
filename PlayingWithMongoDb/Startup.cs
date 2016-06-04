using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PlayingWithMongoDb.Web.Startup))]
namespace PlayingWithMongoDb.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PlayingWithMongoDb.Startup))]
namespace PlayingWithMongoDb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

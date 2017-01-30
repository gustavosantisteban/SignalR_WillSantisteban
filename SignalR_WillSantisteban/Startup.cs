using Microsoft.Owin;
using Owin;
using SignalR_WillSantisteban.PersistentConnections;

[assembly: OwinStartupAttribute(typeof(SignalR_WillSantisteban.Startup))]
namespace SignalR_WillSantisteban
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapHubs();
            ConfigureAuth(app);
        }
    }
}

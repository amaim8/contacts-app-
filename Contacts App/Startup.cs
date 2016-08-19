using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Contacts_App.Startup))]
namespace Contacts_App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

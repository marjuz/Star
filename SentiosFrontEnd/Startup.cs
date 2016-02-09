using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SentiosFrontEnd.Startup))]
namespace SentiosFrontEnd
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcFSharp.Startup))]
namespace MvcFSharp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

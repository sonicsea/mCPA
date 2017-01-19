using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mCPA.Startup))]
namespace mCPA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

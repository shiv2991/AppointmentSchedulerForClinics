using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(AppScheduler.StartupOwin))]

namespace AppScheduler
{
    public partial class StartupOwin
    {
        public void Configuration(IAppBuilder app)
        {
            //AuthStartup.ConfigureAuth(app);
        }
    }
}

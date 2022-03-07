
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Webgrid.Startup))]
namespace MVC_Webgrid
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
           
        }

        
    }
}

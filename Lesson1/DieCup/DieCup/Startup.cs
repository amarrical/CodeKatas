using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DieCup.Startup))]
namespace DieCup
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}

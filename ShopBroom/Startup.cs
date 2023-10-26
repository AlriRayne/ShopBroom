using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShopBroom.Startup))]
namespace ShopBroom
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

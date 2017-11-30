using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IPG512F1_Keanan_Flowerday.Startup))]
namespace IPG512F1_Keanan_Flowerday
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

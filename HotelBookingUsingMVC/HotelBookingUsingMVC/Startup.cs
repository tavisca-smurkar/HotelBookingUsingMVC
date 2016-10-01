using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HotelBookingUsingMVC.Startup))]
namespace HotelBookingUsingMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CustomersOrders.Startup))]
namespace CustomersOrders
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Hiper.Application;
using Hiper.Application.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace Hiper.WebApp
{
    public partial class Startup
    {
        public void AddAppScope()
        {
            _services.AddScoped<ICustomerApp, CustomerApp>();
        }
    }
}

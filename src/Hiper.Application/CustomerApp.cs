using Hiper.Application.Contracts;
using Hiper.Application.Models;
using Hiper.SharedKernel.Contexts;

namespace Hiper.Application
{
    public class CustomerApp : BaseApp<CustomerModel> , ICustomerApp
    {
        public CustomerApp(CommonContext commonContext) : base(commonContext)
        {

        }
    }
}

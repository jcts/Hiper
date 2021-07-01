using AutoMapper;
using Hiper.Application.Contracts;
using Hiper.Application.Models;
using Hiper.SharedKernel.Contexts;
using System.Collections.Generic;
using System.Linq;

namespace Hiper.Application
{
    public class CustomerApp : BaseApp<CustomerModel> , ICustomerApp
    {
        IMapper _mapper;

        public CustomerApp(CommonContext commonContext, IMapper mapper) : base(commonContext, mapper)
        {
            _mapper = mapper;
        }

        public new ICollection<CustomerModel> GetAll()
        {
            var entities = _commonContext.Customers.ToList();

            return _mapper.Map<List<CustomerModel>>(entities);
        }
    }
}

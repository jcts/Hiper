using AutoMapper;
using Hiper.Application.Contracts;
using Hiper.Application.Models;
using Hiper.SharedKernel.Contexts;
using System;
using System.Collections.Generic;

namespace Hiper.Application
{
    public class OrderApp : IOrderApp
    {
        readonly OrderContext _orderContext;
        readonly IMapper _mapper;

        public OrderApp(OrderContext orderContext, IMapper mapper)
        {
            _orderContext = orderContext;
            _mapper = mapper;
        }
        public void Create(OrderViewModel model)
        {
            throw new NotImplementedException();
        }

        public void Delete(OrderViewModel model)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _orderContext.Dispose();
            GC.SuppressFinalize(this);
        }

        public ICollection<OrderViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public OrderViewModel GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public OrderViewModel GetByOrderNumber(int number)
        {
            throw new NotImplementedException();
        }

        public void Update(OrderViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}

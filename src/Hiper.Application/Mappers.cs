using Hiper.Application.Models;
using Hiper.Domain.Entities;

namespace Hiper.Application
{
    public static class Mappers
    {
        public static AutoMapper.MapperConfiguration Mappings
            => new(cfg =>
            {
                _ = cfg.CreateMap<Customer, CustomerModel>();
                _ = cfg.CreateMap<CustomerModel, Customer>();

                _ = cfg.CreateMap<Order, OrderViewModel>();
                _ = cfg.CreateMap<OrderViewModel, Order>();
            });
    }
}
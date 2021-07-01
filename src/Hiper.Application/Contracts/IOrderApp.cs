using Hiper.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiper.Application.Contracts
{
    public interface IOrderApp : IBaseApp<OrderViewModel>
    {
        OrderViewModel GetByOrderNumber(int number);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainClasses.Models;

namespace ServiceLayer.Services
{
    public interface IOrderService
    {
        IList<Order> GetAllOrders();
        Order Get(int id);
        Order Add(Order order);
        void Remove(int id);
        bool Update(Order order);

    }
}

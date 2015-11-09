using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Context;
using DomainClasses.Models;
using ServiceLayer.Services;

namespace ServiceLayer.EFServices
{
    public class EfOrderService : IOrderService
    {

        IUnitOfWork _uow;
        IDbSet<Order> _order;
        public EfOrderService(IUnitOfWork uow)
        {
            _uow = uow;
            _order = _uow.Set<Order>();
        }


        public IList<Order> GetAllOrders()
        {
            throw new NotImplementedException();
        }

        public Order Get(int id)
        {
            throw new NotImplementedException();
        }

        public Order Add(Order order)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Order order)
        {
            throw new NotImplementedException();
        }
    }
}

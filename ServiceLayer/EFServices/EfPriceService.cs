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
    public class EfPriceService : IPriceService
    {

        IUnitOfWork _uow;
        IDbSet<Price> _price;
        public EfPriceService(IUnitOfWork uow)
        {
            _uow = uow;
            _price = _uow.Set<Price>();
        }


        public IList<Price> GetAllPrices()
        {
            throw new NotImplementedException();
        }

        public Price Get(int id)
        {
            throw new NotImplementedException();
        }

        public Price Add(Price price)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Price price)
        {
            throw new NotImplementedException();
        }
    }
}

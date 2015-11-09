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
    public class EfValueService : IValueService
    {

        IUnitOfWork _uow;
        IDbSet<Value> _value;
        public EfValueService(IUnitOfWork uow)
        {
            _uow = uow;
            _value = _uow.Set<Value>();
        }


        public IList<Value> GetAllValues()
        {
            throw new NotImplementedException();
        }

        public Value Get(int id)
        {
            throw new NotImplementedException();
        }

        public Value Add(Value value)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Value value)
        {
            throw new NotImplementedException();
        }
    }
}

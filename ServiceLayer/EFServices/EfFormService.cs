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
    public class EfFormService : IFormService
    {

        IUnitOfWork _uow;
        IDbSet<Form> _form;
        public EfFormService(IUnitOfWork uow)
        {
            _uow = uow;
            _form = _uow.Set<Form>();
        }


        public IList<Form> GetAllForms()
        {
            throw new NotImplementedException();
        }

        public Form Get(int id)
        {
            throw new NotImplementedException();
        }

        public Form Add(Form form)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Form form)
        {
            throw new NotImplementedException();
        }
    }
}

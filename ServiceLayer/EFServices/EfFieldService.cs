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
    public class EfFieldService : IFieldService
    {

        IUnitOfWork _uow;
        IDbSet<Field> _field;
        public EfFieldService(IUnitOfWork uow)
        {
            _uow = uow;
            _field = _uow.Set<Field>();
        }


        public IList<Field> GetAllFields()
        {
            var list = _field.ToList();
            return list;
        }

        public IList<Field> GetFieldsById(int id)
        {
            var list = _field.Where(f => f.FormId == id).ToList();
            return list;
        } 

        public Field Get(int id)
        {
            throw new NotImplementedException();
        }

        public Field Add(Field field)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Field field)
        {
            throw new NotImplementedException();
        }
    }
}

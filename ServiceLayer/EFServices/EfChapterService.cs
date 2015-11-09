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
    public class EfChapterService : IChapterService
    {

        IUnitOfWork _uow;
        IDbSet<Chapter> _chapter;
        public EfChapterService(IUnitOfWork uow)
        {
            _uow = uow;
            _chapter = _uow.Set<Chapter>();
        }


        public IList<Chapter> GetAllChapters()
        {
            throw new NotImplementedException();
        }

        public Chapter Get(int id)
        {
            throw new NotImplementedException();
        }

        public Chapter Add(Chapter chapter)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Chapter chapter)
        {
            throw new NotImplementedException();
        }
    }
}

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
    public class EfGalleryService : IGalleryService
    {

        IUnitOfWork _uow;
        IDbSet<Gallery> _gallery;
        public EfGalleryService(IUnitOfWork uow)
        {
            _uow = uow;
            _gallery = _uow.Set<Gallery>();
        }


        public IList<Gallery> GetAllGallerys()
        {
            var list = _gallery.ToList();
            return list;
        }

        public Gallery Get(int id)
        {
            throw new NotImplementedException();
        }

        public Gallery Add(Gallery gallery)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Gallery gallery)
        {
            throw new NotImplementedException();
        }
    }
}

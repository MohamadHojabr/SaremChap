using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DataLayer.Context;
using DomainClasses.Models;
using ServiceLayer.Services;

namespace ServiceLayer.EFServices
{
    public class EfGalleryItemService : IGalleryItemService
    {
        IUnitOfWork _uow;
        IDbSet<GalleryItem> _galleryItem;
        public EfGalleryItemService(IUnitOfWork uow)
        {
            _uow = uow;
            _galleryItem = _uow.Set<GalleryItem>();
        }

       public IList<GalleryItem> GetAllGalleryItems()
       {

           var list =_galleryItem.Include(g => g.Gallery).OrderBy(g => g.GalleryId).ToList();
           return list;
       }

        public GalleryItem Get(int galleryItemId)
        {
            var galleryItem = _galleryItem.Find(galleryItemId);
            if (galleryItem == null)
            {
                //throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return galleryItem;

           
        }

        public GalleryItem Add(GalleryItem galleryItem)
        {
            if (galleryItem == null)
            {
                throw new ArgumentNullException("galleryItem");
            }

            _galleryItem.Add(galleryItem);
            return galleryItem;
        }

        public void Remove(int galleryItemId)
        {
            throw new NotImplementedException();
        }

        public bool Update(GalleryItem galleryItem)
        {
            throw new NotImplementedException();
        }
    }
}

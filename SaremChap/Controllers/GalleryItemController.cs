using DataLayer.Context;
using DomainClasses.Models;
using ServiceLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Tracing;

namespace SaremChap.Controllers
{
    public class GalleryItemController : ApiController
    {
        private IUnitOfWork _uow;
        private IGalleryItemService _galleryItemService;
        private IGalleryService _galleryService;

        

        public GalleryItemController(IUnitOfWork uow, IGalleryItemService galleryItemService, IGalleryService galleryService)
        {
            _uow = uow;
            _galleryItemService = galleryItemService;
            _galleryService = galleryService;
        }

        public List<GalleryItem> GetAllGalleryItem()
        {
            var gallerylist = _galleryItemService.GetAllGalleryItems().ToList();
            return gallerylist;
        }
        [Route("getAllGallery/{id}")]
        public List<Gallery> GetAllGalleries(int id)
        {
            var list = _galleryService.GetAllGallerys().Where(g=>g.GalleryId==id).ToList();
            return list;
        } 

        public List<GalleryItem> GetGalleryItemByCatogory(string category)
        {
            var gallerylist = _galleryItemService.GetAllGalleryItems().Where(
                p => string.Equals(p.Name, category, StringComparison.OrdinalIgnoreCase));
            return gallerylist.ToList();
        }


        public GalleryItem GetGalleryItem(int id)
        {
            var item = _galleryItemService.Get(id);

            return item;
        }
    }
}

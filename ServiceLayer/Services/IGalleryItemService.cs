using DomainClasses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public interface IGalleryItemService
    {
        IList<GalleryItem> GetAllGalleryItems();
        GalleryItem Get(int galleryItemId);
        GalleryItem Add(GalleryItem galleryItem);
        void Remove(int galleryItemId);
        bool Update(GalleryItem galleryItem);
    }
}

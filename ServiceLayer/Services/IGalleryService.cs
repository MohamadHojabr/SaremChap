using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainClasses.Models;

namespace ServiceLayer.Services
{
    public interface IGalleryService
    {
        IList<Gallery> GetAllGallerys();
        Gallery Get(int id);
        Gallery Add(Gallery gallery);
        void Remove(int id);
        bool Update(Gallery gallery);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainClasses.Models;

namespace ServiceLayer.Services
{
    public interface IChapterService
    {
        IList<Chapter> GetAllChapters();
        Chapter Get(int id);
        Chapter Add(Chapter chapter);
        void Remove(int id);
        bool Update(Chapter chapter);

    }
}

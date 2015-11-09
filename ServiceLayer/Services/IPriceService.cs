using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainClasses.Models;

namespace ServiceLayer.Services
{
    public interface IPriceService
    {
        IList<Price> GetAllPrices();
        Price Get(int id);
        Price Add(Price price);
        void Remove(int id);
        bool Update(Price price);

    }
}

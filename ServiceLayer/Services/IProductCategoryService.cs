using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainClasses.Models;

namespace ServiceLayer.Services
{
    public interface IProductCategoryService
    {
        IList<ProductCategory> GetAllProductCategorys();
        IList<ProductCategory> GetProductCategoryByName(string name);
        ProductCategory Get(int id);
        ProductCategory Add(ProductCategory productCategory);
        void Remove(int id);
        bool Update(ProductCategory productCategory);

    }
}

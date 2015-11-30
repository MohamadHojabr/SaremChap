using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainClasses.Models;

namespace ServiceLayer.Services
{
    public interface IProductService
    {
        IList<Product> GetAllProducts();
        Product GetProductByNameAndId(string name, int id);
        Product Get(int? id);
        Product Add(Product product);
        void Remove(int id);
        void Update(Product product);

    }
}

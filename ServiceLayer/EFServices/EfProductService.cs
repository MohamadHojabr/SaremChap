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
    public class EfProductService : IProductService
    {

        IUnitOfWork _uow;
        IDbSet<Product> _product;
        public EfProductService(IUnitOfWork uow)
        {
            _uow = uow;
            _product = _uow.Set<Product>();
        }


        public IList<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Product GetProductByNameAndId(string name , int id)
        {
            var product = _product.FirstOrDefault(p => p.Name.Equals(name) && p.ProductId == id);

            return product;
        } 

        public Product Get(int? id)
        {
            var product = _product.Include(p => p.Files).SingleOrDefault(p => p.ProductId == id);
            return product;
        }

        public Product Add(Product product)
        {
            _product.Add(product);
           
            return product;
        }

        public void Remove(int id)
        {
            Product product = _product.Find(id);
            _product.Remove(product);
        }

        public bool Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}

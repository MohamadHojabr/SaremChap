﻿using System;
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
    public class EfProductCategoryService : IProductCategoryService
    {

        IUnitOfWork _uow;
        IDbSet<ProductCategory> _productCategory;
        public EfProductCategoryService(IUnitOfWork uow)
        {
            _uow = uow;
            _productCategory = _uow.Set<ProductCategory>();
        }


        public IList<ProductCategory> GetAllProductCategorys()
        {
            throw new NotImplementedException();
        }

        public ProductCategory Get(int id)
        {
            throw new NotImplementedException();
        }

        public ProductCategory Add(ProductCategory productCategory)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(ProductCategory productCategory)
        {
            throw new NotImplementedException();
        }
    }
}
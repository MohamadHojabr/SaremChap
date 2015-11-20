using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLayer.Context;
using ServiceLayer.Services;

namespace SaremChap.Controllers
{
    public class ServicesController : Controller
    {
        private IUnitOfWork _uow;
        private IProductCategoryService _productCategoryService;
        private IProductService _productService;
        public ServicesController(IUnitOfWork uow, IProductCategoryService productCategoryService, IProductService productService)
        {
            _uow = uow;
            _productCategoryService = productCategoryService;
            _productService = productService;
        }
        [ChildActionOnly]
        public ActionResult ProductCategoryInMenu()
        {
            var productCategories = _productCategoryService.GetAllProductCategorys().ToList();
            return PartialView("Partials/ProductCategoryInMenu", productCategories);
        }

        public ActionResult Index(string name)
        {
            var list = _productCategoryService.GetAllProductCategorys();
            return View(list);
        }

        public ActionResult Service(string name)
        {
            var list = _productCategoryService.GetProductCategoryByName(name);
            return View(list);
        }

        public ActionResult ServiceDetail(int id , string name)
        {
            var list = _productService.GetProductByNameAndId(name, id);
            return View(list);
        }




	}
}
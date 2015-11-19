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

	}
}
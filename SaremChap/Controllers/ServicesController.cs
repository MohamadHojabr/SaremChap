using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLayer.Context;
using DomainClasses.Enums;
using DomainClasses.Models;
using ServiceLayer.Services;
using File = DomainClasses.Models.File;

namespace SaremChap.Controllers
{
    public class ServicesController : Controller
    {
        private IUnitOfWork _uow;
        private IProductCategoryService _productCategoryService;
        private IProductService _productService;

        private string fullName
        {
            get
            {
                string serverpath = "/Images/Services/";
                return serverpath;
            }
        }
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

        public ActionResult Create()
        {
            ViewBag.ProductCategoryID = new SelectList(_productCategoryService.GetAllProductCategorys(), "ProductCategoryID", "name");

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product, HttpPostedFileBase upload)
        {
            if (upload != null && upload.ContentLength > 0)
            {
                var photo = new File
                {
                    FileName = System.IO.Path.GetFileName(upload.FileName),
                    FileType = FileType.Photo
                };
                product.File = new List<File>();
                product.File.Add(photo);
            }
            _productService.Add(product);
            _uow.SaveChanges();

            var originalDirectory = new DirectoryInfo(string.Format("{0}Images\\Services", Server.MapPath(@"\")));

            string pathString = System.IO.Path.Combine(originalDirectory.ToString(), "service");

            var fileName1 = Path.GetFileName(upload.FileName);

            bool isExists = System.IO.Directory.Exists(pathString);

            if (!isExists)
                System.IO.Directory.CreateDirectory(pathString);

            var path = string.Format("{0}\\{1}", pathString, upload.FileName);
            upload.SaveAs(path);


            ViewBag.ProductCategoryID = new SelectList(_productCategoryService.GetAllProductCategorys(), "ProductCategoryID", "name");

            return View();
        }

	}
}
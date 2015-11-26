using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DataLayer.Context;
using DomainClasses.Enums;
using DomainClasses.Models;
using ServiceLayer.Services;
using File = DomainClasses.Models.Files;

namespace SaremChap.Controllers
{
    public class ServicesController : Controller
    {
        private IUnitOfWork _uow;
        private IProductCategoryService _productCategoryService;
        private IProductService _productService;

        private string Directory
        {
            get
            {
                var originalDirectory = new DirectoryInfo(string.Format("{0}Images\\Services", Server.MapPath(@"\"))).ToString();
                return originalDirectory;
            }
        }

        private string Path
        {
            get
            {
                string pathString = System.IO.Path.Combine(Directory, "service");
                return pathString;
            }
        }

        private bool PathIsExists
        {
            get
            {
                if (System.IO.Directory.Exists(Path)) return true;
                return false;
            }
        }

        private void CreatePath()
        {
            if (!PathIsExists)
            {
                System.IO.Directory.CreateDirectory(Path);
            }
            else
            {
                //todo
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
                    FileName = Guid.NewGuid().ToString() + System.IO.Path.GetExtension(upload.FileName),
                    FileType = FileType.Photo
                };
                product.Files = new List<File>();
                product.Files.Add(photo);
                CreatePath();
                var path = string.Format("{0}\\{1}", Path, photo.FileName);
                upload.SaveAs(path);

            }
            _productService.Add(product);
            _uow.SaveChanges();



            ViewBag.ProductCategoryID = new SelectList(_productCategoryService.GetAllProductCategorys(), "ProductCategoryID", "name");

            return View();
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var product = _productService.Get(id);
            if (product == null)
            {
                return HttpNotFound();
            }

            ViewBag.ProductCategoryID = new SelectList(_productCategoryService.GetAllProductCategorys(), "ProductCategoryID", "name");
            return View(product);
        }

        // POST: /panel/Product/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProductID,ProductCategoryID,name,imege,describtion")] Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.Update(product);
                _uow.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ProductCategoryID = new SelectList(_productCategoryService.GetAllProductCategorys(), "ProductCategoryID", "name");
            return View(product);
        }

        public ActionResult Detail(int id)
        {
            var service = _productService.Get(id);
            return View(service);
        }

	}
}
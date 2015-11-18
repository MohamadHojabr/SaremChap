using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLayer.Context;
using DomainClasses.Enums;
using ServiceLayer.Services;

namespace SaremChap.Controllers
{
    public class HomeController : Controller
    {
        private IUnitOfWork _uow;
        private ISubjectService _subjectService;
        private IProductCategoryService _productCategoryService;

        public HomeController(IUnitOfWork uow, ISubjectService subjectService, IProductCategoryService categoryService)
        {
            _uow = uow;
            _subjectService = subjectService;
            _productCategoryService = categoryService;
        }
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        [ChildActionOnly]
        public ActionResult SlideShow()
        {
            var slideShow = _subjectService.GetAllSubjects().Where(s => s.Status == SubjectStatus.Slideshow);
            return PartialView("Partials/slideShow",slideShow);
        }
        [ChildActionOnly]
        public ActionResult Quicklook()
        {
            return PartialView("Partials/Quicklook");
        }

        [ChildActionOnly]
        public ActionResult TopContent()
        {
            var topContent = _subjectService.GetAllSubjects().FirstOrDefault(s => s.Status == SubjectStatus.Special);

            return PartialView("Partials/topContent", topContent);
        }

        [ChildActionOnly]
        public ActionResult BriefInfo()
        {
            return PartialView("Partials/briefInfo");
        }

        [ChildActionOnly]
        public ActionResult TypesOfServices()
        {
            var services = _productCategoryService.GetAllProductCategorys().ToList();

            return PartialView("Partials/typesOfServices", services);
        
        }

        [ChildActionOnly]
        public ActionResult Testimonials()
        {
            var testimonials = _subjectService.GetAllSubjects().Where(x => x.Status != SubjectStatus.Products)
                .OrderByDescending(x => x.SubjectDate)
                .Take(10);

            return PartialView("Partials/testimonials", testimonials);
        
        }

        public ActionResult AboutUs()
        {
            return View();
        }

        public ActionResult TermsOfUse()
        {
            return View();
        }

        public ActionResult ContactUs()
        {
            return View();
        }

        public ActionResult Privacy()
        {
            return View();
        }
        public ActionResult AccountNumber()
        {
            return View();
        }


    }
}

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

        public HomeController(IUnitOfWork uow, ISubjectService subjectService)
        {
            _uow = uow;
            _subjectService = subjectService;
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
    }
}

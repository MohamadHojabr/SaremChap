using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLayer.Context;
using ServiceLayer.Services;

namespace SaremChap.Controllers
{
    public class ContentsController : Controller
    {
        private IUnitOfWork _uow;
        private IChapterService _chapterService;
        private ISubjectService _subjectService;

        public ContentsController(IUnitOfWork ouw, ISubjectService subjectService, IChapterService chapterService)
        {
            _uow = ouw;
            _subjectService = subjectService;
            _chapterService = chapterService;
        }
        //
        // GET: /Contents/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Subjects(string name)
        {
            var list = _subjectService.GetSubjectsByChapter(name);
            return View(list);
        }
	}
}
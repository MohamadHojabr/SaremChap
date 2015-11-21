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
        [ChildActionOnly]
        public ActionResult ChapterInMenu()
        {
            var chapter = _chapterService.GetAllChapters();
            return PartialView("Partials/ChapterInMenu", chapter);
        }

        [ChildActionOnly]
        public ActionResult PartialChapters()
        {
            var chapter = _chapterService.GetAllChapters().Take(4);
            return PartialView("Partials/PartialChapters", chapter);
        }

        [ChildActionOnly]
        public ActionResult PartialLatesSubjects()
        {
            var subjects = _subjectService.GetAllSubjects().OrderBy(s => s.SubjectDate).Take(4);
            return PartialView("Partials/PartialLatesSubjects", subjects);
        }

        public ActionResult Subjects(string chapter)
        {
            var list = _subjectService.GetSubjectsByChapter(chapter);
            return View(list);
        }

        public ActionResult Subject(string lead)
        {
            var list = _subjectService.GetSubjectByLead(lead);
            return View(list);
        }

	}
}
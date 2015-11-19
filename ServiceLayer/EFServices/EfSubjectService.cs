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
    public class EfSubjectService : ISubjectService
    {
        IUnitOfWork _uow;
        IDbSet<Subject> _subject;
        public EfSubjectService(IUnitOfWork uow)
        {
            _uow = uow;
            _subject = _uow.Set<Subject>();
        }


        public IList<Subject> GetAllSubjects()
        {
            var list = _subject.Include(s => s.Chapter).OrderBy(s => s.SubjectDate).ToList();
            return list;
        }

        public IList<Subject> GetSubjectsByChapter(string name)
        {
            var list = _subject.Where(s=>s.Chapter.Name.Equals(name)).OrderBy(s => s.SubjectDate).ToList();
            return list;
        }


        public Subject Get(int id)
        {
            throw new NotImplementedException();
        }

        public Subject Add(Subject subject)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Subject subject)
        {
            throw new NotImplementedException();
        }
    }
}

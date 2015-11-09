using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainClasses.Models;

namespace ServiceLayer.Services
{
    public interface ISubjectService
    {
        IList<Subject> GetAllSubjects();
        Subject Get(int id);
        Subject Add(Subject subject);
        void Remove(int id);
        bool Update(Subject subject);

    }
}

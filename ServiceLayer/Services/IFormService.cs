using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainClasses.Models;

namespace ServiceLayer.Services
{
    public interface IFormService
    {
        IList<Form> GetAllForms();
        Form Get(int id);
        Form Add(Form form);
        void Remove(int id);
        bool Update(Form form);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainClasses.Models;

namespace ServiceLayer.Services
{
    public interface IFieldService
    {
        IList<Field> GetAllFields();
        IList<Field> GetFieldsById(int id);
        Field Get(int id);
        Field Add(Field field);
        void Remove(int id);
        bool Update(Field field);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainClasses.Models;

namespace ServiceLayer.Services
{
    public interface IValueService
    {
        IList<Value> GetAllValues();
        Value Get(int id);
        Value Add(Value value);
        void Remove(int id);
        bool Update(Value value);

    }
}

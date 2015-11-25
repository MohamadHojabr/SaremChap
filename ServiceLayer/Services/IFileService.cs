using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DomainClasses.Models;

namespace ServiceLayer.Services
{
    public interface IFileService
    {
        IList<Files> GetAllFiles();
        Files Get(int id);
        Files GetByIdAndType(int id, Enum type);
        Files Add(Files file);
        Files Remove(int id);
        Files Detail(int id);
    }
}

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
        IList<File> GetAllFiles();
        File Get(int id);
        File GetByIdAndType(int id, Enum type);
        File Add(File file);
        File Remove(int id);
        File Detail(int id);
    }
}

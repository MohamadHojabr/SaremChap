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
    public class EfFileService : IFileService
    {
        IUnitOfWork _uow;
        IDbSet<File> _file;
        public EfFileService(IUnitOfWork uow)
        {
            _uow = uow;
            _file = _uow.Set<File>();
        }
        public IList<File> GetAllFiles()
        {
            throw new NotImplementedException();
        }

        public File Get(int id)
        {
            throw new NotImplementedException();
        }

        public File GetByIdAndType(int id, Enum type)
        {
            throw new NotImplementedException();
        }

        public File Add(File file)
        {
            _file.Add(file);
           
            return file;
        }

        public File Remove(int id)
        {
            throw new NotImplementedException();
        }

        public File Detail(int id)
        {
            throw new NotImplementedException();
        }
    }
}

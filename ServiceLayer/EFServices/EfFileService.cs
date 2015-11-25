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
        IDbSet<Files> _file;
        public EfFileService(IUnitOfWork uow)
        {
            _uow = uow;
            _file = _uow.Set<Files>();
        }
        public IList<Files> GetAllFiles()
        {
            throw new NotImplementedException();
        }

        public Files Get(int id)
        {
            throw new NotImplementedException();
        }

        public Files GetByIdAndType(int id, Enum type)
        {
            throw new NotImplementedException();
        }

        public Files Add(Files file)
        {
            _file.Add(file);
           
            return file;
        }

        public Files Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Files Detail(int id)
        {
            throw new NotImplementedException();
        }
    }
}

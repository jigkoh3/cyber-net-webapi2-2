using DAL.Entity.Models;
using DAL.Repository;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.ModelBinding;

namespace BLL.Service
{
    public interface IUsersService : IDisposable
    {
        IQueryable<Users> GetUsers();
        Users GetUsers(string id);
        void CreateUsers(Users users);
        void UpdateUsers(Users users);
        void DeleteUsers(string id);
    }

    public class UsersService : IUsersService
    {
        private readonly IUnitOfWork _unitOfWork;
        public UsersService([Dependency("UnitOfWork")] IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();
        }



        public IQueryable<Users> GetUsers()
        {
            return _unitOfWork.Repository<Users>().Query().Get();
        }

        public Users GetUsers(string id)
        {
            return _unitOfWork.Repository<Users>().Find(id);
        }

        public void CreateUsers(Users users)
        {
            users.Created = DateTime.Now;
            _unitOfWork.Repository<Users>().Insert(users);
            _unitOfWork.Save();
        }

        public void UpdateUsers(Users users)
        {
            _unitOfWork.Repository<Users>().Update(users);
            _unitOfWork.Save();
        }

        public void DeleteUsers(string id)
        {
            _unitOfWork.Repository<Users>().Delete(id);
            _unitOfWork.Save();
        }



    }
}


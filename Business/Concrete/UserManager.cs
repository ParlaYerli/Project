using Business.Abstract;
using DataAccess.Abstract;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserRepository _repository;

        public UserManager(IUserRepository repository)
        {
            _repository = repository;
        }

        public void Add(User user)
        {
            _repository.Add(user);
        }

        public void Delete(User user)
        {
            _repository.Delete(user);
        }

        public User GetById(int userId)
        {
           return _repository.Get(i=>i.Id==userId);
        }

        public List<User> GetList()
        {
            return _repository.GetList().ToList();
        }

        public void Update(User user)
        {
             _repository.Update(user);
        }
    }
}

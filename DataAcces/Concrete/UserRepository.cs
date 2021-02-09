
using Common.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class UserRepository : EfEntityRepositoryBase<User, UserContext>, IUserRepository
    {
    }
}

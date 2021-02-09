
using Common.DataAccess.EntityFramework;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IUserRepository: IEntityRepository<User>
    {
   
    }
}

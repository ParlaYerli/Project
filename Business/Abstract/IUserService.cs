﻿using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<User> GetList();
        User GetById(int userId);
        void Add(User user);
        void Delete(User user);
        void Update(User user);
    }
}

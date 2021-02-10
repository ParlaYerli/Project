using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new UserContext();
            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Users.Count() == 0)
                {
                    context.Users.AddRange(Users);
                }
                context.SaveChanges();
            }
        }
        private static User[] Users = {
            new User(){ Name="parla", LastName="yerli", Email="yerliparla@gmail.com", Job="Software Developer"},
            new User(){ Name="hazal", LastName="yerli", Email="hazal@gmail.com", Job="Software Developer"},
            new User(){ Name="azra", LastName="yerli", Email="azra@gmail.com", Job="Software Developer"},
            new User(){ Name="ömer", LastName="cin", Email="ömer@gmail.com", Job="Software Developer"},
            new User(){ Name="gizem", LastName="bayramoğlu", Email="gizem@gmail.com", Job="Software Developer"},
            new User(){ Name="burcu", LastName="okkalı", Email="burcu@gmail.com", Job="Software Developer"},
            new User(){ Name="beren", LastName="usul", Email="beren@gmail.com", Job="Software Developer"}
        };

    }
}

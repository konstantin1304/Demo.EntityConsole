using Demo.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.AppContext
{

    //DropCreateDatabaseAlways<MyAppDbContext>
    //DropCreateDatabaseIfModelChanges<MyAppDbContext>
    //CreateDatabaseIfNotExists<MyAppDbContext>
    public class MyAppDbContextInitializer : DropCreateDatabaseIfModelChanges<MyAppDbContext>
    {
        protected override void Seed(MyAppDbContext context)
        {
            context.Departments.Add(new Department { Name = "PROGRAMMING" });
            context.Departments.Add(new Department { Name = "TESTING" });
            context.SaveChanges();
        }
    }
}

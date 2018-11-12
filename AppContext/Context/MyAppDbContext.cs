using Demo.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;


namespace Demo.AppContext
{
    public class MyAppDbContext:DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        public MyAppDbContext(string ConnStrOrDatabaseName)
            :base(ConnStrOrDatabaseName)
        {
            Database.SetInitializer(new MyAppDbContextInitializer());
        }
    }
 
}

using Demo.AppContext;
using Demo.Repositoties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.UnitOfWork
{
    public static class Unit
    {
        private static MyAppDbContext _context;

        static Unit()
        {
            _context = new MyAppDbContext("MyAppConnStr");
            DepartmentsRepository = new DepartmentsRepository(_context);
            TeachersRepository = new TeachersRepository(_context);
        }
        
        public static DepartmentsRepository DepartmentsRepository { get; }
        public static TeachersRepository TeachersRepository { get; }
    }
}

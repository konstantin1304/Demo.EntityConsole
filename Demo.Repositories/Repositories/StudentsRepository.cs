using Demo.EntityConsole.Common;
using Demo.Repositories.Interfaces;
using Entities.App;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Repositories.Repositories
{
    class StudentsRepository : DbRepository<Student>, IStudentsRepository
    {
        public StudentsRepository(DbContext context) : base(context)
        {
        }
    }
    
}

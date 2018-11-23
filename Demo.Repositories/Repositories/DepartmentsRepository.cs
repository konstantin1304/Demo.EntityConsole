using Demo.Entities;
using Demo.EntityConsole.Common;
using Demo.Repositoties;
using System.Data.Entity;

namespace Demo.Repositories
{
    public class DepartmentsRepository : DbRepository<Department>, IDepartmentsRepository
    {
        public DepartmentsRepository(DbContext context) : base(context)
        {
        }
    }
}

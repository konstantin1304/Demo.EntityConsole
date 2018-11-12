using Demo.Entities;
using Demo.EntityConsole.Common;
using System.Data.Entity;

namespace Demo.Repositoties
{
    public class DepartmentsRepository : DbRepository<Department>, IDepartmentsRepository
    {
        public DepartmentsRepository(DbContext context) : base(context)
        {
        }
    }
}

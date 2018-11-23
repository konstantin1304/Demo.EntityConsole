using Demo.Entities;
using Demo.EntityConsole.Common;
using Demo.Repositoties;
using System.Data.Entity;

namespace Demo.Repositories
{
    public class TeachersRepository : DbRepository<Teacher>, ITeachersRepository
    {
        public TeachersRepository(DbContext context) : base(context)
        {
        }
    }
}

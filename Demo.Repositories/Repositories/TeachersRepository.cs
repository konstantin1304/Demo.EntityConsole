using Demo.Entities;
using Demo.EntityConsole.Common;
using System.Data.Entity;

namespace Demo.Repositoties
{
    public class TeachersRepository : DbRepository<Teacher>, ITeachersRepository
    {
        public TeachersRepository(DbContext context) : base(context)
        {
        }
    }
}

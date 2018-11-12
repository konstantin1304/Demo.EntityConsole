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
    class SpecialitiesRepository : DbRepository<Speciality>, ISpecialitiesRepository
    {
        public SpecialitiesRepository(DbContext context) : base(context)
        {
        }
    }
}

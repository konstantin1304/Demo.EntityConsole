using Demo.EntityConsole.Common;
using Demo.Repositories;
using Entities.App;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniverUnitTest
{
    [TestClass]
    public class GroupUnitTest : AbstractTestClass<Group>
    {
        protected override void ChangeModel(Group model)
        {
            model.Name = "TTT";
            _context.SaveChanges();
        }

        protected override Group FindEqualModel(DbRepository<Group> r, Group model)
        {
            return r.AllItems.FirstOrDefault(i =>
              i.Name == model.Name 
              && (i.Speciality == model.Speciality)
             );
        }
        [TestInitialize]
        public override void InitParams()
        {
            dbSet = _context.Groups;
            r = new GroupsRepository(_context);
            model1 = new Group { Name = "AAA", Speciality = _context.Specialities.FirstOrDefault() };
            model2 = new Group { Name = "BBB", Speciality = _context.Specialities.FirstOrDefault() };
        }
    }
}

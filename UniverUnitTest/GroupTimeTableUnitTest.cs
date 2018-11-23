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
    public class GroupTimeTableUnitTest:AbstractTestClass<GroupTimetable>
    {
        protected override void ChangeModel(GroupTimetable model)
        {
            model.Group = null;
            _context.SaveChanges();
        }

        protected override GroupTimetable FindEqualModel(DbRepository<GroupTimetable> r, GroupTimetable model)
        {
            //var b = model.Speciality == null;
            return r.AllItems.FirstOrDefault(i =>
              i.Group == model.Group &&
              i.Timetable==model.Timetable
             //&& (b || i.Speciality.Name == model.Speciality.Name)
             );
        }
        [TestInitialize]
        public override void InitParams()
        {
            dbSet = _context.GroupTimetables;
            r = new GroupTimetablesRepository(_context);
            model1 = new GroupTimetable { Group=_context.Groups.FirstOrDefault(), Timetable=_context.Timetables.FirstOrDefault() };
            model2 = new GroupTimetable { Group = null, Timetable = null };
        }
    }
}

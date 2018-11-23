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
    public class MarkUnitTest : AbstractTestClass<Mark>
    {
        protected override void ChangeModel(Mark model)
        {
            model.MarkStud = 10;
            _context.SaveChanges();
        }

        protected override Mark FindEqualModel(DbRepository<Mark> r, Mark model)
        {
            //var b = model.Speciality == null;
            return r.AllItems.FirstOrDefault(i =>
              i.MarkStud == model.MarkStud &&
              i.Student == model.Student &&
              i.TeachSubj == model.TeachSubj
             //&& (b || i.Speciality.Name == model.Speciality.Name)
             );
        }
        [TestInitialize]
        public override void InitParams()
        {
            dbSet = _context.Marks;
            r = new MarksRepository(_context);
            model1 = new Mark { MarkStud = 8, Student = _context.Students.FirstOrDefault(), TeachSubj = _context.TeachSubjs.FirstOrDefault() };
            model2 = new Mark { MarkStud = 9, Student = _context.Students.FirstOrDefault(), TeachSubj = _context.TeachSubjs.FirstOrDefault() };
        }
    }
}

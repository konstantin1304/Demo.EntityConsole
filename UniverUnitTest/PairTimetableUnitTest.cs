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
    public class PairTimetableUnitTest : AbstractTestClass<PairTimetable>
    {
        protected override void ChangeModel(PairTimetable model)
        {
            model.DayOfTheWeek = 6;
            _context.SaveChanges();
        }

        protected override PairTimetable FindEqualModel(DbRepository<PairTimetable> r, PairTimetable model)
        {
            //var b = model.Speciality == null;
            return r.AllItems.FirstOrDefault(i =>
              i.BeginPair == model.BeginPair &&
              i.EndPair == model.EndPair &&
              i.IsNumerator == model.IsNumerator &&
              i.PairNumber == model.PairNumber &&
              i.DayOfTheWeek == model.DayOfTheWeek
             //&& (b || i.Speciality.Name == model.Speciality.Name)
             );
        }
        [TestInitialize]
        public override void InitParams()
        {
            dbSet = _context.PairTimetables;
            r = new PairTimetablesRepository(_context);
            model1 = new PairTimetable { DayOfTheWeek = 2, BeginPair = DateTime.Now, EndPair = DateTime.Now, PairNumber =3, IsNumerator=true};
            model2 = new PairTimetable { DayOfTheWeek = 2, BeginPair = DateTime.Now, EndPair = DateTime.Now,PairNumber=5 };
        }
    }
}

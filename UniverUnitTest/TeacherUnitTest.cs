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
    public class TeacherUnitTest : AbstractTestClass<Teacher>
    {
        protected override void ChangeModel(Teacher model)
        {
            model.FirstName = "Ignat";
            _context.SaveChanges();
        }

        protected override Teacher FindEqualModel(DbRepository<Teacher> r, Teacher model)
        {
            //var b = model.Speciality == null;
            return r.AllItems.FirstOrDefault(i =>
              i.FirstName == model.FirstName &&
              i.MiddleName == model.MiddleName &&
              i.LastName == model.LastName

             //&& (b || i.Speciality.Name == model.Speciality.Name)
             );
        }
        [TestInitialize]
        public override void InitParams()
        {
            dbSet = _context.Teachers;
            r = new TeachersRepository(_context);
            model1 = new Teacher { FirstName = "Vasily", MiddleName = "Novak", LastName = "Sidorovich" };
            model2 = new Teacher { FirstName = "Petro", MiddleName = "Limak", LastName = "Andreevich" };
        }
    }
}

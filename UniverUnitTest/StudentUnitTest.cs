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
    public class StudentUnitTest : AbstractTestClass<Student>
    {
        protected override void ChangeModel(Student model)
        {
            model.FirstName = "Inokentiy";
            _context.SaveChanges();
        }

        protected override Student FindEqualModel(DbRepository<Student> r, Student model)
        {
            //var b = model.Speciality == null;
            return r.AllItems.FirstOrDefault(i =>
              i.Address == model.Address &&
              i.Birstday == model.Birstday &&
              i.Email == model.Email &&
              i.FirstName == model.FirstName &&
              i.MiddleName == model.MiddleName &&
              i.LastName == model.LastName &&
              i.LogbookNumber == model.LogbookNumber

             //&& (b || i.Speciality.Name == model.Speciality.Name)
             );
        }
        [TestInitialize]
        public override void InitParams()
        {
            dbSet = _context.Students;
            r = new StudentsRepository(_context);
            model1 = new Student { Address=_context.Addresses.FirstOrDefault(),Birstday=DateTime.Now,Email="A@A", FirstName="a", Group=_context.Groups.FirstOrDefault(), LastName="B", LogbookNumber=111, MiddleName="c" };
            model2 = new Student { Address = _context.Addresses.FirstOrDefault(), Birstday = DateTime.Now, Email = "b@A", FirstName = "e", Group = _context.Groups.FirstOrDefault(), LastName = "r", LogbookNumber = 1121, MiddleName = "cd" };
        }
    }
}

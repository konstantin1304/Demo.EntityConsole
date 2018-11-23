﻿using Demo.EntityConsole.Common;
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
    public class PhoneUnitTest : AbstractTestClass<Phone>
    {
        protected override void ChangeModel(Phone model)
        {
            model.PhoneNumber = "00000";
            _context.SaveChanges();
        }

        protected override Phone FindEqualModel(DbRepository<Phone> r, Phone model)
        {
            //var b = model.Speciality == null;
            return r.AllItems.FirstOrDefault(i =>
              i.PhoneNumber == model.PhoneNumber &&
              i.Student == model.Student
             //&& (b || i.Speciality.Name == model.Speciality.Name)
             );
        }
        [TestInitialize]
        public override void InitParams()
        {
            dbSet = _context.Phones;
            r = new PhonesRepository(_context);
            model1 = new Phone { PhoneNumber = "111111", Student = _context.Students.FirstOrDefault() };
            model2 = new Phone { PhoneNumber = "2222222", Student = _context.Students.FirstOrDefault() };
        }
    }
}

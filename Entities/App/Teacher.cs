﻿using Demo.EntityConsole.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Demo.Entities
{
    [Table("tbTeachers")]
    public class Teacher:DbEntity
    {
        [StringLength(64)]
        public string FirstName { get; set; }
        [StringLength(64)]
        public string MiddleName { get; set; }
        [StringLength(64)]
        public string LastName { get; set; }
        public virtual Department Department { get; set; }
        public override string ToString()
        {
            return $"{FirstName} {MiddleName} {LastName}";
        }
               
    }
}

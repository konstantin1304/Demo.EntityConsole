using Demo.Entities;
using Demo.EntityConsole.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.App
{
    public class Student : DbEntity
    {
        [StringLength(64)]
        public string FirstName { get; set; }
        [StringLength(64)]
        public string MiddleName { get; set; }
        [StringLength(64)]
        public string LastName { get; set; }
        public DateTime Birstday { get; set; }
        public int LogbookNumber { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public int GroupId { get; set; }
        public virtual Group Group { get; set; }
        public override string ToString()
        {
            return $"{FirstName} {MiddleName} {LastName}";
        }

    }
}

using Demo.EntityConsole.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.App
{
    [Table("tbPairTimetable")]
    public class PairTimetable : DbEntity
    {
        public int PairNumber { get; set; }
        public bool? IsNumerator { get; set; }
        [Range(1, 7)]
        public int DayOfTheWeek { get; set; }
        public virtual DateTime BeginPair { get; set; }
        public virtual DateTime EndPair { get; set; }
        public virtual List<Timetable> Timetables { get; set; }
        public override string ToString()
        {
            return $"{PairNumber} {IsNumerator} {DayOfTheWeek}";
        }

    }
}

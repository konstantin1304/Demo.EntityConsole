using Demo.EntityConsole.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.App
{
    [Table("tbPairTimetable")]
    class PairTimetable : DbEntity
    {
        [Index(IsUnique = true)]
        public int PairNumber { get; set; }
        public DateTime BeginPair { get; set; }
        public DateTime EndPair { get; set; }
        
    }
}

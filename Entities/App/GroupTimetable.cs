using Demo.EntityConsole.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.App
{
    [Table("tbGroupTimetable")]
    class GroupTimetable : DbEntity
    {
        public int Timetable { get; set; }

//        CREATE TABLE tbGroupTimetable(
//Id INT IDENTITY,
//TimetableId INT NOT NULL,
//GroupsId INT NOT NULL,
//PRIMARY KEY (Id),
//FOREIGN KEY(TimetableId) REFERENCES tbTimetable (Id) ON DELETE CASCADE ON UPDATE CASCADE,
//FOREIGN KEY(GroupsId) REFERENCES tbGroups (Id) ON DELETE CASCADE ON UPDATE CASCADE

    }
}

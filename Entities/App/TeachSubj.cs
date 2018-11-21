using Demo.EntityConsole.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.App
{
    public class TeachSubj : DbEntity
    {
        public int TeachId { get; set; }
        public int SubjId { get; set; }
        public int SpecId { get; set; }
        public virtual List<Mark> Marks { get; set; }
        public virtual Speciality Speciality { get; set; }

        //  TeachId INT NOT NULL,
        //  SubjId INT NOT NULL,
        //  SpecId INT NOT NULL,
        //  FOREIGN KEY(TeachId) REFERENCES tbTeachers(Id) ON DELETE CASCADE ON UPDATE CASCADE,
        //FOREIGN KEY(SubjId) REFERENCES tbSubjects(Id) ON DELETE CASCADE ON UPDATE CASCADE,
        //FOREIGN KEY(SpecId) REFERENCES tbSpec(Id) ON DELETE CASCADE ON UPDATE CASCADE,
        //UNIQUE ( TeachID, SubjId)
    }
}

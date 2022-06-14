using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.InspectionRelated
{
    public class Justification:IEntity
    {
        public int JustificationId { get; set; }
        public string JustificationName { get; set; }
    }
}

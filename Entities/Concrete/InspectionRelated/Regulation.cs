using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.InspectionRelated
{
    public class Regulation:IEntity
    {
        public int RegulationId { get; set; }
        public int RegulationName { get; set; }
    }
}

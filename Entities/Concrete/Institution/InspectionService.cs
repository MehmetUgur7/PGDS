using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Institution
{
    public class InspectionService:IEntity
    {
        public int InspectionServiceId { get; set; }
        public string InspectionServiceName { get; set; }
    }
}

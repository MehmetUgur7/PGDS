using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.InspectionRelated
{
    public class InspectionType:IEntity
    {
        public int InspectionTypeId { get; set; }
        public string InspectionTypeName { get; set; }
    }
}

using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.InspectionRelated
{
    public class SampleInfo:IEntity
    {
        public int SampleInfoId { get; set; }
        public string SampleInfoName { get; set; }
    }
}

using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.InspectorRelated
{
    public class Inspector:IEntity
    {
        public int InspectorId { get; set; }
        public long IdentityNo { get; set; }
        public long RegisterNo { get; set; }
        public string InspectorFirstName { get; set; }
        public string InspectorLastName { get; set; }
        public string TitleName { get; set; }
        public int DistrictId { get; set; }
        public int DirectorshipId { get; set; }
        public int InspectionServiceId { get; set; }

    }
}

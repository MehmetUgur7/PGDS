using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.CompanyRelated
{
    public class CompanyOfficer:IEntity
    {
        public int CompanyOfficerId { get; set; }
        public long CompanyOfficerIdentityNo { get; set; }
        public string CompanyOfficerFirstName { get; set; }
        public string CompanyOfficerLastName { get; set; }
        public string CompanyOfficerTitle { get; set; }

    }
}

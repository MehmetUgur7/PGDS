using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.CompanyRelated
{
    public class Company:IEntity
    {
        public int CompanyId { get; set; }
        public int CompanyTypeId { get; set; }
        public string CompanyName { get; set; }
        public long CompanyFiscalNumber { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }

    }
}

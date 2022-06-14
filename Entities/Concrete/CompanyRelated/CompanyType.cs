using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.CompanyRelated
{
    public class CompanyType:IEntity
    {
        public int CompanyTypeId { get; set; }
        public string CompanyTypeName { get; set; }
    }
}

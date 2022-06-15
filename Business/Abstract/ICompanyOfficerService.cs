using Core.Utilities.Results;
using Entities.Concrete.CompanyRelated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICompanyOfficerService
    {
        IDataResult<List<CompanyOfficer>> GetAll();
        IDataResult<CompanyOfficer> GetById(int companyOfficerId);
    }
}

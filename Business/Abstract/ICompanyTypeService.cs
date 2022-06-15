using Core.Utilities.Results;
using Entities.Concrete.CompanyRelated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICompanyTypeService
    {
        IDataResult<List<CompanyType>> GetAll();
        IDataResult<CompanyType> GetById(int companyTypeId);
    }
}

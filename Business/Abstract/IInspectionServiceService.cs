using Core.Utilities.Results;
using Entities.Concrete.Institution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IInspectionServiceService
    {
        IDataResult<List<InspectionService>> GetAll();
        IDataResult<InspectionService> GetById(int inspectionserviceId);
    }
}

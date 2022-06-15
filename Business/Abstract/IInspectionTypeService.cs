using Core.Utilities.Results;
using Entities.Concrete.InspectionRelated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IInspectionTypeService
    {
        IDataResult<List<InspectionType>> GetAll();
        IDataResult<InspectionType> GetById(int inspectionTypeId);
    }
}

using Core.Utilities.Results;
using Entities.Concrete.InspectionRelated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IJustificationService
    {
        IDataResult<List<Justification>> GetAll();
        IDataResult<Justification> GetById(int justificationId);
    }
}

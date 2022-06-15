using Core.Utilities.Results;
using Entities.Concrete.InspectionRelated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRegulationService
    {
        IDataResult<List<Regulation>> GetAll();
        IDataResult<Regulation> GetById(int regulationId);
    }
}

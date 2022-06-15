using Core.Utilities.Results;
using Entities.Concrete.InspectorRelated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IInspectorService
    {
        IDataResult<List<Inspector>> GetAll();
        IDataResult<Inspector> GetById(int inspectorId);
    }
}

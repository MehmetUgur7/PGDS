using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete.Institution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfInspectionServiceDal : EFEntityRepositoryBase<InspectionService, PgdsContext>, IInspectionServiceDal
    {

    }
}

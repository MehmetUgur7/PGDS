using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete.InspectorRelated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfInspectorDal : EFEntityRepositoryBase<Inspector, PgdsContext>, IInspectorDal
    {

    }
}

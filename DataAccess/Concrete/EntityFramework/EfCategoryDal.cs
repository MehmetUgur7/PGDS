using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete.ProductRelated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EFEntityRepositoryBase<Category, PgdsContext>, ICategoryDal
    {

    }
}

﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete.InspectionRelated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfSampleInfoDal : EFEntityRepositoryBase<SampleInfo, PgdsContext>, ISampleInfoDal
    {

    }
}

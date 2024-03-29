﻿using Core.Utilities.Results;
using Entities.Concrete.Institution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDistrictService
    {
        IDataResult<List<District>> GetAll();
        IDataResult<District> GetById(int districtId);
    }
}

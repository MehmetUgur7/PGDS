using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.InspectionRelated
{
    public class Determination:IEntity
    {
        public int DeterminationId { get; set; }
        public string DeterminationName { get; set; }

    }
}

using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Institution
{
    public class Directorship:IEntity
    {
        public int DirectorshipId { get; set; }
        public string DirectorshipName { get; set; }
    }
}

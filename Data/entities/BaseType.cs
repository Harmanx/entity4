using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.entities
{
    public abstract class BaseType:Base
    {
        public Statuses status { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}

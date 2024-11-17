using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villa.EntityLayer.Entities
{
  public class Counter:BaseEntity
    { 
        public string Title { get; set; } 
        public string Count { get; set; }
    }
}

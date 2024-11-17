using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villa.EntityLayer.Entities
{
    public class Message:BaseEntity
    { 
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string MessageCount { get; set; } 
        public DateTime MessageDate { get; set; }
    }
}

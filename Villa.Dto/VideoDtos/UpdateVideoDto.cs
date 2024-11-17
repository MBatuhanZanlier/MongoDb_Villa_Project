using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villa.Dto.VideoDtos
{
   public class UpdateVideoDto
    { 
        public ObjectId Id { get; set; }
        public string VideoUrl { get; set; }
    }
}

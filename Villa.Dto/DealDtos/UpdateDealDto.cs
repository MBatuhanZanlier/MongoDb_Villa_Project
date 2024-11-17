using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villa.Dto.DealDtos
{
public class UpdateDealDto
    { 
        public ObjectId Id { get; set; }
        public string Type { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Square { get; set; }
        public int RoomCount { get; set; } 
        public int Floor {  get; set; } 
        public bool HasParkingAreA { get; set; }
        public string PaymentType { get; set; }
    }
}

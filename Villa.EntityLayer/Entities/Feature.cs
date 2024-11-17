namespace Villa.EntityLayer.Entities
{
    public class Feature : BaseEntity
    { 
        public string ImageUrl { get; set; } 
        public string Title { get; set; } 
        public string SubTitle { get; set; } 
        public string Square{ get; set; }
        public string Payment{ get; set; }  
        public string PaymentType { get; set; }
        public string Safety { get; set; }
    }
}

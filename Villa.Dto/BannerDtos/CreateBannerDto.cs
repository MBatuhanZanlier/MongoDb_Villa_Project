using MongoDB.Bson;

namespace Villa.Dto.BannerDtos
{
    public class CreateBannerDto
    {
        public string City { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
    }
}

using AutoMapper;
using Villa.Dto.BannerDtos;
using Villa.Dto.ContactDtos;
using Villa.Dto.CounterDtos;
using Villa.Dto.DealDtos;
using Villa.Dto.FeatureDtos;
using Villa.Dto.MessageDtos;
using Villa.Dto.ProductDtos;
using Villa.Dto.QuestDtos;
using Villa.Dto.SubHeaderDtos;
using Villa.Dto.VideoDtos;
using Villa.EntityLayer.Entities;

namespace MongoDb_Villa_Project.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<ResultBannerDto, Banner>().ReverseMap();
            CreateMap<UpdateBannerDto, Banner>().ReverseMap();
            CreateMap<CreateBannerDto, Banner>().ReverseMap();
            CreateMap<GetByIdBannerDto, Banner>().ReverseMap();

            CreateMap<ResultContactDto, Contact>().ReverseMap();
            CreateMap<UpdateContactDto, Contact>().ReverseMap();
            CreateMap<CreateContactDto, Contact>().ReverseMap();
            CreateMap<GetByIdBannerDto, Contact>().ReverseMap();


            CreateMap<ResultCounterDto, Counter>().ReverseMap();
            CreateMap<UpdateCounterDto, Counter>().ReverseMap();
            CreateMap<CreateCounterDto, Counter>().ReverseMap();


            CreateMap<ResultDealDto, Deal>().ReverseMap();
            CreateMap<UpdateDealDto, Deal>().ReverseMap();
            CreateMap<CreateDealDto, Deal>().ReverseMap();

            CreateMap<ResultFeatureDto, Feature>().ReverseMap();
            CreateMap<UpdateFeatureDto, Feature>().ReverseMap();
            CreateMap<CreateFeatureDto, Feature>().ReverseMap();

            CreateMap<ResultMessageDto, Message>().ReverseMap();
            CreateMap<UpdateMessageDto, Message>().ReverseMap();
            CreateMap<CreateMessageDto, Message>().ReverseMap();


            CreateMap<ResultProductDto, Product>().ReverseMap();
            CreateMap<UpdateProductDto, Product>().ReverseMap();
            CreateMap<CreateProductDto, Product>().ReverseMap();


            CreateMap<ResultQuestDto, Quest>().ReverseMap();
            CreateMap<UpdateQuestDto, Quest>().ReverseMap();
            CreateMap<CreateQuestDto, Quest>().ReverseMap();


            CreateMap<ResultVideoDto, Video>().ReverseMap();
            CreateMap<UpdateVideoDto, Video>().ReverseMap();
            CreateMap<CreateVideoDto, Video>().ReverseMap();


            CreateMap<ResultSubHeaderDto, SubHeader>().ReverseMap();
            CreateMap<UpdateSubHeaderDto, SubHeader>().ReverseMap();
            CreateMap<CreateSubHeaderDto, SubHeader>().ReverseMap();
        }
    }
}

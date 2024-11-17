using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Villa.BusinessLayer.Abstract;
using Villa.Dto.BannerDtos;

namespace MongoDb_Villa_Project.ViewComponents.Default_Index
{ 
    
    public class _DefaultBannerComponentPartial : ViewComponent
    { 
        private readonly IBannerService _bannerService;
        private readonly IMapper _mapper;
        public _DefaultBannerComponentPartial(IBannerService bannerService, IMapper mapper)
        {
            _bannerService = bannerService;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        { 
            var values=await _bannerService.TGetListAsync(); 
            var bannerlist= _mapper.Map<List<ResultBannerDto>>(values);
            return View(bannerlist); 
   
        }
    }
}

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Villa.BusinessLayer.Abstract;
using Villa.Dto.VideoDtos;

namespace MongoDb_Villa_Project.ViewComponents.Default_Index
{
    public class _DefaultVideoComponentPartial:ViewComponent
    { 
        private readonly IVideoService _videoService;
        private readonly IMapper _mapper;
        public _DefaultVideoComponentPartial(IVideoService videoService, IMapper mapper)
        {
            _videoService = videoService;
            _mapper = mapper;
        } 
        public async Task<IViewComponentResult> InvokeAsync()
        { 
            var values=await _videoService.TGetListAsync(); 
            var mapping=_mapper.Map<List<ResultVideoDto>>(values);
            return View(mapping);
        }
    }
}

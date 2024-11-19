using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Villa.BusinessLayer.Abstract;
using Villa.Dto.SubHeaderDtos;

namespace MongoDb_Villa_Project.ViewComponents.Default_Index
{
    public class _DefaultSubHeaderComponentPartial : ViewComponent
    {
        private readonly ISubHeaderService _subHeaderService;
        private readonly IMapper _mapper;
        public _DefaultSubHeaderComponentPartial(ISubHeaderService subHeaderService, IMapper mapper)
        {
            _subHeaderService = subHeaderService;
            _mapper = mapper;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _subHeaderService.TGetListAsync();
            var mapping = _mapper.Map<List<ResultSubHeaderDto>>(values);
            return View(mapping);
        }
    }
}

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Villa.BusinessLayer.Abstract;
using Villa.Dto.DealDtos;

namespace MongoDb_Villa_Project.ViewComponents.Default_Index
{
    public class _DefaultDealComponentPartial : ViewComponent
    {
        private readonly IDealService _dealService;
        private readonly IMapper _mapper;
        public _DefaultDealComponentPartial(IDealService dealService, IMapper mapper)
        {
            _dealService = dealService;
            _mapper = mapper;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _dealService.TGetListAsync();
            var mapping = _mapper.Map<List<ResultDealDto>>(values);
            return View(mapping);
        }
    }
}

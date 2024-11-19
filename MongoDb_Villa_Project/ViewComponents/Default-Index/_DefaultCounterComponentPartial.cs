using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Villa.BusinessLayer.Abstract;
using Villa.Dto.CounterDtos;

namespace MongoDb_Villa_Project.ViewComponents.Default_Index
{
    public class _DefaultCounterComponentPartial:ViewComponent
    {
        private readonly ICounterService _counterservice;
        private readonly IMapper _mapper;
        public _DefaultCounterComponentPartial(ICounterService counterservice, IMapper mapper)
        {
            _counterservice = counterservice;
            _mapper = mapper;
        } 
        public async Task<IViewComponentResult> InvokeAsync()
        { 
            var values=await _counterservice.TGetListAsync(); 
            var mapping=_mapper.Map<List<ResultCounterDto>>(values);
            return View(mapping);
        }
    }
}

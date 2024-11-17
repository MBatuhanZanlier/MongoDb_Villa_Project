using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Villa.BusinessLayer.Abstract;
using Villa.Dto.QuestDtos;

namespace MongoDb_Villa_Project.ViewComponents.Default_Index
{
    public class _DefaultQuestComponentPartial:ViewComponent
    {  
        private readonly IQuestService _questService;
        private readonly IMapper _mapper;
        public _DefaultQuestComponentPartial(IQuestService questService, IMapper mapper)
        {
            _questService = questService;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        { 
            var values=await _questService.TGetListAsync(); 
            var result=_mapper.Map<List<ResultQuestDto>>(values);
            return View(result);
        }
    }
}

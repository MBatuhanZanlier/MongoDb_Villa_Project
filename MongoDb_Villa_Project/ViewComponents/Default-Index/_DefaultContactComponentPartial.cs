using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Villa.BusinessLayer.Abstract;
using Villa.Dto.ContactDtos;

namespace MongoDb_Villa_Project.ViewComponents.Default_Index
{
    public class _DefaultContactComponentPartial:ViewComponent
    { 
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;
        public _DefaultContactComponentPartial(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        } 
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values=await _contactService.TGetListAsync(); 
            var mapping=_mapper.Map<List<ResultContactDto>>(values); 
            return View(mapping);   
        }
    }
}

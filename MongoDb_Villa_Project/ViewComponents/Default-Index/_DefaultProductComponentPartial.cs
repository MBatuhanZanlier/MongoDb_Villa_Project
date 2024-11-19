using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Villa.BusinessLayer.Abstract;
using Villa.Dto.ProductDtos;

namespace MongoDb_Villa_Project.ViewComponents.Default_Index
{
    public class _DefaultProductComponentPartial:ViewComponent
    { 
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        public _DefaultProductComponentPartial(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        } 
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _productService.TGetListAsync();  
            var mapping=_mapper.Map<List<ResultProductDto>>(values); 
            return View(mapping);
        }
    }
}

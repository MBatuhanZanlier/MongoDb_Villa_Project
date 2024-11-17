using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Villa.BusinessLayer.Abstract;
using Villa.Dto.FeatureDtos;

namespace MongoDb_Villa_Project.ViewComponents.Default_Index
{

    public class _DefaultFeatureComponentPartial : ViewComponent
    { 
        private readonly IFeatureService _featureService;
        private readonly IMapper _mapper;
        public _DefaultFeatureComponentPartial(IFeatureService featureService, IMapper mapper)
        {
            _featureService = featureService;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync()  
        {
            var values = await _featureService.TGetListAsync(); 
            var featureList=_mapper.Map<List<ResultFeatureDto>>(values);
            return View(featureList);  
        
        }
    }
}

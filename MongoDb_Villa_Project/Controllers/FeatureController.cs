using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Villa.BusinessLayer.Abstract;
using Villa.Dto.FeatureDtos;
using Villa.EntityLayer.Entities;

namespace MongoDb_Villa_Project.Controllers
{
    public class FeatureController : Controller
    { 
        private readonly IFeatureService _FeatureService;
        private readonly IMapper _mapper;
    

        public FeatureController(IMapper mapper, IFeatureService FeatureService)
        {
            _mapper = mapper;
            _FeatureService = FeatureService;
        }


        public async Task<IActionResult> Index()
        {
            var values = await _FeatureService.TGetListAsync();
            var FeatureList = _mapper.Map<List<ResultFeatureDto>>(values);
            return View(FeatureList);
        }
        [HttpGet]
        public async Task<IActionResult> DeleteFeature(ObjectId id)
        {
            await _FeatureService.TDeleteAsync(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult CreateFeature()
        {
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> CreateFeature(CreateFeatureDto createFeatureDto)
        {
            var createmap = _mapper.Map<Feature>(createFeatureDto);
            await _FeatureService.TCreateAsync(createmap);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public async Task<IActionResult> UpdateFeature(ObjectId id)
        {
            var values = await _FeatureService.TGetByIdAsync(id);
            var getbyid = _mapper.Map<UpdateFeatureDto>(values);
            return View(getbyid);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateFeature(UpdateFeatureDto updateFeature)
        {

            var updatemap = _mapper.Map<Feature>(updateFeature);
            await _FeatureService.TUpdateAsync(updatemap);
            return RedirectToAction("Index");

        }
    }
}

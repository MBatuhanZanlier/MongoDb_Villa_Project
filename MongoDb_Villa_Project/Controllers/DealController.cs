using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Villa.BusinessLayer.Abstract;
using Villa.Dto.DealDtos;
using Villa.EntityLayer.Entities;
namespace MongoDb_Villa_Project.Controllers
{
    public class DealController : Controller
    {
        private readonly IDealService _DealService;
        private readonly IMapper _mapper;

        public DealController(IMapper mapper, IDealService dealService)
        {
            _mapper = mapper;
            _DealService = dealService;
        }


        public async Task<IActionResult> Index()
        {
            var values = await _DealService.TGetListAsync();
            var DealList = _mapper.Map<List<ResultDealDto>>(values);
            return View(DealList);
        }
        [HttpGet]
        public async Task<IActionResult> DeleteDeal(ObjectId id)
        {
            await _DealService.TDeleteAsync(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult CreateDeal()
        {
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> CreateDeal(CreateDealDto createDealDto)
        {
            var createmap = _mapper.Map<Deal>(createDealDto);
            await _DealService.TCreateAsync(createmap);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public async Task<IActionResult> UpdateDeal(ObjectId id)
        {
            var values = await _DealService.TGetByIdAsync(id);
            var getbyid = _mapper.Map<UpdateDealDto>(values);
            return View(getbyid);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateDeal(UpdateDealDto updateDeal)
        {

            var updatemap = _mapper.Map<Deal>(updateDeal);
            await _DealService.TUpdateAsync(updatemap);
            return RedirectToAction("Index");

        }
    }
}

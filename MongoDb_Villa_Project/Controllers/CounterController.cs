using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Villa.BusinessLayer.Abstract;
using Villa.Dto.CounterDtos;
using Villa.EntityLayer.Entities;

namespace MongoDb_Villa_Project.Controllers
{
    public class CounterController : Controller
    {
        private readonly ICounterService _CounterService;
        private readonly IMapper _mapper;

        public CounterController(ICounterService counterservice, IMapper mapper)
        {
            _CounterService = counterservice;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _CounterService.TGetListAsync();
            var CounterList = _mapper.Map<List<ResultCounterDto>>(values);
            return View(CounterList);
        }
        [HttpGet]
        public async Task<IActionResult> DeleteCounter(ObjectId id)
        {
            await _CounterService.TDeleteAsync(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult CreateCounter()
        {
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> CreateCounter(CreateCounterDto createCounterDto)
        {
            var createmap = _mapper.Map<Counter>(createCounterDto);
            await _CounterService.TCreateAsync(createmap);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public async Task<IActionResult> UpdateCounter(ObjectId id)
        {
            var values = await _CounterService.TGetByIdAsync(id);
            var getbyid = _mapper.Map<UpdateCounterDto>(values);
            return View(getbyid);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateCounter(UpdateCounterDto updateCounter)
        {

            var updatemap = _mapper.Map<Counter>(updateCounter);
            await _CounterService.TUpdateAsync(updatemap);
            return RedirectToAction("Index");

        }
    }
}

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Villa.BusinessLayer.Abstract;
using Villa.Dto.SubHeaderDtos;
using Villa.EntityLayer.Entities;

namespace MongoDb_Villa_Project.Controllers
{
    public class SubHeaderController : Controller
    { 
        private readonly ISubHeaderService _SubHeaderService;
        private readonly IMapper _mapper;
        public SubHeaderController(ISubHeaderService subHeaderService, IMapper mapper)
        {
            _SubHeaderService = subHeaderService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _SubHeaderService.TGetListAsync();
            var SubHeaderList = _mapper.Map<List<ResultSubHeaderDto>>(values);
            return View(SubHeaderList);
        }
        [HttpGet]
        public async Task<IActionResult> DeleteSubHeader(ObjectId id)
        {
            await _SubHeaderService.TDeleteAsync(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult CreateSubHeader()
        {
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> CreateSubHeader(CreateSubHeaderDto createSubHeaderDto)
        {
            var createmap = _mapper.Map<SubHeader>(createSubHeaderDto);
            await _SubHeaderService.TCreateAsync(createmap);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public async Task<IActionResult> UpdateSubHeader(ObjectId id)
        {
            var values = await _SubHeaderService.TGetByIdAsync(id);
            var getbyid = _mapper.Map<UpdateSubHeaderDto>(values);
            return View(getbyid);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateSubHeader(UpdateSubHeaderDto updateSubHeader)
        {

            var updatemap = _mapper.Map<SubHeader>(updateSubHeader);
            await _SubHeaderService.TUpdateAsync(updatemap);
            return RedirectToAction("Index");

        }
    }
}

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Villa.BusinessLayer.Abstract;
using Villa.BusinessLayer.Validators.QuestValidator;
using Villa.Dto.QuestDtos;
using Villa.EntityLayer.Entities;

namespace MongoDb_Villa_Project.Controllers
{
    public class QuestController : Controller
    { 
        private readonly IQuestService _QuestService;
        private readonly IMapper _mapper;
        public QuestController(IQuestService questService, IMapper mapper)
        {
            _QuestService = questService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _QuestService.TGetListAsync();
            var QuestList = _mapper.Map<List<ResultQuestDto>>(values);
            return View(QuestList);
        }
        [HttpGet]
        public async Task<IActionResult> DeleteQuest(ObjectId id)
        {
            await _QuestService.TDeleteAsync(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult CreateQuest()
        {
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> CreateQuest(CreateQuestDto createQuestDto)
        {
            ModelState.Clear();
            var createmap = _mapper.Map<Quest>(createQuestDto);
            var validator = new CreateQuestValidator();
            var result = validator.Validate(createmap); 
            if(!result.IsValid)
            {
                result.Errors.ForEach(x =>
                {
                    ModelState.AddModelError(x.PropertyName, x.ErrorMessage);
                });
                return View();
            }
            await _QuestService.TCreateAsync(createmap);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public async Task<IActionResult> UpdateQuest(ObjectId id)
        {
            var values = await _QuestService.TGetByIdAsync(id);
            var getbyid = _mapper.Map<UpdateQuestDto>(values);
            return View(getbyid);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateQuest(UpdateQuestDto updateQuest)
        {

            var updatemap = _mapper.Map<Quest>(updateQuest);
            await _QuestService.TUpdateAsync(updatemap);
            return RedirectToAction("Index");

        }
    }
}

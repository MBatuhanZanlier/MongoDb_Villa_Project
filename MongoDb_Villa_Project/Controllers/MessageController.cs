using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Villa.BusinessLayer.Abstract;
using Villa.Dto.MessageDtos;
using Villa.EntityLayer.Entities;

namespace MongoDb_Villa_Project.Controllers
{
    public class MessageController : Controller
    { 
        private readonly IMessageService _MessageService;
        private readonly IMapper _mapper;
        public MessageController(IMessageService messageService, IMapper mapper)
        {
            _MessageService = messageService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _MessageService.TGetListAsync();
            var MessageList = _mapper.Map<List<ResultMessageDto>>(values);
            return View(MessageList);
        }
        [HttpGet]
        public async Task<IActionResult> DeleteMessage(ObjectId id)
        {
            await _MessageService.TDeleteAsync(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult CreateMessage()
        {
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> CreateMessage(CreateMessageDto createMessageDto)
        {
            var createmap = _mapper.Map<Message>(createMessageDto);
            await _MessageService.TCreateAsync(createmap);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public async Task<IActionResult> MessageDetails(ObjectId id)
        {
            var values = await _MessageService.TGetByIdAsync(id);
            var getbyid = _mapper.Map<ResultMessageDto>(values);
            return View(getbyid);
        }
        //[HttpPost]
        //public async Task<IActionResult> UpdateMessage(UpdateMessageDto updateMessage)
        //{

        //    var updatemap = _mapper.Map<Message>(updateMessage);
        //    await _MessageService.TUpdateAsync(updatemap);
        //    return RedirectToAction("Index");

        //}
    }
}

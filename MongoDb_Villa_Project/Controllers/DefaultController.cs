using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Villa.BusinessLayer.Abstract;
using Villa.Dto.MessageDtos;
using Villa.EntityLayer.Entities;

namespace MongoDb_Villa_Project.Controllers
{
    public class DefaultController : Controller
    { 
        private readonly IMessageService _messageService;
        private readonly IMapper _mapper;
        public DefaultController(IMessageService messageService, IMapper mapper)
        {
            _messageService = messageService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> SendMessage(CreateMessageDto createMessage)
        { 
            createMessage.MessageDate = DateTime.Now;
            var mappig=_mapper.Map<Message>(createMessage); 
            await _messageService.TCreateAsync(mappig);
            return RedirectToAction("Index");
        }
    }
}

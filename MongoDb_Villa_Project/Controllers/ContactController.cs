using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Villa.BusinessLayer.Abstract;
using Villa.Dto.ContactDtos;
using Villa.EntityLayer.Entities;


namespace MongoDb_Villa_Project.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;
        public ContactController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _contactService.TGetListAsync();
            var contactList = _mapper.Map<List<ResultContactDto>>(values);
            return View(contactList);
        }
        [HttpGet]
        public async Task<IActionResult> DeleteContact(ObjectId id)
        {
            await _contactService.TDeleteAsync(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult CreateContact()
        {
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> CreateContact(CreateContactDto createContactDto)
        {
            var createmap = _mapper.Map<Contact>(createContactDto);
            await _contactService.TCreateAsync(createmap);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public async Task<IActionResult> UpdateContact(ObjectId id)
        {
            var values = await _contactService.TGetByIdAsync(id);
            var getbyid = _mapper.Map<UpdateContactDto>(values);
            return View(getbyid);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateContact(UpdateContactDto updateContact)
        {

            var updatemap = _mapper.Map<Contact>(updateContact);
            await _contactService.TUpdateAsync(updatemap);
            return RedirectToAction("Index");

        }
    }
}

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Villa.BusinessLayer.Abstract;
using Villa.Dto.VideoDtos;
using Villa.EntityLayer.Entities;

namespace MongoDb_Villa_Project.Controllers
{
    public class VideoController : Controller
    { 
        private readonly IVideoService _VideoService;
        private readonly IMapper _mapper;
        public VideoController(IVideoService videoService, IMapper mapper)
        {
            _VideoService = videoService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var values = await _VideoService.TGetListAsync();
            var VideoList = _mapper.Map<List<ResultVideoDto>>(values);
            return View(VideoList);
        }

        [HttpGet]
        public async Task<IActionResult> DeleteVideo(ObjectId id)
        {
            await _VideoService.TDeleteAsync(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult CreateVideo()
        {
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> CreateVideo(CreateVideoDto createVideoDto)
        {
            var createmap = _mapper.Map<Video>(createVideoDto);
            await _VideoService.TCreateAsync(createmap);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public async Task<IActionResult> UpdateVideo(ObjectId id)
        {
            var values = await _VideoService.TGetByIdAsync(id);
            var getbyid = _mapper.Map<UpdateVideoDto>(values);
            return View(getbyid);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateVieo(UpdateVideoDto updateVideo)
        {

            var updatemap = _mapper.Map<Video>(updateVideo);
            await _VideoService.TUpdateAsync(updatemap);
            return RedirectToAction("Index");

        }
        public async Task<IActionResult> VideoDetails(ObjectId id)
        {
            var value = await _VideoService.TGetByIdAsync(id);
            var Video = _mapper.Map<ResultVideoDto>(value);
            return View(Video);
        }
    }
}

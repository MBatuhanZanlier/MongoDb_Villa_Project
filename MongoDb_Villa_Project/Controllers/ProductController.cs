using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Villa.BusinessLayer.Abstract;
using Villa.Dto.ProductDtos;
using Villa.EntityLayer.Entities;

namespace MongoDb_Villa_Project.Controllers
{
    public class ProductController : Controller
    { 
        private readonly IProductService _ProductService;
        private readonly IMapper _mapper;
        public ProductController(IProductService productService, IMapper mapper)
        {
            _ProductService = productService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _ProductService.TGetListAsync();
            var ProductList = _mapper.Map<List<ResultProductDto>>(values);
            return View(ProductList);
        } 

        [HttpGet]
        public async Task<IActionResult> DeleteProduct(ObjectId id)
        {
            await _ProductService.TDeleteAsync(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
        {
            var createmap = _mapper.Map<Product>(createProductDto);
            await _ProductService.TCreateAsync(createmap);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public async Task<IActionResult> UpdateProduct(ObjectId id)
        {
            var values = await _ProductService.TGetByIdAsync(id);
            var getbyid = _mapper.Map<UpdateProductDto>(values);
            return View(getbyid);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProduct)
        {

            var updatemap = _mapper.Map<Product>(updateProduct);
            await _ProductService.TUpdateAsync(updatemap);
            return RedirectToAction("Index");

        } 
        public async Task<IActionResult> ProductDetails(ObjectId id)
        {
            var value=await _ProductService.TGetByIdAsync(id); 
            var product=_mapper.Map<ResultProductDto>(value);
            return View(product);
        }
    }
}

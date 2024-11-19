using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Villa.Dto.IdentityDtos;
using Villa.EntityLayer.Entities;

namespace MongoDb_Villa_Project.Controllers
{

    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager; 
        private readonly SignInManager<AppUser> _signInManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterDto dto)
        {
            var user = new AppUser()
            {
                NameSurname = dto.NameSurname,
                Email = dto.Email,
                UserName = dto.UserName
            };
            var result = await _userManager.CreateAsync(user,dto.Password);

            if (!result.Succeeded)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return View();

            }
            return RedirectToAction("Login");
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost] 
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            var user = await _userManager.FindByNameAsync(loginDto.UserName); 
            if(user == null)  
            {
                ModelState.AddModelError("", "Kullanıcı adı veya Şifresi Hatalı");
                return View();
            } 
            var result=await _signInManager.CheckPasswordSignInAsync(user, loginDto.Password,false); 
            if (!result.Succeeded)  
            {
                ModelState.AddModelError("", "Kullacı Adı Veya Şifre Hatalı");
                return View();
            }
            return View("Index","Banner");
        }


    }
}

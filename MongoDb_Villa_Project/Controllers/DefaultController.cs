using Microsoft.AspNetCore.Mvc;

namespace MongoDb_Villa_Project.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

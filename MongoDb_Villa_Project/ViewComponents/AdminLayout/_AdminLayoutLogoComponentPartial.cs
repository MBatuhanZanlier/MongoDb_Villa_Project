using Microsoft.AspNetCore.Mvc;

namespace MongoDb_Villa_Project.ViewComponents.AdminLayout
{
    public class _AdminLayoutLogoComponentPartial:ViewComponent
    { 
        public IViewComponentResult Invoke() { return View(); }
    }
}

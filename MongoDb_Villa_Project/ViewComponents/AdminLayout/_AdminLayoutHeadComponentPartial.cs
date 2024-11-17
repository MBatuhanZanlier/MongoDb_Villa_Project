using Microsoft.AspNetCore.Mvc;

namespace MongoDb_Villa_Project.ViewComponents.AdminLayout
{
    public class _AdminLayoutHeadComponentPartial:ViewComponent
    { 
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

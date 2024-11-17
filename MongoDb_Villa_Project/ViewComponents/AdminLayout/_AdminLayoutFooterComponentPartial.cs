using Microsoft.AspNetCore.Mvc;

namespace MongoDb_Villa_Project.ViewComponents.AdminLayout
{
    public class _AdminLayoutFooterComponentPartial:ViewComponent
    { 
        public IViewComponentResult Invoke() { return View(); }
    }
}

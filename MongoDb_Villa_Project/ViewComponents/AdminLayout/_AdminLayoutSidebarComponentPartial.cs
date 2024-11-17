using Microsoft.AspNetCore.Mvc;

namespace MongoDb_Villa_Project.ViewComponents.AdminLayout
{
    public class _AdminLayoutSidebarComponentPartial:ViewComponent
    { 
        public IViewComponentResult Invoke() { return View(); }
    }
}

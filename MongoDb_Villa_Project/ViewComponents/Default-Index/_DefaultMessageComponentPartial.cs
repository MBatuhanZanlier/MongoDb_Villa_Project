using Microsoft.AspNetCore.Mvc;

namespace MongoDb_Villa_Project.ViewComponents.Default_Index
{
    public class _DefaultMessageComponentPartial:ViewComponent
    { 
        public IViewComponentResult Invoke() { return View(); }
    }
}

using Microsoft.AspNetCore.Mvc;

using WEB.AppInfra.Security.Filters;

namespace WEB.Controllers {
    
    public class StartController : RestrictController {
        public IActionResult Index() {
            return RedirectToAction("Home", "Home", new {area = "Start"});
        }
    }
}
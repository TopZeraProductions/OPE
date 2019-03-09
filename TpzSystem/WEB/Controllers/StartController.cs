using Microsoft.AspNetCore.Mvc;

namespace WEB.Controllers {

    public class StartController : Controller {
        public IActionResult Index() {
            return RedirectToAction("Home", "Home", new {area = "Start"});
        }
    }
}
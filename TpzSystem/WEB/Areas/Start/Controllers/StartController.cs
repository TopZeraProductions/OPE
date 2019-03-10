using Microsoft.AspNetCore.Mvc;

using WEB.AppInfra.Cookies.Interface;
using WEB.AppInfra.Security.SessionUser;

namespace WEB.Areas.Start.Controllers {

    [Area("start")]
    public class HomeController : Controller {
        
        private ICookieServices CookiesServices;
        private SessionUser     SessionUser;
        
        public HomeController(ICookieServices _ICookieServices, 
                                         SessionUser _SessionUser) {
            
            CookiesServices = _ICookieServices;
            SessionUser     = _SessionUser;
        }
        
        public IActionResult Index() {
            return RedirectToAction("Home");
        }

        public IActionResult Home() {
            
            return View();
        }
        
    }
}
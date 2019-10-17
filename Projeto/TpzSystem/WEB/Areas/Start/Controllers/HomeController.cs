using Microsoft.AspNetCore.Mvc;

using WEB.AppInfra.Cookies;
using WEB.AppInfra.Cookies.Service;
using WEB.AppInfra.Security.Filters;
using WEB.AppInfra.Security.SessionUserConfiguration;
using WEB.Controllers;

namespace WEB.Areas.Start.Controllers {

    [Area("start")]
    public class HomeController : RestrictController {
        
        private CookieServices CookiesServices;
        private SessionUser     SessionUser;
        private SessionServices SessionServices;
        
        public HomeController(CookieServices _ICookieServices, 
                              SessionUser _SessionUser,
                              SessionServices _SessionServices) {
            
            CookiesServices = _ICookieServices;
            SessionUser     = _SessionUser;
            SessionServices = _SessionServices;
        }
        
        public IActionResult Index() {
            return RedirectToAction("index", "DashBoardConsult", new {area = "Dashboard"});
        }

        public IActionResult Home() {
            
            return RedirectToAction("index", "DashBoardConsult", new {area = "Dashboard"});
        }
    }
}
using System.Diagnostics;

using Microsoft.AspNetCore.Mvc;

using WEB.AppInfra.Cookies.Interface;
using WEB.AppInfra.Security.SessionUser;
using WEB.Models;

namespace WEB.Areas.Home.Controllers {

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
        
        [ActionName("partial-cookie-consent")]
        public IActionResult PartialCookieConsent() {
            
            return View();
        }
        
        public IActionResult Privacy() {
            return View();
        }

        public IActionResult Error() {
            return View(
                new ErrorViewModel {
                    RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
                }
            );
        }
    }
}
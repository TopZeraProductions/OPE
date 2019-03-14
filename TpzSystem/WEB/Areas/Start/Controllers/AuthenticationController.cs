using Microsoft.AspNetCore.Mvc;

using WEB.AppInfra.Cookies.Service;
using WEB.AppInfra.Security.SessionUserConfiguration;
using WEB.AppStart.Models.Forms;

namespace WEB.Areas.Start.Controllers {
    
    [Area("start")]
    public class AuthenticationController : Controller {
        private readonly SessionUser SessionUser;
        
        public AuthenticationController(SessionUser _SessionUser) {
            
            SessionUser = _SessionUser;
        }
        
        public IActionResult Index() => RedirectToAction("Login");

        [HttpGet]
        public IActionResult Login() {
            if (SessionUser.id > 0) {
                return RedirectToAction("Index", "Start");
            }
            
            SessionUser.id = 12545668;
            
            return View();
        }
        
        [HttpPost]
        public IActionResult LoginRegister(LoginForm Form) {
            
            return Json(new { name = "ok" });
        }
        
        public IActionResult Logout() {
            SessionUser.ClearSessions();
            
            return RedirectToAction("Index", "Start");
        }
    }
}
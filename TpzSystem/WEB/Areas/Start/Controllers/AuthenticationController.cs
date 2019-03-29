using Microsoft.AspNetCore.Mvc;

using WEB.AppInfra.Security.SessionUserConfiguration;
using WEB.Areas.Start.Models.Forms;

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
            
            return View();
        }
        
        [HttpPost]
        public IActionResult LoginRegister(LoginForm Form) {
            if (Form.login == "topzera"
                && Form.password == "123123") {
                
                SessionUser.id = 12545668;
            }
            
            return RedirectToAction("Login");
        }
        
        public IActionResult Logout() {
            SessionUser.ClearSessions();
            
            return RedirectToAction("Index", "Start");
        }
    }
}
using Microsoft.AspNetCore.Mvc;

using WEB.AppInfra.Cookies;
using WEB.AppInfra.Cookies.Interface;
using WEB.AppInfra.Cookies.Service;
using WEB.AppInfra.Security.SessionUser;

namespace WEB.Areas.Products.Controllers {

    [Area("Products")]
    public class ProductsConsultController : Controller {
        private ICookieServices CookiesServices;
        private SessionUser     SessionUser;
        
        public ProductsConsultController(ICookieServices _ICookieServices, 
                                         SessionUser _SessionUser) {
            
            CookiesServices = _ICookieServices;
            SessionUser     = _SessionUser;
        }
        
        public IActionResult Index() {
            return RedirectToAction("ListProducts");
        }

        public IActionResult ListProducts() {
            SessionUser.id = 10;
            ViewBag.teste  = SessionUser.id;
            
            SessionUser.idCrypt = "10";
            ViewBag.teste2  = SessionUser.idCrypt;
            
            SessionUser.name = "joao";
            ViewBag.teste3 = SessionUser.name;
            
            SessionUser.nameCrypt = "joao";
            ViewBag.teste4        = SessionUser.nameCrypt;

            return View();
        }
    }
}
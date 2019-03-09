using Microsoft.AspNetCore.Mvc;

using WEB.AppInfra.Cookies;
using WEB.AppInfra.Cookies.Interface;
using WEB.AppInfra.Cookies.Service;

namespace WEB.Areas.Products.Controllers {

    [Area("Products")]
    public class ProductsConsultController : Controller {
        private ICookieServices CookiesServices;
        
        public ProductsConsultController(ICookieServices _ICookieServices) {
            CookiesServices = _ICookieServices;
        }
        
        public IActionResult Index() {
            return RedirectToAction("ListProducts");
        }

        public IActionResult ListProducts() {
            CookiesServices.WriteCookie("teste","teste", false);
            CookiesServices.ConcatCookie("teste", " asd");

            CookiesServices.WriteCookie("lastproductseed", "");
            CookiesServices.ConcatCookie("lastproductseed",";1236");
            
            ViewBag.teste = CookiesServices.ReadCookie("teste");

            return View();
        }
    }
}
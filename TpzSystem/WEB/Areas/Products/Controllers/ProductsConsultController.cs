using Microsoft.AspNetCore.Mvc;

namespace WEB.Areas.Products.Controllers {

    [Area("Products")]
    public class ProductsConsultController : Controller {
        
        public IActionResult Index() {
            return RedirectToAction("ListProducts");
        }

        public IActionResult ListProducts() {
            return View();
        }
    }

}
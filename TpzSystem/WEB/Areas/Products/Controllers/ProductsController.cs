using Microsoft.AspNetCore.Mvc;

namespace WEB.Areas.Products.Controllers {

    [Area("products")]
    public class ProductsController : Controller {
        
        public IActionResult Index() {
            return RedirectToAction("ListProducts");
        }

        public IActionResult ListProducts() {
            return View();
        }
    }

}
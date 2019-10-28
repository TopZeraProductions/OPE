using Microsoft.AspNetCore.Mvc;
using WEB.Controllers;

namespace WEB.Areas.Dashboard.Controllers {

    [Area("DashBoard")]
    public class DashBoardConsultController : RestrictController {

        public IActionResult Index() { // DashBoard/DashBoardConsult/index
            return View();
        }
    }
}
using System;

using Microsoft.AspNetCore.Mvc;

using WEB.Controllers;

namespace WEB.Areas.Orders.Controllers {

    [Area("Orders")]
    public class OrderConsultController : RestrictController{

        public IActionResult Index() => throw new NotImplementedException();

        public IActionResult ShowOrder() { // get: Orders/OrderConsult/ShowOrder

            return View();
        }
    }

}
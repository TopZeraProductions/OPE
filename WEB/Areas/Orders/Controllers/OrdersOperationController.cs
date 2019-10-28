using System;

using DAL.Models.Orders.Services.Contracts;

using Microsoft.AspNetCore.Mvc;

using WEB.Areas.Orders.Models.Forms;
using WEB.Controllers;

namespace WEB.Areas.Orders.Controllers {

    [Area("Orders")]
    public class OrdersOperationController : RestrictController {

        private readonly IOrderServicesDAL _orderServicesDAL;

        public OrdersOperationController(IOrderServicesDAL orderServicesDAL) {
            _orderServicesDAL = orderServicesDAL;
        }

        public IActionResult Index() {
            var Form = new RegisterOrderForm() {};

            return View(Form);
        }

    }

}
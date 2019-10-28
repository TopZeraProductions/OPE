using System;

using DAL.Models.Orders.Services.Contracts;

using Microsoft.AspNetCore.Mvc;
using WEB.Controllers;

namespace WEB.Areas.Orders.Controllers {

    [Area("Orders")]
    public class OrderConsultController : RestrictController {

        private readonly IOrderServicesDAL _orderServicesDAL;

        public OrderConsultController(IOrderServicesDAL IOrderServicesDAL) {
            _orderServicesDAL = IOrderServicesDAL;
        }

        public IActionResult Index() => throw new NotImplementedException();

        public IActionResult ShowOrder() => View();

    }

}
using System;
using System.Collections;
using System.Linq;

using BLL.Orders.Contracts;
using BLL.Orders.Implementations;

using DAL.Models.Orders.Services.Contracts;

using DTO.Orders;
using DTO.Products;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Rewrite.Internal;

using WEB.AppInfra;
using WEB.Controllers;

namespace WEB.Areas.Orders.Controllers {

    [Area("Orders")]
    public class OrderConsultController : RestrictController {

        public IOrderBl _orderbl { get; set; }

        public OrderConsultController(IOrderBl orderbl) {
            _orderbl = orderbl;
        }

        public IActionResult Index() => throw new NotImplementedException();

        public IActionResult ShowOrder() => View();

    }

}
using System;
using System.Linq;

using BLL.Orders.Contracts;

using DTO.Orders;

using Microsoft.AspNetCore.Mvc;

using WEB.AppInfra;
using WEB.Areas.Orders.Models.Forms;
using WEB.Controllers;

namespace WEB.Areas.Orders.Controllers {

    [Area("Orders")]
    public class OrdersRegisterController : RestrictController {

        public IOrderBl _orderbl { get; set; }

        public OrdersRegisterController(IOrderBl orderbl) {
            _orderbl = orderbl;
        }

        [HttpPost]
        public JsonResult RegisterOrder(RegisterOrderForm form) {
            if (!form.IdsProducts.Any()) {
                return Json(new {
                    error   = true,
                    message = "O pedido deverá ter ao menos um produto"
                });
            }

            if (form.idClient <= 0) {
                return Json(new {
                    error   = true,
                    message = "O cliente deverá ser vinculado ao pedido"
                });
            }

            if (form.PaymentMode <= 0) {
                return Json(new {
                    error   = true,
                    message = "O pagamento deverá ser informado"
                });
            }

            var order = new Order {
                Active      = true,
                IdClient    = form.idClient,
                Status      = (byte) OrderStatus.InProgress,
                PaymentMode = form.PaymentMode
            };

            var listItens = form.IdsProducts.Select(id => new OrderItem {
                IdProduct = id,
                Active    = true,
            }).ToListJsonObject<OrderItem>();

            this._orderbl.GenerateOrder(order, form.idClient, listItens);

            var json = new {
                error       = false,
                message     = "Pedido efetuado com sucesso",
                urlRedirect = Url.Action("")
            };

            return Json(json);
        }

    }

}
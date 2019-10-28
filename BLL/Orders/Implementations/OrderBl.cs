using System.Collections.Generic;
using System.Linq;
using BLL.Orders.Contracts;
using DAL.Models.Clients.Services.Contracts;
using DAL.Models.Orders.Services.Contracts;
using DTO.Orders;
using UTIL.Wrappers;

namespace BLL.Orders.Implementations {
    public class OrderBl : IOrderBl {
        
        private readonly IClientServicesDAL     _clientServicesDAL;
        private readonly IOrderServicesDAL      _orderServicesDAL;
        private readonly IOrderItemServicesDAL  _itemServicesDAL;
        
        public OrderBl(IClientServicesDAL    clientServicesDAL, 
                       IOrderServicesDAL     orderServicesDAL, 
                       IOrderItemServicesDAL itemServices) {
            
            _clientServicesDAL = clientServicesDAL;
            _orderServicesDAL  = orderServicesDAL;
            _itemServicesDAL   = itemServices;
        }


        public GenericReturn GenerateOrder(Order order, int idClient, IList<OrderItem> items) {

            order.IdClient = idClient;
            
            _orderServicesDAL.Add(order);

            var idOrder = order.Id;

            foreach (var item in items) {
                item.IdOrder = idOrder;
            }
            
            _itemServicesDAL.Add(items.ToArray());
            
            return new GenericReturn(false, "pedido efetuado com sucesso");
        }

        public GenericReturn ChangeState(int idOrder, OrderStatus status)
        {
            var order = _orderServicesDAL.GetSingle(c => c.Id == idOrder);
            order.Status = (byte) status;
            
            _orderServicesDAL.Update(order);
            
            return new GenericReturn(false, "Status do pedido alterado com sucesso");
        }
    }
}
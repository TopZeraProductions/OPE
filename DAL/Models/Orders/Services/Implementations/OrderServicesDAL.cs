using System.Collections.Generic;
using System.Linq;

using DAL.Core;
using DAL.Core.Implementations;
using DAL.Models.Orders.Services.Contracts;

using DTO.Orders;

using UTIL.Wrappers;

namespace DAL.Models.Orders.Services.Implementations {

    public class OrderServicesDAL : GenericDataServicesDAL<Order>, IOrderServicesDAL {
        
        private readonly IOrderItemServicesDAL _itemServicesDAL;

        public OrderServicesDAL(IOrderItemServicesDAL itemServices, 
                                DefaultContext        defaultContext) 
            : base(defaultContext) {
            
            _itemServicesDAL   = itemServices;
        }


        public GenericReturn GenerateOrder(Order order, int idClient, IList<OrderItem> items) {
            
            order.IdClient = idClient;

            this.Add(order);

            var idOrder = order.Id;

            foreach (var item in items) {
                item.IdOrder = idOrder;
            }

            _itemServicesDAL.Add(items.ToArray());

            return new GenericReturn(false, "pedido efetuado com sucesso");
        }

        public GenericReturn ChangeState(int idOrder, OrderStatus status) {
            var order = this.GetSingle(c => c.Id == idOrder);
            
            order.Status = (byte) status;

            this.Update(order);

            return new GenericReturn(false, "Status do pedido alterado com sucesso");
        }

    }

}
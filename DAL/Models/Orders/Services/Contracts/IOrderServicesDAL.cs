using System.Collections.Generic;

using DAL.Core.Contracts;
using DTO.Orders;

using UTIL.Wrappers;

namespace DAL.Models.Orders.Services.Contracts {
    public interface IOrderServicesDAL : IGenericDataServicesDAL<Order> {
        
        GenericReturn GenerateOrder(Order order, int idClient, IList<OrderItem> idItems);

        GenericReturn ChangeState(int idOrder, OrderStatus status);
        
    }
}
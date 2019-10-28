using System.Collections.Generic;
using DTO.Orders;
using UTIL.Wrappers;

namespace BLL.Orders.Contracts
{
    public interface IOrderBl
    {
        GenericReturn GenerateOrder(Order order, int idClient, IList<OrderItem> idItems);

        GenericReturn ChangeState(int idOrder, OrderStatus status);
    }
}
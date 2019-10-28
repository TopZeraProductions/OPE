using DAL.Core;
using DAL.Core.Implementations;
using DAL.Models.Orders.Services.Contracts;
using DTO.Orders;

namespace DAL.Models.Orders.Services.Implementations {
    public class OrderItemServicesDAL : GenericDataServicesDAL<OrderItem>, IOrderItemServicesDAL {
        public OrderItemServicesDAL(DefaultContext defaultContext) : base(defaultContext)
        {
        }
    }
}
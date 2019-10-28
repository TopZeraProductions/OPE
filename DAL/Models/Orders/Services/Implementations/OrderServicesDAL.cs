using DAL.Core;
using DAL.Core.Implementations;
using DAL.Models.Orders.Services.Contracts;
using DTO.Orders;

namespace DAL.Models.Orders.Services.Implementations {
    public class OrderServicesDAL : GenericDataServicesDAL<Order>, IOrderServicesDAL {
        public OrderServicesDAL(DefaultContext defaultContext) : base(defaultContext)
        {
        }
    }
}
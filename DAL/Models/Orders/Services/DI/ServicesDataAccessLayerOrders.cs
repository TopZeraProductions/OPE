using DAL.Models.Orders.Services.Contracts;
using DAL.Models.Orders.Services.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace DAL.Models.Orders.Services.DI 
{
    public static class ServicesDataAccessLayerOrders
    {
        public static void Mapping(ref IServiceCollection services)
        {
            services.AddTransient<IOrderServicesDAL, OrderServicesDAL>();
            services.AddTransient<IOrderItemServicesDAL, OrderItemServicesDAL>();
        }
    }
}
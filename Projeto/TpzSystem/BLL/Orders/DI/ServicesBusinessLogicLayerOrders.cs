using BLL.Orders.Contracts;
using BLL.Orders.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace BLL.Orders.DI {
    public static class ServicesBusinessLogicLayerOrders {
        public static void Mapping(ref IServiceCollection services)
        {
            services.AddTransient<IOrderBl, OrderBl>();
        }
    }
}
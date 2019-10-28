using BLL.Orders.DI;
using DAL.Core;
using DAL.Models.Clients.Services.DI;
using Microsoft.Extensions.DependencyInjection;

namespace BLL.Core.DI
{
    public static class ServicesBusinessLogicLayer
    {
        public static void Mapping(ref IServiceCollection services)
        {
            ServicesBusinessLogicLayerOrders.Mapping(ref services);
        }
    }
}
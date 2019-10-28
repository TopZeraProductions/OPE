using DAL.Models.Clients.Services.DI;
using DAL.Models.Orders.Services.DI;
using DAL.Models.Products.Services.DI;
using Microsoft.Extensions.DependencyInjection;

namespace DAL.Core.DI
{
    public static class ServicesDataAccessLayer
    {
        public static void Mapping(ref IServiceCollection services)
        {
            ServicesDataAccessLayerClients.Mapping(ref services);
            ServicesDataAccessLayerOrders.Mapping(ref services);
            ServicesDataAccessLayerProducts.Mapping(ref services);

            services.AddSingleton<DefaultContext, DefaultContext>();
        }
    }
}
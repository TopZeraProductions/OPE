using DAL.Models.Clients.Services.Contracts;
using DAL.Models.Clients.Services.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace DAL.Models.Clients.Services.DI
{
    public static class ServicesDataAccessLayerClients
    {
        public static void Mapping(ref IServiceCollection services)
        {
            services.AddTransient<IClientServicesDAL, ClientServicesDAL>();
        }
    }
}
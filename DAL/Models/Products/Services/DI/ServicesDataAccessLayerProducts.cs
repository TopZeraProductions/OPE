using DAL.Models.Products.Services.Contracts;
using DAL.Models.Products.Services.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace DAL.Models.Products.Services.DI {
    public static class ServicesDataAccessLayerProducts
    {
        public static void Mapping(ref IServiceCollection services)
        {
            services.AddTransient<IProductServicesDAL, ProductServicesDAL>();
        }
    }
}
using DAL.Core;
using DAL.Core.Implementations;
using DAL.Models.Orders.Services.Contracts;
using DAL.Models.Products.Services.Contracts;
using DTO.Products;

namespace DAL.Models.Products.Services.Implementations {
    public class ProductServicesDAL : GenericDataServicesDAL<Product>, IProductServicesDAL {
        public ProductServicesDAL(DefaultContext defaultContext) : base(defaultContext)
        {
        }
    }
}